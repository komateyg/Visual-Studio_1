using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui_design_idea_in_Windows_form_Application_Visua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = buttonSellers.Height;
            panelLeft.Top = buttonSellers.Top;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;

        }

        private void buttonSellers_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSellers.Height;
            panelLeft.Top = buttonSellers.Top;

        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            panelLeft.Top = buttonCalender.Top;
            panelLeft.Height = buttonCalender.Height;


        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTasks.Height;
            panelLeft.Top = buttonTasks.Top;

        }
    }
}
