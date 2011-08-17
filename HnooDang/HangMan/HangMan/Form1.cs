using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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



            label4.Text = "";
            label5.Text = "";
            this.addVocab();
            this.addLevel();
        }

        public void addLevel()
        {
            Level.Items.Clear();

            Level.Text ="Easy";
            Level.Items.Add("Easy");
            Level.Items.Add("Normal");
            Level.Items.Add("Hard");
        }
        public void addVocab()
        {
            VocabMode.Text ="Countries";
            VocabMode.Items.Add("Countries");
            VocabMode.Items.Add("Animals");
            VocabMode.Items.Add("Sports");
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

        private void A_Click_1(object sender, EventArgs e)
        {

        }

        private void A_Click_2(object sender, EventArgs e)
        {

        }

        private void X_Click_1(object sender, EventArgs e)
        {

        }

        private void Y_Click_1(object sender, EventArgs e)
        {

        }

        private void Z_Click_1(object sender, EventArgs e)
        {

        }

        private void V_Click_1(object sender, EventArgs e)
        {

        }

        private void T_Click_1(object sender, EventArgs e)
        {

        }

        private void U_Click_1(object sender, EventArgs e)
        {

        }

        private void P_Click_1(object sender, EventArgs e)
        {

        }

        private void Q_Click_1(object sender, EventArgs e)
        {

        }

        private void R_Click_1(object sender, EventArgs e)
        {

        }

        private void S_Click_1(object sender, EventArgs e)
        {

        }

        private void O_Click_1(object sender, EventArgs e)
        {

        }

        private void M_Click_1(object sender, EventArgs e)
        {

        }

        private void N_Click_1(object sender, EventArgs e)
        {

        }

        private void I_Click_1(object sender, EventArgs e)
        {

        }

        private void J_Click_1(object sender, EventArgs e)
        {

        }

        private void K_Click_1(object sender, EventArgs e)
        {

        }

        private void L_Click_1(object sender, EventArgs e)
        {

        }

        private void H_Click_1(object sender, EventArgs e)
        {

        }

        private void F_Click_1(object sender, EventArgs e)
        {

        }

        private void G_Click_1(object sender, EventArgs e)
        {

        }

        private void B_Click_1(object sender, EventArgs e)
        {

        }

        private void C_Click_1(object sender, EventArgs e)
        {

        }

        private void D_Click_1(object sender, EventArgs e)
        {

        }

        private void E_Click_1(object sender, EventArgs e)
        {

        }

        private void W_Click_1(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            label4.Text = Word(VocabMode.Text,Level.Text);
            
            
        }

        private int RandNumber(int minValue,int maxValue) {
            Random rand = new Random();
            int number =0 ;
            number = rand.Next(minValue, maxValue);
            return number;
            
        
        }

        private int CountData(string mode) {
            
            StreamReader read = new StreamReader(@"C:\Documents and Settings\admin\Ai-Yah\"+mode);
            string data;
            int count = 0;
            while ((data=read.ReadLine())!=null){
                count++;
            }
            return count;
        
        }

        private string DataWord(string mode,int count)
        {
            
            StreamReader read = new StreamReader(@"C:\Documents and Settings\admin\Ai-Yah\" + mode);
            string data;
            string volcab="";
            int num = 0;
            while ((data = read.ReadLine()) != null)
            {
                if (num==count){
                    volcab = data;
                    break;
                }
                num++;
            }
            return volcab;

        }
        
        private string Word (string mode,string lev) {
            //Timing.GetIntegerArrayByRandom(n, 1, 50);
            string Volcab="";
            if (lev =="Easy" ||lev =="Normal"||lev=="Hard"){
                int n = CountData(mode +".txt");
                int num = RandNumber(0,n-1);
                Volcab = DataWord(mode + ".txt",num);
            }
            return Volcab;
        
        }
        
       

       

       

      
       

        
    }
}
