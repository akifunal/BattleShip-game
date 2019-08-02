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
    public partial class Form4 : Form
    {
        Form openner;
        public Form4(Form pp)
        {
            InitializeComponent();
            openner = pp;
        }
        public static string winner;

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = winner;
            
            
            openner.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
