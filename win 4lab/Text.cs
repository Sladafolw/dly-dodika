using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace win_4lab
{
    public partial class Text : Form
    { public Translate translate;
        public Text()
        {
            InitializeComponent();
        }
        int s;
        int l;
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            s=textBox1.SelectionStart;
         
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int k = 0;
            l = textBox1.SelectionLength;
            textBox1.SelectionStart= s ;
            string? str;
            var selectedtext = textBox1.SelectedText ;
            using (StreamReader fa = new StreamReader(@"F:\descr.txt")) 
            {
            str=  fa.ReadToEnd();

            }
          var Str =  str.Split("-");
            try
            {
                foreach (var a in Str)
                {
                    k++;
                    if (a.Contains(selectedtext))
                    {
                        break;
                    }
                    if (k > 13) { translate.TextMY("не нашел строку"); }

                }
                translate.TextMY(Str[k]);
            }
            catch(Exception EX) { }
            
           
        }
        
        private void Text_Load(object sender, EventArgs e)
        {
            textBox1.Text = "double[] b=new double[20]; \r\ndouble[] c = new double[20]; \r\ndouble[] a = new double[20];\r\ndouble h = 2;\r\nRandom random=new Random();\r\nfor (int i = 0;i < 20; i++)\r\n{  }";
        }
    }
}
