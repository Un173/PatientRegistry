using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseHandler databaseHandler = new DatabaseHandler(@"S:\Projects\PatientRegistry\PatientRegistry\",'|', dataGridView1);
            databaseHandler.ReadAllFromFile();
            databaseHandler.FillDataGridView();
        }

        private void поступлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord(@"S:\Projects\PatientRegistry\PatientRegistry\");
            addRecord.Show();
        }
    }
}
