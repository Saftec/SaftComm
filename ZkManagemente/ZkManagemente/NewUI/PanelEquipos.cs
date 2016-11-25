using System;
using System.Collections.Generic;
using System.Data;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.Generic
{
    public partial class PanelEquipos : GenericPanel
    {
        //         PATRON SINGLETON            //
        private static PanelEquipos _instancia;

        public static PanelEquipos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PanelEquipos();
            }
            return _instancia;
        }

        private LogicReloj lr;
        private Reloj relojAct;

        public PanelEquipos()
        {
            InitializeComponent();
            relojAct = new Reloj();
        }

        public void RefreshGrid()
        {
            lr = new LogicReloj();
            gridEquipos.DataSource = null;
            DataTable relojes;
            try
            {
                relojes=ConvertToDataTable(lr.TodosRelojes());
                gridEquipos.DataSource = relojes;
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Relojes.");
            }
        }

        private Reloj MapearDeGrid()
        {
            Reloj r = new Reloj();
            int valor = 0; // Lo uso para los TryParse a int.

            if(int.TryParse(gridEquipos.CurrentRow.Cells["Id"].ToString(), out valor))
            {
                r.Id = valor;
            }else
            {
                throw new AppException("Error al intentar convertir Id a INT.");
            }
            if (int.TryParse(gridEquipos.CurrentRow.Cells["Numero"].ToString(), out valor))
            {
                r.Numero = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir Numero de equipo a INT.");
            }
            if (int.TryParse(gridEquipos.CurrentRow.Cells["Puerto"].ToString(), out valor))
            {
                r.Puerto = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir el puerto a INT.");
            }
            if (gridEquipos.CurrentRow.Cells["Estado"].ToString() == "Conectado")
            {
                r.Estado = true;
            }
            else
            {
                r.Estado = false;
            }

            r.Nombre = gridEquipos.CurrentRow.Cells["Nombre"].ToString();
            r.Clave = gridEquipos.CurrentRow.Cells["Clave"].ToString();
            r.DNS = gridEquipos.CurrentRow.Cells["DNS"].ToString();
            r.Ip = gridEquipos.CurrentRow.Cells["IP"].ToString();

            return r;
        }


        private void linkConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Conectar Reloj.");
                return;
            }            
            if (relojAct.Estado)
            {
                base.InformarError("El dispositivo ya se encuentra conectado.", "Conectar Reloj.");
                return;
            }
            try
            {
                relojAct.Conectar();
                relojAct.Estado = true;
                base.Informar("Conexión exitosa!", "Conectar Reloj.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Conectar Reloj.");
            }
        }

        private DataTable ConvertToDataTable(List<Reloj> relojes)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("IP");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("IdReloj");
            dt.Columns.Add("Puerto");
            dt.Columns.Add("DNS");
            dt.Columns.Add("Numero");
            dt.Columns.Add("Clave");
            dt.Columns.Add("Estado");

            foreach (Reloj r in relojes)
            {
                DataRow row = dt.NewRow();
                row["IP"] = r.Ip;
                row["Nombre"] = r.Nombre;
                row["IdReloj"] = r.Id.ToString();
                row["Puerto"] = r.Puerto.ToString();
                row["Numero"] = r.Numero.ToString();
                row["Clave"] = r.Clave;
                row["DNS"] = r.DNS;

                if (r.Estado)
                {
                    row["Estado"] = "Conectado";
                }else
                {
                    row["Estado"] = "Desconectado";
                }

                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
