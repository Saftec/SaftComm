using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Relojes : GenericaPadre
    {
        private Reloj reloj = new Reloj(); //Esta instancia la utilizo para ejecutar todas las operaciones.
        private List<Reloj> relojes = new List<Reloj>();
        private LogicReloj cr;
        public Relojes()
        {
            InitializeComponent();            
        }

        private void Relojes_Load(object sender, EventArgs e)
        {
            SetPermisos();
            CargarDataGridView();
        }

        private Reloj BuscarEquipo(int id)
        {
            Reloj r = new Reloj(id);
            return (relojes[relojes.IndexOf(r)]);  //Puedo realizar la busqueda así porque dentro de Reloj tengo definido un Override a "Equals"
        }

        //Inserta un registro en la tabla borrado//
        private void Borrado(int idReloj, int cant)
        {
            cr = new LogicReloj();
            try
            {
                //cr.ActualizarBorrado(idReloj, cant);
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
                LogError(ex.Message);
            }
        }

        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            foreach (Reloj r in relojes)
            {
                if (r.Estado == true)
                {
                    r.Desconectar();
                    r.Estado = false;
                }
            }
            relojes.Clear();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            reloj = BuscarEquipo(GetId());
            if(!ValidarConexion()) { return; }
            if(!base.ConsultarUsuario("Está seguro que desea eliminar los administradores del equipo?", "Operaciones")) { return; }
            try
            {
                reloj.EliminarAdmins();
                base.InformarEvento("Todos los adminsitradores fueron borrados.", "Borrado de administradores");
                LogInforme("Todos los administradores fuero borrados del reloj: " + reloj.Numero);
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message);
                LogError(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {           
            if (GetEstado()=="Conectado")
            {
                base.InformarError("El dispositivo ya se encuentra conectado");
                LogError("El dispositivo ya se encuentra conectado");
                return;
            }
            reloj = BuscarEquipo(GetId());
            LogInforme("Conectando con reloj: " + reloj.Numero.ToString());
            Cursor = Cursors.WaitCursor;
            string llave = reloj.Clave;
            try
            {
                reloj.Conectar();
                reloj.Estado = true;
                SetEstado("Conectado");
                LogInforme("Conexión OK con reloj: " + reloj.Numero.ToString());
                SetMac(reloj.GetMac());
                SetModelo(reloj.GetModelo());
                SetCantRegis(reloj.GetCantidadRegistros().ToString());
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
                LogError(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            reloj = BuscarEquipo(GetId());
            if (!ValidarConexion()) { return; }
            try
            {
                reloj.SincronizarHora();
                base.InformarEvento("Hora sincronizada correctamente.", "Sincronizacion hora");
                LogInforme("Hora sincronizada con reloj: " + reloj.Numero.ToString());
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            reloj = BuscarEquipo(GetId());
            if (!ValidarConexion()) { return; }
            if(!base.ConsultarUsuario("Está seguro que desea eliminar los registros?","Eliminar datos")) { return; }
            Cursor = Cursors.WaitCursor;
            try
            {
                int cantidad;
                cantidad = reloj.GetCantidadRegistros();
                reloj.BorrarRegistros();
                Borrado(reloj.Id, cantidad);
                base.InformarEvento(cantidad.ToString() + " registros eliminados.", "Eliminar registros");
                LogInforme("Registros eliminados correctamente en reloj: " + reloj.Numero.ToString());
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }
                Cursor = Cursors.Default;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {            
            if (GetEstado() == "Desconectado")
            {
                base.InformarError("El dispositivo está desconectado");
                LogError("El dispositivo seleccionado no está conectado");
                return;
            }
            reloj = BuscarEquipo(GetId());
            reloj.Desconectar();
            reloj.Estado = false;
            SetEstado("Desconectado");
            LogInforme("Reloj: " + reloj.Numero.ToString() + " desconectado.");
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!ValidarConexion()) { return; }          
            reloj = BuscarEquipo(GetId());
            ControladorRegistros cr = new ControladorRegistros();
            DataTable regis = new DataTable();
            List<string> desconocidos = new List<string>();
            Cursor = Cursors.WaitCursor;
            try
            {
                regis = reloj.DescargarRegistros();
                desconocidos=cr.AgregarRegis(regis);
                if (desconocidos.Count > 0)
                {
                    base.InformarError("Los legajos: " + string.Join("--", desconocidos.ToArray()) + " son desconocidos");
                    LogError("Hubo legajos desconocidos durante la descarga:");
                    foreach(string l in desconocidos)
                    {
                        LogError("Legajo: " + l);
                    }
                }
                base.InformarEvento("Se descargaron: " + (regis.Rows.Count).ToString() + " registros", "Descarga de registros");
                LogInforme("Se descargaron: " + (regis.Rows.Count).ToString() + " registros");
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
                LogError(ex.Message);
            }
            Cursor = Cursors.Default;
        }
                //DESPUES DE EDITAR O AGREGAR UN RELOJ NECESITO SI O SI VOLVER A CARGAR EL LIST<> ACTUALIZADO EN MEMORIA//
        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbmReloj abm = new AbmReloj();
            Reloj r = new Reloj(GetPuerto(), GetNumero(), GetId(), GetClave(), GetDns(), GetIp(), GetNombre());
            abm.Editar(r);
            abm.ShowDialog(this);
            abm.Dispose();
            CargarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbmReloj abm = new AbmReloj();
            abm.ShowDialog(this);
            abm.Dispose();
            CargarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!base.ConsultarUsuario("Está seguro que desea eliminar el equipo?", "Eliminar equipo")) { return; }
            try
            {
                cr = new LogicReloj();
                Reloj r = new Reloj(GetPuerto(), GetNumero(), GetId(), GetClave(), GetDns(), GetIp(), GetNombre());
                cr.EliminarReloj(r);
                base.InformarEvento("Equipo eliminado correctamente.", "Eliminar reloj");
                LogInforme("Se ha eliminado un equipo");
                dgvRelojes.Rows.RemoveAt(dgvRelojes.CurrentRow.Index); //Elimino la fila actual
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
        }

        private void btnRutinaBajar_Click(object sender, EventArgs e)
        {
            if (!base.ConsultarUsuario("Está seguro que desea ejecutar la rutina de bajada de registros?", "Rutinas")) { return; }
            RutinaBajarRegistros();
        }
                                             
        private void btnRutinaHora_Click(object sender, EventArgs e)
        {
            if (!base.ConsultarUsuario("Está seguro que desea ejecutar la rutina de sincronización de hora?", "Rutinas")) { return; }
            RutinaSincronizarHora();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reloj = BuscarEquipo(GetId());
            if (!ValidarConexion()) { return; }
            if (!base.ConsultarUsuario("Está seguro que desea reiniciar el equipo?", "Operaciones")) { return; }
            try
            {
                reloj.Reiniciar();
                base.InformarEvento("Reinicio OK.", "Reiniciar dispositivos");
                LogInforme("Se ha reiniciado correctamente el reloj: " + reloj.Numero.ToString());
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }
            catch (Exception)
            {
                base.InformarError("Error totalmente desconocido al intentar reiniciar el dispositivo.");
                LogError("Error no controlado al intentar reiniciar el dispositivo");
            }
        }
        private void btnInicializar_Click(object sender, EventArgs e)
        {
            reloj = BuscarEquipo(GetId());
            if (!ValidarConexion()) { return; }
            if (!base.ConsultarUsuario("Está seguro que desea inicializar el equipo?", "Operaciones")) { return; }
            try
            {
                reloj.Inicializar();
                base.InformarEvento("Dispositivo inicializado correctamente.", "Incializar dispositivo");
                LogInforme("Se ha inicializado el equipo: " + reloj.Numero.ToString());
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message);
                LogError(appex.Message);
            }
            catch (Exception)
            {
                base.InformarError("Error totalmente desconocido al intentar inicializar el dispositivo");
                LogError("Error no controlado al intentar inicializar el equipo.");
            }
        }

        #endregion
        #region DataGriedView
        private void dgvRelojes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void CargarRelojes()
        {
            cr = new LogicReloj();
            relojes.Clear();
            try
            {
                relojes = cr.TodosRelojes();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void CargarDataGridView()
        {
            dgvRelojes.Rows.Clear();
            dgvRelojes.Refresh();
            try
            {
                CargarRelojes();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
            foreach (Reloj reloj in relojes)
            {
                dgvRelojes.Rows.Add(reloj.Numero, reloj.Nombre, reloj.Ip, reloj.Puerto, "Desconectado", "0", string.Empty, string.Empty, reloj.DNS, reloj.Id, reloj.Clave);
            }
            dgvRelojes.Refresh();
        }
        private string GetNombre()
        {
            return (dgvRelojes.CurrentRow.Cells[1].Value).ToString();
        }
        private string GetIp()
        {
            return (dgvRelojes.CurrentRow.Cells[2].Value).ToString();
        }

        private int GetPuerto()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[3].Value).ToString());
        }

        private int GetNumero()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[0].Value).ToString());
        }

        private void SetEstado(string valor)
        {
            dgvRelojes.CurrentRow.Cells[4].Value = valor;
        }

        private string GetEstado()
        {
            return (dgvRelojes.CurrentRow.Cells[4].Value).ToString();
        }

        private void SetCantRegis(string valor)
        {
            dgvRelojes.CurrentRow.Cells[5].Value = valor;
        }
        
        private void SetModelo(string valor)
        {
            dgvRelojes.CurrentRow.Cells[6].Value = valor;
        }

        private void SetMac(string valor)
        {
            dgvRelojes.CurrentRow.Cells[7].Value = valor;
        }

        private string GetDns()
        {
            return (dgvRelojes.CurrentRow.Cells[8].Value).ToString();
        }

        private int GetId()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[9].Value).ToString());
        }

        private string GetClave()
        {
            return (dgvRelojes.CurrentRow.Cells[10].Value).ToString();
        }
        #endregion
        #region Interfaz
        private bool ValidarConexion()
        {
            if ("Desconectado" == GetEstado())
            {
                base.InformarError("Por favor, conecte con dispositivo");
                LogError("Por favor, conecte con dispositivo");
                return false;
            }
            return true;
        }
        private void LogInforme(string mensaje)
        {
            rtbLog.SelectionColor = Color.Black;
            rtbLog.AppendText(DateTime.Now.ToString() + " " + mensaje + "\n");
            Logger.GetLogger().Info(mensaje);
        }
        private void LogError(string mensaje)
        {
            rtbLog.SelectionColor = Color.Red;
            rtbLog.AppendText(DateTime.Now.ToString() + " " + mensaje + "\n");
            Logger.GetLogger().Info("ERROR: " + mensaje);
        }
        private void SetPermisos()
        {
            ControladorLogin cl = new ControladorLogin();

            if (cl.GetNivelUsr() < 3)
            {                
                groupABM.Enabled = true;
            }
            if (cl.GetNivelUsr() == 1)
            {
                btnBorrar.Enabled = true;
                groupAvanzadas.Visible = true;
                groupAvanzadas.Enabled = true;
            }
        }
        #endregion
        #region Rutinas
        public void RutinaBajarRegistros()
        {
            Cursor = Cursors.WaitCursor; //Cursor de espera
            List<string> desconocidos = new List<string>();
            int total = 0;
            ControladorRegistros cr = new ControladorRegistros();
            LogInforme("--Inicio de rutina de descarga de registros");
            foreach (Reloj r in relojes)
            {
                try
                {
                    DataTable regis = new DataTable();
                    LogInforme("Conectando a reloj: " + r.Numero.ToString() + "...");
                    r.Conectar();
                    LogInforme("Conexion correcta con reloj: " + r.Numero.ToString());
                    r.Estado = true;
                    LogInforme("Descargando registros...");
                    regis = r.DescargarRegistros();
                    desconocidos=cr.AgregarRegis(regis);
                    LogInforme("Se descargaron " + regis.Rows.Count.ToString() + " registros");
                    LogInforme("Borrando registros...");
                    r.BorrarRegistros();                  
                    Borrado(r.Id, regis.Rows.Count);
                    LogInforme("Registros eliminados correctamente.");
                    r.Desconectar();
                    r.Estado = false;
                    LogInforme("Reloj: " + r.Numero.ToString() + " desconectado");
                    total += regis.Rows.Count;
                }
                catch (Exception ex)
                {
                    LogError("****Se produjo un error con reloj: " + r.Numero.ToString() + " durante la rutina de bajada de registros*****");
                    LogError(ex.Message);
                }
            }
            if (desconocidos.Count > 0)
            {
                LogError("ATENCION, se encontraron empleados desconocidos durante la descarga");
                foreach(string l in desconocidos)
                {
                    LogError("Legajo: " + l);
                }
            }
            LogInforme("--Rutina de descarga de registros finalizada.");
            Cursor = Cursors.Default; //Cursor normal
        }

        public void RutinaSincronizarHora()
        {
                LogInforme("--Inicio rutina de sincronización de hora");
                foreach (Reloj r in relojes)
                {
                try
                {
                    LogInforme("Conectando a reloj :" + r.Numero.ToString());
                    r.Conectar();
                    r.Estado = true;
                    LogInforme("Conexion correcta con reloj :" + r.Numero.ToString());
                    LogInforme("Sincronizando hora con reloj :" + r.Numero.ToString());
                    r.SincronizarHora();
                    LogInforme("Hora sincronizada con reloj :" + r.Numero.ToString());
                    r.Desconectar();
                    r.Estado = false;
                    LogInforme("Reloj: " + r.Numero.ToString() + " desconectado.");
                }
                catch(Exception ex)
                {
                    LogError("****Se produjo un error con reloj: " + r.Numero.ToString() + " durante la rutina de sincronización de hora*****");
                    LogError("ERROR: " + ex.Message);
                }

                }
                LogInforme("--Rutina de sincronización de hora finalizada");           
        }
        #endregion
    }
}
