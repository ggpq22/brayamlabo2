using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SistemaEncomienda
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            //vectores con datos
            string[] empresa = { "oca", "dumascat", "chevalliers" };
            int[] puntos = { 10, 20, 30 };

            //cambiar combinacion de colores
            chartEstadisticas.Palette = ChartColorPalette.Pastel;

            
            for (int i = 0; i < empresa.Length; i++) 
            {
                //titulos
                Series s = chartEstadisticas.Series.Add(empresa[i]);

                //valor
                s.Label = puntos[i].ToString();

                s.Points.Add(puntos[i]);
            }

        }
    }
}
