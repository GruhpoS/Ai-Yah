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
        private string answer = "";
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
        private string BeginWord(string Vword)
        {
            //Timing.GetIntegerArrayByRandom(n, 1, 50);
            string Vocab = "";
            for (int i = 0; i < Vword.Length;i++ ) {
                if (Vword[i] != ' ')
                {
                    Vocab += "- ";
                }
                else {
                    Vocab += "  ";
                }
                
            }
            return Vocab;

        }
        
        private string Word (string mode,string lev) {
            //Timing.GetIntegerArrayByRandom(n, 1, 50);
            string Vocab="";
            if (lev =="Easy" ||lev =="Normal"||lev=="Hard"){
                int n = CountData(mode +".txt");
                int num = RandNumber(0,n-1);
                answer = DataWord(mode + ".txt",num);
                Vocab = BeginWord(answer);
                
            }
            return Vocab;
        
        }

        private void A_Click(object sender, EventArgs e)
        {
            label5.Text += "A   ";
        }

        private void B_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }
        private void D_Click(object sender, EventArgs e)
        {

        }
            

        
    }
}
