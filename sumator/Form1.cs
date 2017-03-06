using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sumator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            binarny1();
            binarny2();
            binarny3();
        }


        private void binarny1()
        {
            string wynik = "";
            if (checkBox1.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            if (checkBox2.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox3.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox4.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            textBox1.Text = wynik;
        }

        private void binarny2()
        {
            string wynik = "";
            if (checkBox5.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            if (checkBox6.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox7.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox8.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            textBox2.Text = wynik;
        }

        private void binarny3()
        {
            string wynik = "";
            if (checkBox9.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            if (checkBox10.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox11.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox12.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            } if (checkBox13.Checked)
            {
                wynik += "1";
            }
            else
            {
                wynik += "0";
            }
            textBox3.Text = wynik;
        }

        private void sumuj()
        {
            /*
            bool A0, B0, C0, C1, S1;
            A0 = checkBox4.Checked;
            B0 = checkBox8.Checked;
            C0 = false;
            S1 = A0 ^ B0 ^ C0;
            C1 = (A0 & B0) | (C0 & (A0 ^ B0));
            checkBox13.Checked = S1;
            checkBox12.Checked = C1;
            */
            bool A0, A1, A2, A3;
            bool B0, B1, B2, B3;
            bool C0, C1, C2, C3, C4;
            bool S0, S1, S2, S3;

            A0 = checkBox4.Checked;
            A1 = checkBox3.Checked;
            A2 = checkBox2.Checked;
            A3 = checkBox1.Checked;
            B0 = checkBox8.Checked;
            B1 = checkBox7.Checked;
            B2 = checkBox6.Checked;
            B3 = checkBox5.Checked;
            C0 = false;
            S0 = A0 ^ B0 ^ C0;
            C1 = (A0 & B0) | (C0 & (A0 ^ B0));

            S1 = A1 ^ B1 ^ C1;
            C2 = (A1 & B1) | (C1 & (A1 ^ B1));

            S2 = A2 ^ B2 ^ C2;
            C3 = (A2 & B2) | (C2 & (A2 ^ B2));

            S3 = A3 ^ B3 ^ C3;
            C4 = (A3 & B3) | (C3 & (A3 ^ B3));
            checkBox13.Checked = S0;
            checkBox12.Checked = S1;
            checkBox11.Checked = S2;
            checkBox10.Checked = S3;
            checkBox9.Checked = C4;
            
        }
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            binarny1();
            sumuj();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            binarny1();
            sumuj();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            binarny1();
            sumuj();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            binarny1();
            sumuj();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            binarny2();
            sumuj();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            binarny2();
            sumuj();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            binarny2();
            sumuj();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            binarny2();
            sumuj();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            binarny3();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            binarny3();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            binarny3();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            binarny3();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            binarny3();
        }
    }
}
