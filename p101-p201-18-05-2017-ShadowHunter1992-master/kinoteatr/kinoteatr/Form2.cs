using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kinoteatr
{
    
    public partial class Form2 : Form
    {
        
        public Dictionary<string, bool> cadi = new Dictionary<string, bool>();
        public List<string> lst = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            for(var a=0;a<10;a++)
            {
                Label c = new Label();
                c.Text = (a+1).ToString();
                c.Name = a.ToString();
                c.Location = new Point(a * 40 + 80, 20);
              
                c.AutoSize = true;
                Controls.Add(c);
              

                for( var b=0; b<4;b++)
                {
                    
                    char btn = Convert.ToChar(b + 65);
                    Button x = new Button();
                    x.Location = new Point(a * 40 + 70, b * 40 + 40);
                    x.Size = new Size(40, 40);
                    x.Name = System.String.Format("{0}-{1}",Convert.ToChar(b+65),a+1);
                 
                    x.Margin = new System.Windows.Forms.Padding(15);
                    x.BackColor = System.Drawing.Color.Blue;
                    x.ForeColor = Color.White;
                    x.Text = System.String.Format("{0}-{1}",btn,a+1);
                    x.Cursor= System.Windows.Forms.Cursors.Hand;
                    cadi.Add(x.Text, true);
                    x.Click += new EventHandler(yoxlagor);
                    Controls.Add(x);
                }
              
            }
            for (var jj = 0; jj < 4; jj++)
            {
                Label d = new Label();
                char txt = Convert.ToChar(jj + 65);
                d.Text = txt.ToString();
                d.Location = new Point(50, jj * 40 + 50);
                d.AutoSize = true;
                Controls.Add(d);
            }
        }
        private  void yoxlagor(object sender,EventArgs s)
        {
            Button a = (Button)sender;
            lst.Add(a.Text);
            a.BackColor = Color.Aqua;
            a.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder aa = new StringBuilder();
           
            bool baxilanyerler = true;
          
            foreach(var elem in lst)
            {
                if (cadi[elem] != true)
                {
                    baxilanyerler = false;
                    aa.Append(elem+ " \n");
                }
               
            }
               if(baxilanyerler==true)
                {
                    MessageBox.Show("Secdiyiniz butun Yerler bowdur ");
                button2.Enabled = true;

                }
                else
                {
                MessageBox.Show(aa.ToString() + "BU Yerler zanitdir");
                button2.Enabled = false;
                foreach(var keyvalu in cadi)
                {
                    if(keyvalu.Value==false)
                    {
                        Button xx = Controls.Find(keyvalu.Key, true).First() as Button;
                        xx.BackColor = Color.Green;
                    }
                    else
                    {
                        Button xx = Controls.Find(keyvalu.Key, true).First() as Button;
                        xx.BackColor = Color.Blue;
                        xx.ForeColor = Color.White;
                    }
                }
               }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cem = 0;
            foreach (var elem in lst)
            {
                if (cadi[elem] == true)
                {
                    cem += 15;
                    cadi[elem] = false;
                    if(cadi[elem]==false)
                    {
                      Button necef=  Controls.Find(elem, true).First() as Button;
                        necef.BackColor = Color.Green;
                      

                    }
                }
                ;
            }
            lst.Clear();
            textBox1.Text = string.Format("{0}:AZN", cem);
        }
    }
}
