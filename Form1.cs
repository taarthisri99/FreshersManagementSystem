using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshersManagementSystem_WindowsApplication
{
    public partial class Form1 : Form
    {
        ManageFreshers manageFreshers = new ManageFreshers();
        SaveFresher fresher = new SaveFresher();

        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageFreshers.traineeId++;
            fresher.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewTraineesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTrainees viewTrainees = new ViewTrainees();
            viewTrainees.ShowDialog();
        }
    }
}
