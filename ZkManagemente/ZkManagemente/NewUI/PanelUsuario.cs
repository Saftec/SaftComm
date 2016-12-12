using System;
using System.Collections.Generic;
using System.Data;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.NewUI.Generic
{
    public partial class PanelUsuario : GenericPanel
    {

        private static PanelUsuario _instancia;

        public static PanelUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PanelUsuario();
                }
                _instancia.RefreshGrid();
                return _instancia;
            }
        }

        LogicUsuario lu;

        private PanelUsuario()
        {
            InitializeComponent();           
        }
        public void RefreshGrid()
        {
            lu = new LogicUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                gridUsuarios.DataSource = null;
                gridUsuarios.Refresh();
                usuarios = lu.GetUsuarios();
                gridUsuarios.DataSource = (ConvertToDataTable(usuarios));
                gridUsuarios.Refresh();
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Usuarios");
            }
        }

        private DataTable ConvertToDataTable(List<Usuario> usuarios)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Contraseña");
            dt.Columns.Add("Permisos");
            dt.Columns.Add("IdPermisos");
            dt.Columns.Add("IdUsuario");

            foreach (Usuario u in usuarios)
            {
                DataRow row = dt.NewRow();
                row["Usuario"] = u.Usr;
                row["Contraseña"] = u.Pass;
                row["Permisos"] = u.Permisos;
                row["IdPermisos"] = u.Nivel;
                row["IdUsuario"] = u.Id;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
