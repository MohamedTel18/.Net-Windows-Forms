using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WhoWantToBeMillionaire
{
    public partial class Form1 : Form
    {
        int MoneyWin = 0;
        byte LevalTotal = 1;
        Random Rand = new Random();
        Question questionPub = null;
        byte QNum = 1;

        List<Question> questions = new List<Question>
        {
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=1},
            new Question{Text="Which Team Won The World Cup 2022",Options=new[]{"Argentina","France","Qatar","moroco"},CorrectAnswerIndx=0,Level=1},
            new Question{Text="What is The Largest Country in the World",Options=new[]{"Usa","China","Russia","KSA"},CorrectAnswerIndx=2,Level=1},
            new Question{Text="Which of these Periods Are 12 mounths",Options=new[]{"Week","Year","Day","Mounth"},CorrectAnswerIndx=1,Level=1},
            new Question{Text="What type of animls was King kong in the film",Options=new[]{"bee","Dog","cat","Ape"},CorrectAnswerIndx=3,Level=1},
            new Question{Text="How much does Elon Mask Wealth",Options=new[]{"250B","247B","241B","240B"},CorrectAnswerIndx=2,Level=1},
            new Question{Text="In God Father What is the name of the father Corleone?",Options=new[]{"Vito","Dni","Michel","Luca"},CorrectAnswerIndx=0,Level=1},
            new Question{Text="Who Won The UCL in 2004",Options=new[]{"Real Madrid","Milan Ac","Porto","Hamburg"},CorrectAnswerIndx=2,Level=2},
            new Question{Text="What is the Game of the year 2013",Options=new[]{"GTA V","Last Of us","Tomb Raider","Fifa 13"},CorrectAnswerIndx=1,Level=2},
            new Question{Text="Who is The President of USA Before Obama",Options=new[]{"Biden","Trump","Clinton","Bush"},CorrectAnswerIndx=3,Level=2},
            new Question{Text="What is the capital Of Ghana",Options=new[]{"Akra","Dakar","Keny","Togo"},CorrectAnswerIndx=0,Level=2},
            new Question{Text="How many Ballon d'or did Zidan have",Options=new[]{"2","4","1","0"},CorrectAnswerIndx=2,Level=2},
            new Question{Text="What is the name of Apple founder",Options=new[]{"S.Jobs","A.musk","B.Gate","Z.Mark"},CorrectAnswerIndx=0,Level=2},
            new Question{Text="When did twitter lunch",Options=new[]{"2008","2006","2010","2007"},CorrectAnswerIndx=1,Level=2},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},
            new Question{Text="What is the capital Of Italy",Options=new[]{"Paris","Roma","London","Madrid"},CorrectAnswerIndx=1,Level=3},

        };

        Question RandomQuestion(int Lvl)
        {
            if (MoneyWin < 500)
                LevalTotal = 1;

            else if (MoneyWin >= 500 && MoneyWin < 32000)
                LevalTotal = 2;

            else if (MoneyWin >= 32000)
                LevalTotal = 3;

            var ques = questions.Where(q => q.Level == Lvl).ToList();
            int indx = Rand.Next(ques.Count);
            return ques[indx];
        }

        void DisplayQuestion()
        {
            if(QNum!=1)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            

            Question Qst = RandomQuestion(LevalTotal);
            questionPub = Qst;

            label1.Text = Qst.Text;
            label2.Text = "1-" + Qst.Options[0];
            label3.Text = "2-" + Qst.Options[1];
            label4.Text = "3-" + Qst.Options[2];
            label5.Text = "4-" + Qst.Options[3];
        }

        public Form1()
        {
            InitializeComponent();
        }

        public class Question
        {
            

            public string Text { get; set; }
            public string[] Options { get; set; }
            public int CorrectAnswerIndx { get; set; }
            public int Level { get; set; }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayQuestion();
        }

        void ChangeLabelBackColor(Label lb)
        {
            lb.BackColor = Color.Yellow;
        }

        void ReturnBackColor(Label lb)
        {
            lb.BackColor = Color.Transparent;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            ChangeLabelBackColor((Label)sender);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            ReturnBackColor((Label)sender);
        }

        void MoneyEdit()
        {
            switch(QNum)
            {
                case 2:
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Yellow;
                    MoneyWin = 100;
                    break;

                case 3:
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Yellow;
                    MoneyWin = 200;
                    break;

                case 4:
                    label8.BackColor = Color.Transparent;
                    label9.BackColor = Color.Yellow;
                    MoneyWin = 300;
                    break;

                case 5:
                    label9.BackColor = Color.Transparent;
                    label10.BackColor = Color.Yellow;
                    MoneyWin = 500;
                    break;

                case 6:
                    label10.BackColor = Color.Transparent;
                    label11.BackColor = Color.Yellow;
                    MoneyWin = 1000;
                    break;

                case 7:
                    label11.BackColor = Color.Transparent;
                    label12.BackColor = Color.Yellow;
                    MoneyWin = 2000;
                    break;

                case 8:
                    label12.BackColor = Color.Transparent;
                    label13.BackColor = Color.Yellow;
                    MoneyWin = 4000;
                    break;

                case 9:
                    label13.BackColor = Color.Transparent;
                    label14.BackColor = Color.Yellow;
                    MoneyWin = 8000;
                    break;

                case 10:
                    label14.BackColor = Color.Transparent;
                    label15.BackColor = Color.Yellow;
                    MoneyWin = 16000;
                    break;

                case 11:
                    label15.BackColor = Color.Transparent;
                    label16.BackColor = Color.Yellow;
                    MoneyWin = 32000;
                    break;

                case 12:
                    label16.BackColor = Color.Transparent;
                    label17.BackColor = Color.Yellow;
                    MoneyWin = 64000;
                    break;

                case 13:
                    label17.BackColor = Color.Transparent;
                    label18.BackColor = Color.Yellow;
                    MoneyWin = 125000;
                    break;

                case 14:
                    label18.BackColor = Color.Transparent;
                    label19.BackColor = Color.Yellow;
                    MoneyWin = 250000;
                    break;

                case 15:
                    label19.BackColor = Color.Transparent;
                    label20.BackColor = Color.Yellow;
                    MoneyWin = 500000;
                    break;

                case 16:
                    label20.BackColor = Color.Transparent;
                    MoneyWin = 1000000;
                    break;
            }
        }

        void GameOver()
        {
            groupBox1.Visible = true;

            label6.BackColor = Color.Yellow;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label21.Enabled = false;
            label23.Enabled = false;
            label24.Enabled = false;

            label26.Text = MoneyWin.ToString();
        }

        void Edit(bool Result,Label lbl)
        {

            if(Result)
            {
                lbl.BackColor = Color.Green;
                QNum++;
                MoneyEdit();
                int k = 50;
                label22.Text = k.ToString();
                DisplayQuestion();
            }

            else
            {
                lbl.BackColor = Color.Red;
                label27.Text = textBox1.Text;
                GameOver();
            }
        }

        void CheckAnswer(Label lbl)
        {
            int X = int.Parse(lbl.Tag.ToString());

            Edit(X == questionPub.CorrectAnswerIndx,lbl);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CheckAnswer((Label)sender);
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int y = int.Parse(label22.Text);
            y--;

            label22.Text = y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Invailed Name!");
                textBox1.Focus();
            }

            else
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                timer1.Enabled = true;

                groupBox2.Visible = false;
                label25.Visible = true;
                label25.Text = textBox1.Text;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Labels('D');
            groupBox3.Visible = true;
            button4.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            List<byte> N = new List<byte>();

            for(byte i=0;i<=3;i++)
            {
                if(i!=questionPub.CorrectAnswerIndx)
                {
                    N.Add(i);
                }
            }

            int x1 = Rand.Next(N.Count);
            int x2 = Rand.Next(N.Count);
            
            while(x1==x2)
            {
                x1 = Rand.Next(N.Count);
                x2 = Rand.Next(N.Count);
            }


            if (x1 == 0 || x2 == 0)
                label2.Visible = false;

            if (x1 == 1 || x2 == 1)
                label3.Visible = false;

            if (x1 == 2 || x2 == 2)
                label4.Visible = false;

            if (x1 == 3 || x2 == 3)
                label5.Visible = false;

            label21.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Labels('E');
            groupBox3.Visible = false;
            label24.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label31.Text = (questionPub.CorrectAnswerIndx + 1).ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Labels('E');
            groupBox4.Visible = false;
            label23.Enabled = false;
        }

        void Labels(char Mode)
        {
            if(Mode=='D')
            {
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }

            else
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Labels('D');
            short Per = 40;
            groupBox4.Visible = true;

            if (questionPub.CorrectAnswerIndx == 0)
                progressBar1.Value = 60;

            else if (questionPub.CorrectAnswerIndx == 1)
                progressBar2.Value = 60;

            else if (questionPub.CorrectAnswerIndx == 2)
                progressBar3.Value = 60;

            else if (questionPub.CorrectAnswerIndx == 3)
                progressBar4.Value = 60;


            int x1 = Rand.Next(0, Per);
            int x2 = Rand.Next(0, Per - x1);
            int x3 = Per - x1 - x2;

            if(progressBar1.Value==60)
            {
                progressBar2.Value = x1;
                progressBar3.Value = x2;
                progressBar4.Value = x3;
            }

            else if(progressBar2.Value==60)
            {
                progressBar3.Value = x1;
                progressBar4.Value = x2;
                progressBar1.Value = x3;
            }

            else if (progressBar3.Value == 60)
            {
                progressBar4.Value = x1;
                progressBar1.Value = x2;
                progressBar2.Value = x3;
            }

            else if (progressBar4.Value == 60)
            {
                progressBar1.Value = x1;
                progressBar2.Value = x2;
                progressBar3.Value = x3;
            }

            button5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label23.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label24.Enabled = true;

            MoneyWin = 0;
            QNum = 1;
            LevalTotal = 1;
            DisplayQuestion();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/mohammed.telkhoukhe";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
                
            });
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/m.tel18/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/mohamed-telkhoukhe-419019246/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}