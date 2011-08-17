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
        string answer = "";
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
        private string VocabWord(string vocab) {
            string w = "";

            for (int i = 0; i < vocab.Length;i++ ) {
                if (vocab[i] != ' ')
                {
                    w += "_ ";
                }
                else {
                    w += "  ";
                
                }
            }
            return w;
        
        }
        private string Word (string mode,string lev) {
            //Timing.GetIntegerArrayByRandom(n, 1, 50);
            string Vocab="";
            if (lev =="Easy" ||lev =="Normal"||lev=="Hard"){
                int n = CountData(mode +".txt");
                int num = RandNumber(0,n-1);
                answer = DataWord(mode + ".txt",num);
                Vocab = VocabWord(answer);
            }
            return Vocab;
        
        }

        private void A_Click(object sender, EventArgs e)
        {
            label5.Text += "A  ";
            A.Enabled = false;
        }

        private void B_Click(object sender, EventArgs e)
        {
            label5.Text += "B  ";
            B.Enabled = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            label5.Text += "C  ";
            C.Enabled = false;
        }

        private void D_Click(object sender, EventArgs e)
        {
            label5.Text += "D  ";
            D.Enabled = false;
        }

        private void E_Click(object sender, EventArgs e)
        {
            label5.Text += "E  ";
            E.Enabled = false;
        }

        private void F_Click(object sender, EventArgs e)
        {
            label5.Text += "F  ";
            F.Enabled = false;
        }

        private void G_Click(object sender, EventArgs e)
        {
            label5.Text += "G  ";
            G.Enabled = false;
        }

        private void H_Click(object sender, EventArgs e)
        {
            label5.Text += "H  ";
            H.Enabled = false;
        }

        private void I_Click(object sender, EventArgs e)
        {
            label5.Text += "I  ";
            I.Enabled = false;
        }

        private void J_Click(object sender, EventArgs e)
        {
            label5.Text += "J  ";
            J.Enabled = false;
        }

        private void K_Click(object sender, EventArgs e)
        {
            label5.Text += "K  ";
            K.Enabled = false;
        }

        private void L_Click(object sender, EventArgs e)
        {
            label5.Text += "L  ";
            L.Enabled = false;
        }

        private void M_Click(object sender, EventArgs e)
        {
            label5.Text += "M  ";
            M.Enabled = false;
        }

        private void N_Click(object sender, EventArgs e)
        {
            label5.Text += "N  ";
            N.Enabled = false;
        }

        private void O_Click(object sender, EventArgs e)
        {
            label5.Text += "O  ";
            O.Enabled = false;
        }

        private void P_Click(object sender, EventArgs e)
        {
            label5.Text += "P  ";
            P.Enabled = false;
        }

        private void Q_Click(object sender, EventArgs e)
        {
            label5.Text += "Q  ";
            Q.Enabled = false;
        }

        private void R_Click(object sender, EventArgs e)
        {
            label5.Text += "R  ";
            R.Enabled = false;
        }

        private void S_Click(object sender, EventArgs e)
        {
            label5.Text += "S  ";
            S.Enabled = false;
        }

        private void T_Click(object sender, EventArgs e)
        {
            label5.Text += "T  ";
            T.Enabled = false;
        }

        private void U_Click(object sender, EventArgs e)
        {
            label5.Text += "U  ";
            U.Enabled = false;
        }

        private void V_Click(object sender, EventArgs e)
        {
            label5.Text += "V  ";
            V.Enabled = false;
        }

        private void W_Click(object sender, EventArgs e)
        {
            label5.Text += "W  ";
            W.Enabled = false;
        }

        private void X_Click(object sender, EventArgs e)
        {
            label5.Text += "X  ";
            X.Enabled = false;
        }

        private void Y_Click(object sender, EventArgs e)
        {
            label5.Text += "Y  ";
            Y.Enabled = false;
        }

        private void Z_Click(object sender, EventArgs e)
        {
            label5.Text += "Z  ";
            Z.Enabled = false;
        }


























        


      
       

        
    }
}
