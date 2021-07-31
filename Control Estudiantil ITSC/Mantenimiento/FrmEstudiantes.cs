using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Control_Estudiantil_ITSC.Datos;
using Control_Estudiantil_ITSC.Clases;
using System.Runtime.InteropServices;//libreria para arrastrar form

namespace Control_Estudiantil_ITSC.Mantenimiento
{
    public partial class FrmEstudiantes : Form
    {
        /// <summary>
        /// Estas DEll import son para que funcione arrastrar el form mediante el evento mousedown, con la libreria System.Runtime.InteropServices.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private static DataTable dt = new DataTable();
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBControlEstudiantesDataSet.tblEstudiantes' Puede moverla o quitarla según sea necesario.
            //this.tblEstudiantesTableAdapter.Fill(this.dBControlEstudiantesDataSet.tblEstudiantes);
            try
            {

                DataSet ds = FEstudiantes.GetAll();
                dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos2.DataSource = dt;


                if (dt.Rows.Count > 0)
                {
                    lblNoSeEncontraronDatos.Visible = false;

                    contenedor1.Visible = false;

                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    lblEditar.Visible = false;
                    lblBorrar.Visible = false;

                    chkSencillo.Checked = Enabled;



                    this.dgvDatos2.Columns["Id"].Visible = false;
                    this.dgvDatos2.Columns["Nombre"].Visible = false;
                    this.dgvDatos2.Columns["Apellido"].Visible = false;
                    this.dgvDatos2.Columns["Matricula"].Visible = true;
                    this.dgvDatos2.Columns["Carrera"].Visible = false;
                    this.dgvDatos2.Columns["Materia"].Visible = false;
                    this.dgvDatos2.Columns["Profesor"].Visible = false;


                    dgvDatos_CellClick(null, null);

                }
                else
                {
                    lblNoSeEncontraronDatos.Visible = true;
                }

                MostrarAgregarCancelar(false);

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void MostrarAgregarCancelar(bool b)
        {
            btnAgregar.Visible = b;
            btnCancelar.Visible = b;
            btnNuevo.Visible = !b;



            txtNombre.Enabled = b;
            txtApellido.Enabled = b;
            txtMatricula.Enabled = b;
            cbbProfesor.Enabled = b;
            cbbCarrera.Enabled = b;
            cbbMateria.Enabled = b;
            cbbProfesor.Enabled = b;

        }



        public string ValidarDatos()
        {
            string Resultado = "";
            if (txtNombre.Text == "")
            {
                Resultado = Resultado + "\n Nombres";//la \n es un enter
            }
            if (txtApellido.Text == "")
            {
                Resultado = Resultado + "\n Apellidos";
            }

            return Resultado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = ValidarDatos();


                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        Estudiantes estudiante = new Estudiantes();
                        estudiante.Nombre = txtNombre.Text;
                        estudiante.Apellido = txtApellido.Text;
                        estudiante.Matricula = txtMatricula.Text;
                        estudiante.Carrera = cbbCarrera.Text;
                        estudiante.Materia = cbbMateria.Text;
                        estudiante.Profesor = cbbProfesor.Text;

                        if (FEstudiantes.Insertar(estudiante) > 0)
                        {
                            MessageBox.Show("Datos Insertados Correctamente");
                            FrmEstudiantes_Load(null, null);
                        }

                    }
                    else
                    {
                        Estudiantes estudiante = new Estudiantes();
                        estudiante.Id = Convert.ToInt32(txtId.Text);
                        estudiante.Nombre = txtNombre.Text;
                        estudiante.Apellido = txtApellido.Text;
                        estudiante.Matricula = txtMatricula.Text;
                        estudiante.Carrera = cbbCarrera.Text;
                        estudiante.Materia = cbbMateria.Text;
                        estudiante.Profesor = cbbProfesor.Text;

                        if (FEstudiantes.Actualizar(estudiante) == 1)
                        {
                            MessageBox.Show("Datos Modificados Correctamente");
                            FrmEstudiantes_Load(null, null);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Faltan cargar Datos: " + sResultado);
                }






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarAgregarCancelar(true);

            contenedor1.Visible = true;

            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMatricula.Text = "";
            cbbCarrera.Text = "";
            cbbMateria.Text = "";
            cbbProfesor.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            MostrarAgregarCancelar(true);
            dgvDatos.Enabled = true;

            contenedor1.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarAgregarCancelar(false);
            contenedor1.Visible = false;
            dgvDatos_CellClick(null, null);
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtMatricula.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                cbbCarrera.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                cbbMateria.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
                cbbProfesor.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente desea eliminar los Estudiantes seleccionados?",
                    "Eliminacion de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Estudiantes estudiante = new Estudiantes();
                            estudiante.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (FEstudiantes.Eliminar(estudiante) != 1)
                            {
                                MessageBox.Show("El Estudiante no pudo ser eliminado",
                                    "Eliminacion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }

                    FrmEstudiantes_Load(null, null);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = cbbBuscar.Text + " Like '" + txtBuscar.Text + "%'";

                dgvDatos.DataSource = dv;
                dgvDatos2.DataSource = dv;

                if (dv.Count == 0)
                {
                    lblNoSeEncontraronDatos.Visible = true;
                }
                else
                {
                    lblNoSeEncontraronDatos.Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtMatricula.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                cbbCarrera.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                cbbMateria.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
                cbbProfesor.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void dgvDatos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }



        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {


            if (chkNombre.Checked == true)
            {
                this.dgvDatos2.Columns["Nombre"].Visible = true;
            }
            else if (chkNombre.Checked == false)
            {
                this.dgvDatos2.Columns["Nombre"].Visible = false;
            }

        }

        private void chkMateria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMateria.Checked == true)
            {
                this.dgvDatos2.Columns["Materia"].Visible = true;
            }
            else if (chkMateria.Checked == false)
            {
                this.dgvDatos2.Columns["Materia"].Visible = false;
            }
        }

        private void chkCarrera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarrera.Checked == true)
            {
                this.dgvDatos2.Columns["Carrera"].Visible = true;
            }
            else if (chkCarrera.Checked == false)
            {
                this.dgvDatos2.Columns["Carrera"].Visible = false;
            }
        }

