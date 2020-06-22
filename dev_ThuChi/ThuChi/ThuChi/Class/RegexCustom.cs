using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuChi
{
    public class RegexCustom
    {
        private static RegexCustom instance;

        public static RegexCustom Instance { get { if (instance == null) instance = new RegexCustom(); return RegexCustom.instance; } private set { RegexCustom.instance = value; } }

        public void CheckInput(string pattern,string messError,TextBox textbox,PictureBox pictureBox)
        {
            if (!Regex.IsMatch(textbox.Text, pattern))
            {
                if (textbox.Text==null)
                {
                    return;
                }
                pictureBox.Image = Properties.Resources.error;
                MessageBox.Show(messError, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Select();
            }
            else
            {
                pictureBox.Image = Properties.Resources.checkok;
            }
        }
    }
}
