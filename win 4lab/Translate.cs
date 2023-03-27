using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_4lab
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Translate_Load(object sender, EventArgs e)
        {

        }
        public void TextMY(string a) 
        { textBox1.Text = a; }
    }
}
