using System;
using System.Windows.Forms;

using FreshersManagement.Data;
using Trainee;

namespace FreshersManagementSystem.Windows
{
    public partial class ViewTrainees : Form
    {
        ManageFreshers manageFreshers = new ManageFreshers();
        DataAccess dataAccess = new DataAccess();
        public ViewTrainees()
        {
            InitializeComponent();
            DisplayGrid();
        }

        private void DisplayGrid()
        {
            var freshers = dataAccess.FetchTrainees();

            dataGridView1.DataSource = freshers;
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            dataGridView1.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.UseColumnTextForButtonValue = true;
            updateColumn.Text = "Update";
            updateColumn.Name = "Update";
            dataGridView1.Columns.Add(updateColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (string.Equals(dataGridView1.Columns[e.ColumnIndex].Name, "Delete"))
                {
                    int selectedRow = dataGridView1.CurrentCell.RowIndex;
                    string idOfTrainee = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    manageFreshers.DeleteTrainee(idOfTrainee);
                }

                if (string.Equals(dataGridView1.Columns[e.ColumnIndex].Name, "Update"))
                {
                    int selectedRow = dataGridView1.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[2].Value.ToString());
                    string name = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                    long mobileNumber = Convert.ToInt64(dataGridView1.Rows[selectedRow].Cells[4].Value.ToString());
                    DateTime dateOfBirth = DateTime.Parse(dataGridView1.Rows[selectedRow].Cells[5].Value.ToString());
                    string qualification = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
                    string address = dataGridView1.Rows[selectedRow].Cells[7].Value.ToString();

                    var saveFresher = new SaveFresher();
                    var fresher = new Fresher(id, name, mobileNumber, dateOfBirth, qualification, address);
                    saveFresher.ShowDataToUpdate(fresher);
                }
                DisplayGrid();
            }
            catch (Exception exception) when (exception is FormatException ||
                           exception is ArgumentOutOfRangeException)
            { }
                  
        }
    }
}
