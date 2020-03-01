using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WinForms_RDLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbControlNotasDataSet.Ciclo' table. You can move, or remove it, as needed.
            this.CicloTableAdapter.Fill(this.dbControlNotasDataSet.Ciclo);

            dbControlNotasDataSetBindingSource.DataSource = new Personas().GetPersonas();

            this.reportViewer1.RefreshReport();
        }
    }
}
