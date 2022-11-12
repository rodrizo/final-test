using ExamenDB.Controllers;
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
    public partial class frmPracticaProfesor : Form
    {

        PracticasData prData = new PracticasData();


        #region "Llenando grid de prácticas de profesores"
        private void getPracticas()
        {
            int id = Convert.ToInt32(cmbProfesor.SelectedValue);
            DataSet ds = prData.getPracticasProfesor(id);
            gridProfesor.DataSource = ds;
            gridProfesor.DataMember = "PracticaProfe";
        }
        #endregion

        #region "Obteniendo y llenando combobox de profesores"
        private void getProfesores()
        {
            ComboData cmb = new ComboData();
            cmbProfesor.DataSource = cmb.getProfesores();
            cmbProfesor.DisplayMember = "nombre";
            cmbProfesor.ValueMember = "idProfesor";
        }
        #endregion
        public frmPracticaProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getPracticas();
        }

        private void frmPracticaProfesor_Load(object sender, EventArgs e)
        {
            getProfesores();
        }
    }
}
