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
        private char [] selCh = new char [100];
        private int ClSum = 0;
        private int Clsumed = 0;
        private string ChMode = "";
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off();
            picBox1.Image = HangMan.Properties.Resources._1;
            VocabMode.Items.Clear();
            label4.Text = "";
            label5.Text = "";
            label8.Text = "";
            Hint.Enabled = false;
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
            label8.Text = "";
            label4.Text = Word(VocabMode.Text,Level.Text);
            label5.Text = "";
            Hint.Enabled = true;
            ////////////
            on();
            ClSum = 0;
            

            
            
        }
        private void on() {
            A.BackColor = System.Drawing.Color.LightPink;
            A.Enabled = true;
            
            B.BackColor = System.Drawing.Color.LightPink;
            B.Enabled = true;

            C.BackColor = System.Drawing.Color.LightPink;
            C.Enabled = true;

            D.BackColor = System.Drawing.Color.LightPink;
            D.Enabled = true;

            E.BackColor = System.Drawing.Color.LightPink;
            E.Enabled = true;

            F.BackColor = System.Drawing.Color.LightPink;
            F.Enabled = true;

            G.BackColor = System.Drawing.Color.LightPink;
            G.Enabled = true;
            
            H.BackColor = System.Drawing.Color.LightPink;
            H.Enabled = true;

            I.BackColor = System.Drawing.Color.LightPink;
            I.Enabled = true;
            
            J.BackColor = System.Drawing.Color.LightPink;
            J.Enabled = true;

            K.BackColor = System.Drawing.Color.LightPink;
            K.Enabled = true;

            L.BackColor = System.Drawing.Color.LightPink;
            L.Enabled = true;

            M.BackColor = System.Drawing.Color.LightPink;
            M.Enabled = true;

            N.BackColor = System.Drawing.Color.LightPink;
            N.Enabled = true;

            O.BackColor = System.Drawing.Color.LightPink;
            O.Enabled = true;

            P.BackColor = System.Drawing.Color.LightPink;
            P.Enabled = true;

            Q.BackColor = System.Drawing.Color.LightPink;
            Q.Enabled = true;

            R.BackColor = System.Drawing.Color.LightPink;
            R.Enabled = true;

            S.BackColor = System.Drawing.Color.LightPink;
            S.Enabled = true;

            T.BackColor = System.Drawing.Color.LightPink;
            T.Enabled = true;

            U.BackColor = System.Drawing.Color.LightPink;
            U.Enabled = true;

            V.BackColor = System.Drawing.Color.LightPink;
            V.Enabled = true;

            W.BackColor = System.Drawing.Color.LightPink;
            W.Enabled = true;

            X.BackColor = System.Drawing.Color.LightPink;
            X.Enabled = true;

            Y.BackColor = System.Drawing.Color.LightPink;
            Y.Enabled = true;

            Z.BackColor = System.Drawing.Color.LightPink;
            Z.Enabled = true;
            
            
        
        
        
        }
        private void off() {
            A.BackColor = System.Drawing.Color.Gray;
            A.Enabled = false;

            B.BackColor = System.Drawing.Color.Gray;
            B.Enabled = false;
            
            C.BackColor = System.Drawing.Color.Gray;
            C.Enabled = false;

            D.BackColor = System.Drawing.Color.Gray;
            D.Enabled = false;

            E.BackColor = System.Drawing.Color.Gray;
            E.Enabled = false;

            F.BackColor = System.Drawing.Color.Gray;
            F.Enabled = false;

            G.BackColor = System.Drawing.Color.Gray;
            G.Enabled = false;

            H.BackColor = System.Drawing.Color.Gray;
            H.Enabled = false;

            I.BackColor = System.Drawing.Color.Gray;
            I.Enabled = false;

            J.BackColor = System.Drawing.Color.Gray;
            J.Enabled = false;

            K.BackColor = System.Drawing.Color.Gray;
            K.Enabled = false;

            L.BackColor = System.Drawing.Color.Gray;
            L.Enabled = false;

            M.BackColor = System.Drawing.Color.Gray;
            M.Enabled = false;

            N.BackColor = System.Drawing.Color.Gray;
            N.Enabled = false;

            O.BackColor = System.Drawing.Color.Gray;
            O.Enabled = false;

            P.BackColor = System.Drawing.Color.Gray;
            P.Enabled = false;

            Q.BackColor = System.Drawing.Color.Gray;
            Q.Enabled = false;

            R.BackColor = System.Drawing.Color.Gray;
            R.Enabled = false;

            S.BackColor = System.Drawing.Color.Gray;
            S.Enabled = false;

            T.BackColor = System.Drawing.Color.Gray;
            T.Enabled = false;

            U.BackColor = System.Drawing.Color.Gray;
            U.Enabled = false;

            V.BackColor = System.Drawing.Color.Gray;
            V.Enabled = false;

            W.BackColor = System.Drawing.Color.Gray;
            W.Enabled = false;

            X.BackColor = System.Drawing.Color.Gray;
            X.Enabled = false;

            Y.BackColor = System.Drawing.Color.Gray;
            Y.Enabled = false;

            Z.BackColor = System.Drawing.Color.Gray;
            Z.Enabled = false;
            
            

            
        
        }
        private int RandNumber(int minValue,int maxValue) {
            Random rand = new Random();
            int number =0 ;
            number = rand.Next(minValue, maxValue);
            return number;
            
        
        }
        private string getAnswer() {

            return answer;
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
                    selCh[i] = '_';
                    w += "_ ";
                }
                else {
                    selCh[i] = ' ';
                    w += "  ";
                
                }
            }
            return w;
        
        }
        private string Word (string mode,string lev) {
            //Timing.GetIntegerArrayByRandom(n, 1, 50);
            string Vocab="";
            ChMode = lev;
            if (lev =="Easy" ||lev =="Normal"||lev=="Hard"){
                int n = CountData(mode + ".txt");
                int num = RandNumber(0, n - 1);
                answer = DataWord(mode + ".txt", num);
                Hint.Enabled = true;
                if (lev == "Easy")
                {               
                    while (answer.Length>=7){
                        n = CountData(mode + ".txt");
                        num = RandNumber(0, n - 1);
                        answer = DataWord(mode + ".txt", num);
                    }
                }
                else if (lev == "Hard")
                {
                    while (answer.Length < 7)
                    {
                        n = CountData(mode + ".txt");
                        num = RandNumber(0, n - 1);
                        answer = DataWord(mode + ".txt", num);
                        
                    }
                    Hint.Enabled = false;
                }
               
                Vocab = VocabWord(answer);
                label7.Text = getAnswer();
                
            }
            return Vocab;
        
        }

        private char[] getSelCh() {

            return selCh;
        }
        private int getClSum() {

            return ClSum;
        }
        private int getClSumed()
        {

            return Clsumed;
        }

        private void Click(char ch) {
            
            int k = 0;
            for (int i = 0; i < getAnswer().Length;i++ )
            {
                if (ch == getAnswer()[i] || ((ch+32) == getAnswer()[i]))
                {
                    selCh[i] = ch;
                    k++;
                }

            }
           
            if (k == 0)
            {
                ClSum++;
                Pic();
            }
            if (check()){
                label8.Text = ".......You Win....";
                off();
            }
            
           label4.Text=ShowAnswer();

        }
        private string getMode()
        {
            return ChMode;
        }
        private void Pic() {

            label7.Text = getMode()+"   " + getClSum();
            if (getClSum()==10&&(getMode()=="Easy")){
                label8.Text = ".......You Lose....";
                off();          
            }
            else if (getClSum() == 7 && (getMode() == "Normal"))
            {
                label8.Text = ".......You Lose....";
                off(); 
            }
            else if (getClSum() == 5 && (getMode() == "Hard"))
            {
                label8.Text = ".......You Lose....";
                off();
            }

        }
        private bool check() {
            int k=0;
            for (int i = 0; i < getAnswer().Length; i++)
            {
                if (getSelCh()[i] == getAnswer()[i] || ((getSelCh()[i] + 32) == getAnswer()[i]))
                {
                    k++;
                }

            }
            if (k== getAnswer().Length){
                return true;
            }
            return false;
        }
        private string ShowAnswer() {
            string w = "";
            for (int i = 0; i < getAnswer().Length;i++ ) {
                w += getSelCh()[i] + " ";
            
            }
            return w;
        }



        private void A_Click(object sender, EventArgs e)
        {
            label5.Text += "A  ";
            Click('A');
            A.BackColor = System.Drawing.Color.Gray;
            A.Enabled = false;
            
        }

        private void B_Click(object sender, EventArgs e)
        {
            label5.Text += "B  ";
            Click('B');
            B.BackColor = System.Drawing.Color.Gray;
            B.Enabled = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            label5.Text += "C  ";
            Click('C');
            C.BackColor = System.Drawing.Color.Gray;
            C.Enabled = false;
        }

        private void D_Click(object sender, EventArgs e)
        {
            label5.Text += "D  ";
            Click('D');
            D.BackColor = System.Drawing.Color.Gray;
            D.Enabled = false;
        }

        private void E_Click(object sender, EventArgs e)
        {
            label5.Text += "E  ";
            Click('E');
            E.BackColor = System.Drawing.Color.Gray;
            E.Enabled = false;
        }

        private void F_Click(object sender, EventArgs e)
        {
            label5.Text += "F  ";
            Click('F');
            F.BackColor = System.Drawing.Color.Gray;
            F.Enabled = false;
        }

        private void G_Click(object sender, EventArgs e)
        {
            label5.Text += "G  ";
            Click('G');
            G.BackColor = System.Drawing.Color.Gray;
            G.Enabled = false;
        }

        private void H_Click(object sender, EventArgs e)
        {
            label5.Text += "H  ";
            Click('H');
            H.BackColor = System.Drawing.Color.Gray;
            H.Enabled = false;
        }

        private void I_Click(object sender, EventArgs e)
        {
            label5.Text += "I  ";
            Click('I');
            I.BackColor = System.Drawing.Color.Gray;
            I.Enabled = false;
        }

        private void J_Click(object sender, EventArgs e)
        {
            label5.Text += "J  ";
            Click('J');
            J.BackColor = System.Drawing.Color.Gray;
            J.Enabled = false;
        }

        private void K_Click(object sender, EventArgs e)
        {
            label5.Text += "K  ";
            Click('K');
            K.BackColor = System.Drawing.Color.Gray;
            K.Enabled = false;
        }

        private void L_Click(object sender, EventArgs e)
        {
            label5.Text += "L  ";
            Click('L');
            L.BackColor = System.Drawing.Color.Gray;
            L.Enabled = false;
        }

        private void M_Click(object sender, EventArgs e)
        {
            label5.Text += "M  ";
            Click('M');
            M.BackColor = System.Drawing.Color.Gray;
            M.Enabled = false;
        }

        private void N_Click(object sender, EventArgs e)
        {
            label5.Text += "N  ";
            Click('N');
            N.BackColor = System.Drawing.Color.Gray;
            N.Enabled = false;
        }

        private void O_Click(object sender, EventArgs e)
        {
            label5.Text += "O  ";
            Click('O');
            O.BackColor = System.Drawing.Color.Gray;
            O.Enabled = false;
        }

        private void P_Click(object sender, EventArgs e)
        {
            label5.Text += "P  ";
            Click('P');
            P.BackColor = System.Drawing.Color.Gray;
            P.Enabled = false;
        }

        private void Q_Click(object sender, EventArgs e)
        {
            label5.Text += "Q  ";
            Click('Q');
            Q.BackColor = System.Drawing.Color.Gray;
            Q.Enabled = false;
        }

        private void R_Click(object sender, EventArgs e)
        {
            label5.Text += "R  ";
            Click('R');
            R.BackColor = System.Drawing.Color.Gray;
            R.Enabled = false;
        }

        private void S_Click(object sender, EventArgs e)
        {
            label5.Text += "S  ";
            Click('S');
            S.BackColor = System.Drawing.Color.Gray;
            S.Enabled = false;
        }

        private void T_Click(object sender, EventArgs e)
        {
            label5.Text += "T  ";
            Click('T');
            T.BackColor = System.Drawing.Color.Gray;
            T.Enabled = false;
        }

        private void U_Click(object sender, EventArgs e)
        {
            label5.Text += "U  ";
            Click('U');
            U.BackColor = System.Drawing.Color.Gray;
            U.Enabled = false;
        }

        private void V_Click(object sender, EventArgs e)
        {
            label5.Text += "V  ";
            Click('V');
            V.BackColor = System.Drawing.Color.Gray;
            V.Enabled = false;
        }

        private void W_Click(object sender, EventArgs e)
        {
            label5.Text += "W  ";
            Click('W');
            W.BackColor = System.Drawing.Color.Gray;
            W.Enabled = false;
        }

        private void X_Click(object sender, EventArgs e)
        {
            label5.Text += "X  ";
            Click('X');
            X.BackColor = System.Drawing.Color.Gray;
            X.Enabled = false;
        }

        private void Y_Click(object sender, EventArgs e)
        {
            label5.Text += "Y  ";
            Click('Y');
            Y.BackColor = System.Drawing.Color.Gray;
            Y.Enabled = false;
        }

        private void Z_Click(object sender, EventArgs e)
        {
            label5.Text += "Z  ";
            Click('Z');
            Z.BackColor = System.Drawing.Color.Gray;
            Z.Enabled = false;
        }

       
        private void Hint_Click(object sender, EventArgs e)
        {
            int k= RandNumber(0, getAnswer().Length-1);
            while (getSelCh()[k]!='_'){
                k = RandNumber(0, getAnswer().Length - 1);
            }
            Click(getAnswer()[k]);
            Hint.Enabled = false;
        }




        
    }
}
