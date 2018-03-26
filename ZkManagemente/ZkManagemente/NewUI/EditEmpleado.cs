using System;
using Entidades;
using Logic;
using ZkManagement.NewUI.Generic;
using Util;

namespace ZkManagement.NewUI
{
    public partial class EditEmpleado : GenericAbm
    {
        private Empleado empActual;
        public EditEmpleado()
        {
            InitializeComponent();
        }

        protected override void btnGuardar_Click(object sender, EventArgs e)
        {
            if (empActual == null)
            {
                return;
            }
            if (!Validar())
            {
                return; //Los carteles los muestro en el método validar.
            }
            LogicEmpleado lc = new LogicEmpleado();
            try
            {
                MapearDeForm();
                if (empActual.Id > 0)
                {
                    lc.ActualizarEmpleado(empActual);
                    base.Informar("Empleado modificado correctamente", "Modificar Empleado.");
                }
                else
                {
                    lc.AgregarEmpleado(empActual);
                    base.Informar("Empleado guardado correctamente", "Agregar Empleado.");
                }
                PanelPersonal.Instancia.RefreshGrid(); //Actualizo el DataGrid
                empActual = null;
                this.Dispose();                
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Empleados - ERROR");
            }
        }

        public void MapearAFormulario(Empleado emp)
        {
            empActual = emp;
            
            if(emp.DNI != null)
            {
                txtDni.Text = emp.DNI.Trim();
            }
            if (emp.Legajo != null)
            {
                txtLegajo.Text = emp.Legajo.Trim();
            }
            if (emp.Nombre != null)
            {
                txtNombre.Text = emp.Nombre.Trim();
            }
            if(emp.Apellido != null)
            {
                txtApellido.Text = emp.Apellido.Trim();
            }
            if(emp.Tarjeta != null)
            {
                txtTarjeta.Text = emp.Tarjeta.Trim();
            }

            txtPin.Text = emp.Pin;
            
            cbPrivilegio.SelectedIndex = emp.Privilegio;
        }

        protected override void MapearDeForm()
        {
            empActual.DNI = txtDni.Text;
            empActual.Legajo = txtLegajo.Text;
            empActual.Nombre = txtNombre.Text;
            empActual.Tarjeta = txtTarjeta.Text;
            empActual.Privilegio = cbPrivilegio.SelectedIndex;
            empActual.Apellido = txtApellido.Text;
            empActual.Pin = txtPin.Text;
        }



        protected override bool Validar()
        {
            Validate v = new Validate();
            if(!v.NotEmpty(new string[] {txtNombre.Text, txtLegajo.Text }))
            {
                base.InformarError("Estos campos no pueden estar vacíos.", "Modificar Empleado.");
                return false;
            }
            /*if(!v.NumerosEnteros(new string[] { txtPin.Text, txtLegajo.Text, txtTarjeta.Text }))
            {
                base.InformarError("Estos campos deben contener sólo números.", "Modificar Empleado.");
                return false;
            }*/
            if (cbPrivilegio.SelectedIndex < 0)
            {
                base.InformarError("Debe seleccionar un nivel de privilegios.", "Modificar Empelado.");
                return false;
            }
            return true;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
