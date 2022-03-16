using System;
using System.Windows.Forms;

namespace FreshersManagementSystem.Windows
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
            fresher.ShowDialog();
        }

        private void viewTraineesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewTrainees = new ViewTrainees();
            viewTrainees.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
