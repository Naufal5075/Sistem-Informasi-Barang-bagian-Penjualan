using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationery
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void txtBoxItem_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtBoxItem.Text = selectedRow.Cells["Items"].Value.ToString();
                comboBoxGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtBoxPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell Items = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell Gender = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell Phone = new DataGridViewTextBoxCell();

            Items.Value = txtBoxItem.Text;

            Gender.Value = comboBoxGender.Text;
            Phone.Value = txtBoxPhone.Text;

            row.Cells.Add(Items);
            row.Cells.Add(Gender);
            row.Cells.Add(Phone);

            dataGridView1.Rows.Add(row);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Items"].Value = txtBoxItem.Text;
                selectedRow.Cells["Gender"].Value = comboBoxGender.Text;
                selectedRow.Cells["Phone"].Value = txtBoxPhone.Text;
            }
            else
            {
                MessageBox.Show("Pilih baris untuk diedit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
   
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Pilih baris untuk dihapus.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
