using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;

namespace PryNievasSp4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ClassConexion claseConexion = new ClassConexion();
            claseConexion.ConectarBD(toolStripStatusLabelConex);


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnKmCamion_Click(object sender, EventArgs e)
        {
            chartInfo.Series.Clear();
            ClassConexion claseConexion = new ClassConexion();
            claseConexion.CargarDatosChart(chartInfo);
        }
    }
}
