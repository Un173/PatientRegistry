﻿using System;
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

        private void поступлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord(@"S:\Projects\PatientRegistry\PatientRegistry\");
           var result= addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                databaseHandler.WriteToFile(addRecord.firstName,addRecord.lastName, addRecord.patronymic,addRecord.gender, addRecord.isMother,addRecord.dateOfEntry,addRecord.dateOfBirth,addRecord.placeOfLiving1,addRecord.placeOfLiving2,addRecord.bedProfile,addRecord.department);

            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

        }
    }
}
