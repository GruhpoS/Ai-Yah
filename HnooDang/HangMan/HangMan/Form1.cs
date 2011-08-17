using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            picBox1.Image = HangMan.Properties.Resources._1;
            VocabMode.Items.Clear();
            
            VocabMode.Items.Add("Coutries");
            VocabMode.Items.Add("Animals");
            VocabMode.Items.Add("Sports");
            Level.Items.Clear();
           
            Level.Items.Add("Easy");
            Level.Items.Add("Normal");
            Level.Items.Add("Hard");
            label4.Text = "";
            label5.Text = "";

        }
        private void A_Click(object sender, EventArgs e)
        {
            string A = "A";
        }

        private void B_Click(object sender, EventArgs e)
        {
            string B = "B";
        }

        private void C_Click(object sender, EventArgs e)
        {
            string C = "C";
        }

        private void D_Click(object sender, EventArgs e)
        {
            string D = "D";
        }

        private void E_Click(object sender, EventArgs e)
        {
            string E = "E";
        }

        private void F_Click(object sender, EventArgs e)
        {
            string F = "F";
        }

        private void G_Click(object sender, EventArgs e)
        {
            string G = "G";
        }

        private void H_Click(object sender, EventArgs e)
        {
            string H = "H";
        }

        private void I_Click(object sender, EventArgs e)
        {
            string I = "I";
        }

        private void J_Click(object sender, EventArgs e)
        {
            string J = "J";
        }

        private void K_Click(object sender, EventArgs e)
        {
            string K = "K";
        }

        private void L_Click(object sender, EventArgs e)
        {
            string L = "L";
        }

        private void M_Click(object sender, EventArgs e)
        {
            string M = "M";
        }

        private void N_Click(object sender, EventArgs e)
        {
            string N = "N";
        }

        private void O_Click(object sender, EventArgs e)
        {
            string O = "O";
        }

        private void P_Click(object sender, EventArgs e)
        {
            string P = "P";
        }

        private void Q_Click(object sender, EventArgs e)
        {
            string Q = "Q";
        }

        private void R_Click(object sender, EventArgs e)
        {
            string R = "R";
        }

        private void S_Click(object sender, EventArgs e)
        {
            string S = "S";
        }

        private void T_Click(object sender, EventArgs e)
        {
            string T = "T";
        }

        private void U_Click(object sender, EventArgs e)
        {
            string U = "U";
        }

        private void V_Click(object sender, EventArgs e)
        {
            string V = "V";
        }

        private void W_Click(object sender, EventArgs e)
        {
            string W = "W";
        }

        private void X_Click(object sender, EventArgs e)
        {
            string X = "X";
        }

        private void Y_Click(object sender, EventArgs e)
        {
            string Y = "Y";
        }

        private void Z_Click(object sender, EventArgs e)
        {
            string Z = "Z";
        }
        
       

       

       

      
       

        
    }
}
