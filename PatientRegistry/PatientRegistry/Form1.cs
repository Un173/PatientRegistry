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
        DatabaseHandler databaseHandler;
        public Form1()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler(@"S:\Projects\PatientRegistry\PatientRegistry\",'|', dataGridView1);
            databaseHandler.ReadAllFromFile();
            databaseHandler.FillDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            DBRecord record = databaseHandler.FindRecordById(id);
            if (record == null) return;
            AddRecord addRecord = new AddRecord(false, @"S:\Projects\PatientRegistry\PatientRegistry\", record);
            var result = addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                databaseHandler.ModifyRegistry(id,addRecord.firstName, addRecord.lastName, addRecord.patronymic, addRecord.gender, addRecord.isMother, addRecord.dateOfBirth, addRecord.dateOfEntry, addRecord.dateOfRetirement, addRecord.placeOfLiving, addRecord.bedProfile, addRecord.department, addRecord.status);
                databaseHandler.FillDataGridView();
            }
        }

        private void поступлениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord(true, @"S:\Projects\PatientRegistry\PatientRegistry\");
            var result = addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                databaseHandler.WriteToFile(addRecord.firstName, addRecord.lastName, addRecord.patronymic, addRecord.gender, addRecord.isMother, addRecord.dateOfBirth, addRecord.dateOfEntry, addRecord.dateOfRetirement, addRecord.placeOfLiving, addRecord.bedProfile, addRecord.department, addRecord.status);
                databaseHandler.FillDataGridView();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            String str = searchTextBox.Text;
            databaseHandler.FillDataGridView(str);

        }

    }
}
