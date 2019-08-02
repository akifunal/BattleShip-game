using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip2
{
    public partial class Form2 : Form
    {
        Form openner;
        public Form2(Form pp)
        {
            InitializeComponent();
            openner = pp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.Player1 != "")
            {
                label3.Text = Form1.Player1 + "'s turn ";
            }
            if (Form1.Player2 != "")
            {
                label4.Text = Form1.Player2 + "'s turn ";
            }

            openner.Hide();
            if (Form1.Player1 != "")
            {
                label1.Text = Form1.Player1;
            }
            if (Form1.Player2 != "")
            {
                label2.Text = Form1.Player2;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int counter = 0; counter < 7; counter++)
                {
                    Button b = new Button();
                    switch (i)
                    {
                        case 0:
                            b.Name = "a" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 1:
                            b.Name = "b" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 2:
                            b.Name = "c" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 3:
                            b.Name = "d" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 4:
                            b.Name = "e" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 5:
                            b.Name = "f" + counter.ToString();
                            b.Location = new Point(25 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;

                    }
                    b.BackgroundImage = Properties.Resources.a;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Click += new EventHandler(this.buttonp1_click);
                    this.Controls.Add(b);
                }



            }
            for (int i = 0; i < 5; i++)
            {
                for (int counter = 0; counter < 7; counter++)
                {
                    Button b = new Button();
                    switch (i)
                    {
                        case 0:
                            b.Name = "aa" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 1:
                            b.Name = "bb" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 2:
                            b.Name = "cc" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 3:
                            b.Name = "dd" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 4:
                            b.Name = "ee" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 5:
                            b.Name = "ff" + counter.ToString();
                            b.Location = new Point(474 + counter * 45, 177 + i * 45);
                            b.Size = new Size(45, 45);
                            break;

                    }
                    b.BackgroundImage = Properties.Resources.a;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Click += new EventHandler(this.buttonp2_click);
                    this.Controls.Add(b);
                }



            }
        }
        int a;
        int bitis1 = 9;
        int score1 = 0;
        void buttonp1_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (label4.Visible == true)
            {
                label4.Visible = false;
                label3.Visible = true;
                
               
                a++;
                label6.Text = Convert.ToString(a);
                bool ct = true;
                foreach (var item in Form3.player1ships)
                {
                    if (btn.Name == item)
                    {
                        btn.BackgroundImage = Properties.Resources.s;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        ct = false;
                        bitis1--;
                        score2++;
                        label40.Text = score2.ToString();
                    }
                }
                foreach (var i in Form3.player1mines)
                {
                    if (btn.Name == i)
                    {
                        btn.BackgroundImage = Properties.Resources.b;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        score2--;
                        label40.Text = score2.ToString();
                        ct = false;
                    }
                }
                if (ct)
                {
                    btn.BackgroundImage = Properties.Resources.x;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }


            }
            else
            {
                if (Form1.Player2 != "")
                {
                    MessageBox.Show(Form1.Player1 + "'s turn");
                }
                else
                {
                    MessageBox.Show("Player1's turn");
                }

            }
            if (bitis1 == 0)
            {
                if (Form1.Player2 != "")
                {
                    Form4.winner = Form1.Player2 + " won!";
                }
                else
                {
                    Form4.winner = "player2 won!";
                }
                Form4 form4 = new Form4(this);
                form4.Show();

            }

        }
        int b;
        int bitis2 = 9;
        int score2 = 0;
        void buttonp2_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (label3.Visible == true)
            {

                label4.Visible = true;
                label3.Visible = false;
                b++;
                label5.Text = Convert.ToString(b);
                bool ct = true;
                foreach (var item in Form3.player2ships)
                {
                    if (btn.Name == item)
                    {
                        btn.BackgroundImage = Properties.Resources.s;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        ct = false;
                        bitis2--;
                        score1++;
                        label38.Text = score1.ToString();
                    }
                }
                foreach (var i in Form3.player2mines)
                {
                    if (btn.Name == i)
                    {
                        btn.BackgroundImage = Properties.Resources.b;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        score1--;
                        label38.Text = score1.ToString();
                        ct = false;
                    }
                }
                if (ct)
                {
                    btn.BackgroundImage = Properties.Resources.x;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else
            {
                if (Form1.Player1 != "")
                {
                    MessageBox.Show(Form1.Player2 + "'s turn");
                }
                else
                {
                    MessageBox.Show("Player2's turn");
                }
            }
            if (bitis2==0)
            {
                if (Form1.Player1 != "")
                {
                    Form4.winner = Form1.Player1 + " won!";
                }
                else
                {
                    Form4.winner = "player1 won!";
                }
                Form4 form4 = new Form4(this);
                form4.Show();
                
            }

        }
    }
}
