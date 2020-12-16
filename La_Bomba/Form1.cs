using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Bomba
{
    public partial class Form1 : Form
    {
        Boolean visible= false;
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            Btn_Centro.Click += Btn_Centro_Click;
            Btn_Derecho.Click += Btn_Derecho_Click;
            Btn_Izquierdo.Click += Btn_Izquierdo_Click;
          
        }

        private void Btn_Izquierdo_Click(object sender, EventArgs e)
        {
            changeStatus();
            InitializeButtons();
            Btn_Centro.Text = "PUM!!";
        }

        private void Btn_Derecho_Click(object sender, EventArgs e)
        {
            changeStatus();
            InitializeButtons();
            Btn_Centro.Text = "PUM!!";
        }

        private void Btn_Centro_Click(object sender, EventArgs e)
        {
            changeStatus();
            InitializeButtons();
            Btn_Izquierdo.Text = "PUM!!";
            Btn_Derecho.Text = "PUM!!";

        }

        private void InitializeButtons()
        {
            Btn_Centro.Visible=!visible;
            Btn_Derecho.Visible = visible;
            Btn_Izquierdo.Visible = visible;
        }

        private void changeStatus()
        {
            visible = !visible;
        }
    }
}
