using ExamenDB.Controllers;
using ExamenDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDB.Forms
{
    public partial class frmPracticaAlumno : Form
    {
        AlumnoPractica alum = new AlumnoPractica();
        PracticasData prData = new PracticasData();

        #region "Llenando grid de prácticas de alumnos"
        private void getPracticas()
        {
            int id = Convert.ToInt32(cmbAlumnoC.SelectedValue);
            DataSet ds = prData.getPracticas(id);
            gridPracticas.DataSource = ds;
            gridPracticas.DataMember = "Practica";
        }
        #endregion

        #region "Obteniendo los datos ingresados en el form"
        private void getData()
        {
            alum.IdAlumno = Convert.ToInt32(cmbAlumnos.SelectedValue); 
            alum.IdPractica = Convert.ToInt32(cmbPracticas.SelectedValue); 
            alum.Fecha = fecha.Value;
            alum.Nota = Convert.ToInt32(txtNota.Text);
        }
        #endregion

        #region "Obteniendo y llenando combobox de alumnos"
        private void getAlumnos()
        {
            ComboData cmb = new ComboData();
            cmbAlumnos.DataSource = cmb.getEstudiantes();
            cmbAlumnos.DisplayMember = "nombre";
            cmbAlumnos.ValueMember = "idAlumno";
        }
        #endregion

        #region "Obteniendo y llenando combobox de prácticas"
        private void getPracticasc()
        {
            ComboData cmb = new ComboData();
            cmbPracticas.DataSource = cmb.getPracticas();
            cmbPracticas.DisplayMember = "titulo";
            cmbPracticas.ValueMember = "idPractica";
        }
        #endregion

        #region "Obteniendo y llenando combobox de alumnos para consulta"
        private void getAlumnosC()
        {
            ComboData cmb = new ComboData();
            cmbAlumnoC.DataSource = cmb.getEstudiantes();
            cmbAlumnoC.DisplayMember = "nombre";
            cmbAlumnoC.ValueMember = "idAlumno";
        }
        #endregion

        #region "Limpiando los campos"
        private void cleanFields()
        {
            cmbAlumnos.Text = string.Empty;
            cmbPracticas.Text = string.Empty;
            fecha.Text = string.Empty;
            txtNota.Text = string.Empty;
        }
        #endregion

        public frmPracticaAlumno()
        {
            InitializeComponent();
        }

        private void PracticaAlumno_Load(object sender, EventArgs e)
        {
            getAlumnos();
            getPracticasc();
            getAlumnosC();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getData();
            prData.PracticaCRUD(alum, "C");
            MessageBox.Show("Estudiante asignado con éxito");
            cleanFields();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            getPracticas();
        }

        private void gridPracticas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
