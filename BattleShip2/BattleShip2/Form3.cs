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
    public partial class Form3 : Form
    {


        Form openner;
        public Form3(Form pp)
        {

            InitializeComponent();
            openner = pp;
        }
        int a = 0;
        int x = 0;
        public static List<string> player1ships = new List<string>();
        public static List<string> player1mines = new List<string>();
        public static List<string> player2ships = new List<string>();
        public static List<string> player2mines = new List<string>();
        private void Form3_Load(object sender, EventArgs e)
        {
            openner.Hide();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (Form1.Player1 != "")
            {
                label1.Text = Form1.Player1 + "'s placement";
            }
            if (Form1.Player2 != "")
            {
                label2.Text = Form1.Player2 + "'s placement";
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
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 1:
                            b.Name = "b" + counter.ToString();
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 2:
                            b.Name = "c" + counter.ToString();
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 3:
                            b.Name = "d" + counter.ToString();
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 4:
                            b.Name = "e" + counter.ToString();
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 5:
                            b.Name = "f" + counter.ToString();
                            b.Location = new Point(30 + counter * 45, 120 + i * 45);
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
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 1:
                            b.Name = "bb" + counter.ToString();
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 2:
                            b.Name = "cc" + counter.ToString();
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 3:
                            b.Name = "dd" + counter.ToString();
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 4:
                            b.Name = "ee" + counter.ToString();
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
                            b.Size = new Size(45, 45);
                            break;
                        case 5:
                            b.Name = "ff" + counter.ToString();
                            b.Location = new Point(475 + counter * 45, 120 + i * 45);
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

        void buttonp1_click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                Button btn = sender as Button;
                switch (a)
                {
                    case 0:
                        break;

                    case 1:

                        if (buttons.Count != 0)
                        {
                            bool c = false;
                            bool hata = true;
                            foreach (var item in buttons)
                            {
                                char[] chara = btn.Name.ToCharArray();
                                char[] charb = item.Name.ToCharArray();

                                if ((chara[0] == charb[0]) && harf)
                                {
                                    
                                    char aa = chara[1];
                                    char aa1 = chara[1];
                                    char bb = charb[1];
                                    char bb1 = charb[1];
                                    aa1++;
                                    bb1++;
                                    if (aa1 == bb || bb1 == aa)
                                    {
                                        player1ships.Add(btn.Name);
                                        btn.BackgroundImage = Properties.Resources.s;
                                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                                        x--;
                                        c = true;
                                        hata = false;
                                        rakam = false;
                                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                                        sayi2++;
                                    }

                                }
                                else if ((chara[1] == charb[1]) && rakam)
                                {
                                    
                                    char aa = chara[0];
                                    char aa1 = chara[0];
                                    char bb = charb[0];
                                    char bb1 = charb[0];
                                    aa1++;
                                    bb1++;
                                    if (aa1 == bb || bb1 == aa)
                                    {
                                        player1ships.Add(btn.Name);
                                        btn.BackgroundImage = Properties.Resources.s;
                                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                                        x--;
                                        c = true;
                                        hata = false;
                                        harf = false;
                                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                                        sayi2++;
                                    }
                                }

                            }
                            if (hata)
                            {
                                MessageBox.Show("the ships units must be next to each other");
                            }
                            if (c)
                            {
                                buttons.Add(btn);
                            }

                        }
                        else
                        {
                            player1ships.Add(btn.Name);
                            btn.BackgroundImage = Properties.Resources.s;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            x--;
                            buttons.Add(btn);
                            Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                            sayi2++;
                        }
                        //if (btnct.Name != "")
                        //{
                        //    char[] chara = btn.Name.ToCharArray();
                        //    char[] charb = btnct.Name.ToCharArray();

                        //    if ((chara[0] == charb[0]) && harf)
                        //    {
                        //        rakam = false;
                        //        char aa = chara[1];
                        //        char aa1 = chara[1];
                        //        char bb = charb[1];
                        //        char bb1 = charb[1];
                        //        aa1++;
                        //        bb1++;
                        //        if (aa1 == bb || bb1 == aa)
                        //        {
                        //            player1ships.Add(btn.Name);
                        //            btn.BackgroundImage = Properties.Resources.s;
                        //            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //            x--;
                        //            btnct = btn;
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("the ships units must be next to each other");
                        //        }

                        //    }
                        //    else if ((chara[1] == charb[1]) && rakam)
                        //    {
                        //        harf = false;
                        //        char aa = chara[0];
                        //        char aa1 = chara[0];
                        //        char bb = charb[0];
                        //        char bb1 = charb[0];
                        //        aa1++;
                        //        bb1++;
                        //        if (aa1 == bb || bb1 == aa)
                        //        {
                        //            player1ships.Add(btn.Name);
                        //            btn.BackgroundImage = Properties.Resources.s;
                        //            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //            x--;
                        //            btnct = btn;
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("the ships units must be next to each other");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("the ships units must be next to each other");
                        //    }
                        //}
                        //else
                        //{
                        //    player1ships.Add(btn.Name);
                        //    btn.BackgroundImage = Properties.Resources.s;
                        //    btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //    x--;
                        //    btnct = btn;
                        //}

                        break;

                    case 2:
                        player1mines.Add(btn.Name);
                        btn.BackgroundImage = Properties.Resources.b;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        x--;
                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                        sayi2++;
                        break;

                }

                if (x == 0)
                {
                    //btnct.Name = "";
                    sayi2 = 1;
                    buttons.Clear();
                    rakam = true;
                    harf = true;
                    //MessageBox.Show("placement is done");
                }
            }
            else
            {
                //MessageBox.Show("placement is done");
            }


        }
        List<Button> buttons = new List<Button>();
        Button btnct = new Button();
        bool harf = true;
        bool rakam = true;
        void buttonp2_click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                Button btn = sender as Button;
                switch (a)
                {
                    case 0:
                        break;

                    case 1:
                        if (buttons.Count != 0)
                        {
                            bool c = false;
                            bool hata = true;
                            foreach (var item in buttons)
                            {
                                char[] chara = btn.Name.ToCharArray();
                                char[] charb = item.Name.ToCharArray();

                                if ((chara[0] == charb[0]) && harf)
                                {
                                    
                                    char aa = chara[2];
                                    char aa1 = chara[2];
                                    char bb = charb[2];
                                    char bb1 = charb[2];
                                    aa1++;
                                    bb1++;
                                    if (aa1 == bb || bb1 == aa)
                                    {
                                        player2ships.Add(btn.Name);
                                        btn.BackgroundImage = Properties.Resources.s;
                                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                                        x--;
                                        hata = false;
                                        c = true;
                                        rakam = false;
                                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                                        sayi2++;
                                    }

                                }
                                else if ((chara[2] == charb[2]) && rakam)
                                {
                                    
                                    char aa = chara[0];
                                    char aa1 = chara[0];
                                    char bb = charb[0];
                                    char bb1 = charb[0];
                                    aa1++;
                                    bb1++;
                                    if (aa1 == bb || bb1 == aa)
                                    {
                                        player2ships.Add(btn.Name);
                                        btn.BackgroundImage = Properties.Resources.s;
                                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                                        x--;
                                        hata = false;
                                        c = true;
                                        harf = false;
                                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                                        sayi2++;
                                    }
                                }
                            }
                            if (hata)
                            {
                                MessageBox.Show("the ships units must be next to each other");
                            }
                            if (c)
                            {
                                buttons.Add(btn);
                            }

                        }
                        else
                        {
                            player2ships.Add(btn.Name);
                            btn.BackgroundImage = Properties.Resources.s;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            x--;
                            buttons.Add(btn);
                            Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                            sayi2++;
                        }
                        //if (btnct.Name != "")
                        //{
                        //    char[] chara = btn.Name.ToCharArray();
                        //    char[] charb = btnct.Name.ToCharArray();

                        //    if ((chara[0] == charb[0]) && harf)
                        //    {
                        //        rakam = false;
                        //        char aa = chara[2];
                        //        char aa1 = chara[2];
                        //        char bb = charb[2];
                        //        char bb1 = charb[2];
                        //        aa1++;
                        //        bb1++;
                        //        if (aa1 == bb || bb1 == aa)
                        //        {
                        //            player2ships.Add(btn.Name);
                        //            btn.BackgroundImage = Properties.Resources.s;
                        //            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //            x--;
                        //            btnct = btn;
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("the ships units must be next to each other");
                        //        }

                        //    }
                        //    else if ((chara[2] == charb[2]) && rakam)
                        //    {
                        //        harf = false;
                        //        char aa = chara[0];
                        //        char aa1 = chara[0];
                        //        char bb = charb[0];
                        //        char bb1 = charb[0];
                        //        aa1++;
                        //        bb1++;
                        //        if (aa1 == bb || bb1 == aa)
                        //        {
                        //            player2ships.Add(btn.Name);
                        //            btn.BackgroundImage = Properties.Resources.s;
                        //            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //            x--;
                        //            btnct = btn;
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("the ships units must be next to each other");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("the ships units must be next to each other");
                        //    }
                        //}
                        //else
                        //{
                        //    player2ships.Add(btn.Name);
                        //    btn.BackgroundImage = Properties.Resources.s;
                        //    btn.BackgroundImageLayout = ImageLayout.Stretch;
                        //    x--;
                        //    btnct = btn;
                        //}

                        break;

                    case 2:
                        player2mines.Add(btn.Name);
                        btn.BackgroundImage = Properties.Resources.b;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        x--;
                        Button.Text = sayi2.ToString() + "/" + sayi1.ToString();
                        sayi2++;
                        break;

                }

                if (x == 0)
                {
                    buttons.Clear();
                    sayi2 = 1;
                    //btnct.Name = "";
                    rakam = true;
                    harf = true;
                    //MessageBox.Show("placement is done");
                }
            }
            else
            {
                //MessageBox.Show("placement is done");
            }


        }

        Button Button = new Button();
        int sayi1, sayi2=1;
        private void button4_Click(object sender, EventArgs e)
        {
            Button = button4;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 3;
                button4.Enabled = false;
                sayi1 = 3;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button = button6;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 4;
                button6.Enabled = false;
                sayi1 = 4;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button = button5;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 2;
                x = 2;
                button5.Enabled = false;
                sayi1 = 2;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button = button12;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 2;
                button12.Enabled = false;
                sayi1 = 2;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button = button11;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 3;
                button11.Enabled = false;
                sayi1 = 3;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button = button9;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 4;
                button9.Enabled = false;
                sayi1 = 4;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button = button10;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 2;
                x = 2;
                button10.Enabled = false;
                sayi1 = 2;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button = button3;
            if (x != 0)
            {
                MessageBox.Show("placement is not done yet");
            }
            else
            {
                a = 1;
                x = 2;
                button3.Enabled = false;
                sayi1 = 2;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            DialogResult msg = MessageBox.Show("Player1's placement has started. Plase Place your ships accordingly. Do not let Player2 see!", "Player1's placement");
            button1.Visible = false;
        }


        private void button7_Click(object sender, EventArgs e)
        {


            a = 0;
            if (button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
            {
                pictureBox1.Visible = true;
                DialogResult msg = MessageBox.Show("Player1's placement is completed.", "Player1's placement");
                button7.Visible = false;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("placement is not done");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            DialogResult msg = MessageBox.Show("Player2's placement has started. Plase Place your ships accordingly.  Do not let Player1 see!", "Player2's placement");
            button2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            a = 0;
            if (button9.Enabled == false && button10.Enabled == false && button11.Enabled == false && button12.Enabled == false)
            {
                pictureBox2.Visible = true;
                DialogResult msg = MessageBox.Show("Player2's placement is completed.", "Player2's placement");
                button8.Visible = false;
                button13.Visible = true;

            }
            else
            {
                MessageBox.Show("placement is not done");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
