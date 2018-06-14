using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Livro_C_Sharp___Capitulo_8__exercicios_parte_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double total, livre, utilizado;
            DriveInfo[] drives = DriveInfo.GetDrives();
            total = drives[0].TotalSize; //Espaço total
            livre = drives[0].AvailableFreeSpace;  // Espaço disponivel
            utilizado = total - livre;  //Espaço utilizado

            //Desenho gráfico
            chart1.Titles.Add("Espaço em Disco");
            chart1.Titles[0].Font = new Font("Arial", 20);
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.Add(livre);
            chart1.Series[0].Points[0].Color = Color.Magenta;
            chart1.Series[0].Points[0].LegendText = "Espaço Livre";
            chart1.Series[0].Points.Add(utilizado);
            chart1.Series[0].Points[1].Color = Color.Blue;
            chart1.Series[0].Points[1].LegendText = "Espaço Utilizado";

        }
    }
}
