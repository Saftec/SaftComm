using System;
using System.Collections.Generic;
using System.Data;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

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

        #region Grid
        public void RefreshGrid()
        {
            lu = new LogicUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                gridUsuarios.AutoGenerateColumns = false;
                gridUsuarios.DataSource = null;
                gridUsuarios.Refresh();
                usuarios = lu.GetUsuarios();
                gridUsuarios.DataSource = (ConvertToDataTable(usuarios));
                gridUsuarios.Refresh();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Usuarios");
            }
        }
        private Usuario MapearDeGrid()
        {
            Usuario u = new Usuario();
            int valor = 0;

            if (int.TryParse(gridUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString(), out valor))
            {
                u.Id = valor;
            }
            else
            {
                throw new AppException("Error al convertir Id de usuario a entero");
            }

            if (int.TryParse(gridUsuarios.CurrentRow.Cells["IdPermisos"].Value.ToString(), out valor))
            {
                u.Nivel = valor;
            }
            else
            {
                throw new AppException("Error al convertir nivel de usuario a entero");
            }

            u.Usr = gridUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            u.PassDecrypt = gridUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();

            return u;
        }
        #endregion

        #region Menu
        private void linkNuevo_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            EditUsuario eu = new EditUsuario();
            u.Id = 0;

            try
            {
                eu.MapearAForm(u);
                eu.Show();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Usuario.");
            }
        }
        private void linkEdit_Click(object sender, EventArgs e)
        {
            EditUsuario eu = new EditUsuario();
            try
            {
                eu.MapearAForm(MapearDeGrid());
                eu.Show();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Usuario.");
            }
        }
        #endregion


        private DataTable ConvertToDataTable(List<Usuario> usuarios)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Contraseña");
            dt.Columns.Add("Permisos");
            dt.Columns.Add("IdPermisos");
            dt.Columns.Add("IdUsuario");
            dt.Columns.Add("UltAcceso");

            foreach (Usuario u in usuarios)
            {
                DataRow row = dt.NewRow();
                row["Usuario"] = u.Usr;
                row["Contraseña"] = u.PassEncrypt;
                row["Permisos"] = u.Permisos;
                row["IdPermisos"] = u.Nivel;
                row["IdUsuario"] = u.Id;
                row["UltAcceso"] = u.UltimoAcceso.ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void linkContraseña_Click(object sender, EventArgs e)
        {
            EditPsw ep = new EditPsw();
            ep.SetUsuario(MapearDeGrid());
            ep.Show();
        }
    }
}