        private void chkProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProfesor.Checked == true)
            {
                this.dgvDatos2.Columns["Profesor"].Visible = true;
            }
            else if (chkProfesor.Checked == false)
            {
                this.dgvDatos2.Columns["Profesor"].Visible = false;
            }
        }

        private void chkSencillo_CheckedChanged(object sender, EventArgs e)
        {


            if (chkSencillo.Checked == true)
            {
                dgvDatos2.Visible = true;
                dgvDatos.Visible = false;
                contenedor1.Visible = false;


                dgvDatos.Enabled = true;


                btnNuevo.Visible = true;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                lblEditar.Visible = false;
                lblBorrar.Visible = false;


            }

            else if (chkSencillo.Checked == false)
            {
                dgvDatos.Visible = true;
                dgvDatos2.Visible = false;

                dgvDatos.Enabled = true;

                MostrarAgregarCancelar(true);
                btnNuevo.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                lblEditar.Visible = true;
                lblBorrar.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


            try
            {
                if (MessageBox.Show("Desea Salir de la aplicacion?",
                    "Salir de la aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Close();

                    FrmEstudiantes_Load(null, null);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {




                Estudiantes estudiante = new Estudiantes();
                txtId.Text = "";
                estudiante.Nombre = "";
                estudiante.Apellido = "";
                estudiante.Matricula = txtMatricula.Text;
                estudiante.Carrera = "";
                estudiante.Materia = cbbMateria.Text;
                estudiante.Profesor = cbbProfesor.Text;

                if (FEstudiantes.Insertar(estudiante) > 0)
                {
                    MessageBox.Show("Datos Insertados Correctamente");
                    FrmEstudiantes_Load(null, null);
                }








            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void contenedor1_Enter(object sender, EventArgs e)
        {

        }




        /// METODOS PARA ARRASTRAR LA VENTANA/WINDOWS FORM
        #region


        private void FrmEstudiantes_MouseDown(object sender, MouseEventArgs e)
        {
            //capturar el mouse para enviar la posicion y arrastrar el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barra1_MouseDown(object sender, MouseEventArgs e)
        {
            //capturar el mouse para enviar la posicion y arrastrar el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //capturar el mouse para enviar la posicion y arrastrar el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barra2_MouseDown(object sender, MouseEventArgs e)
        {
            //capturar el mouse para enviar la posicion y arrastrar el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


    }
}
