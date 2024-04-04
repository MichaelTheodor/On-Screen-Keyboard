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

namespace On_Screen_Keyboard
{
    public partial class Form1 : Form
    {
        private ContextMenuStrip rightClickMenu;
        public Form1()
        {
            InitializeComponent();
        }    
        protected override CreateParams CreateParams 
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        private void button52_Click_1(object sender, EventArgs e) // space btn
        {
            SendKeys.Send(" ");
        }
        private void Alphabet(object sender, EventArgs e) //Alphabet plus Caps Lock btn plus Shift btn
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            if (chkCapsLock.Checked == true || chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send((btn.Text).ToUpper());
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send((btn.Text).ToLower());
            }
        }
        private void NumPad(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            if (chkNumLock.Checked == true)
            {
                SendKeys.Send((btn.Text));
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
        }

        private void chkNumLock_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chkNumLock.Checked)
            {
                SendKeys.Send("{NUMLOCK}");
                pictureBox1.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                SendKeys.Send("{NUMLOCK}");
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{DIVIDE}");
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{MULTIPLY}");
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{SUBTRACT}");
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{ADD}");
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }
       
        private void button78_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button92_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button91_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button90_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button89_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button88_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button87_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button86_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button85_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button84_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button83_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button82_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button81_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button80_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button50_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button95_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC");
        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button94_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button93_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{BREAK}");
        }

        private void button51_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{INSERT}");
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void button49_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button46_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }
       
        
        private void button76_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{+}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void button64_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{_}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void button65_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{)}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void button66_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{(}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void button67_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{*}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void button68_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{&}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void button69_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{^}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void button70_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{%}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void button71_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{$}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void button72_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{#}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void button73_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{@}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void button74_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{!}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void button75_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{~}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
            }
        }

        private void btnTab_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void chkCapsLock_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chkCapsLock.Checked)
            {
                SendKeys.Send("{CAPSLOCK}");
                pictureBox2.Visible = true;
                pictureBox5.Visible = false;
            }
            else
            {
                SendKeys.Send("{CAPSLOCK}");
                pictureBox2.Visible = false;
                pictureBox5.Visible = true;    
            }
        }
        
        private void chkShiftL_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("+");
        }

        private void chkShiftR_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("+");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) // ctrl
        {
            SendKeys.Send("^");
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e) // windows key
        {
            SendKeys.Send("^{ESC}");
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("^{ESC}");
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e) // alt key
        {
            SendKeys.Send("%");
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

       
       
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{}}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{]}");
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{{}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{[}");
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{|}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
            }
        }
        
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{\"}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{'}");
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{:}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{;}");
            }
        }

        private void button53_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{?}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{>}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{.}");
            }
        }

        private void button55_Click_1(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{<}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{,}");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send("{|}");
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
            }
        }

        private void chkScrollLock_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkScrollLock.Checked)
            {
                SendKeys.Send("{SCROLLLOCK}");
                pictureBox3.Visible = true;
                pictureBox6.Visible = false;
            }
            else
            {
                SendKeys.Send("{SCROLLLOCK}");
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{¬}");
        }
    }
}
