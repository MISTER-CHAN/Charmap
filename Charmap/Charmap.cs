using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charmap
{
    public partial class Charmap : Form
    {
        private int first = 0;

        public Charmap()
        {
            InitializeComponent();
            content.SelectedIndex = 0;
            ShowCharacters();
        }

        private void Content_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first < Convert.ToInt32(content.Text.Substring(0, content.Text.IndexOf(' ')), 0x10) ||
                first > Convert.ToInt32(content.Text.Substring(content.Text.LastIndexOf(' ') + 1), 0x10))
            {
                first = Convert.ToInt32(content.Text.Substring(0, content.Text.IndexOf(' ')), 0x10);
                ShowCharacters();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lvCharmap.SelectedItems[0].Text);
        }

        private void Goto_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("轉到");
            if (s == "")
            {
                return;
            }
            if (!new Regex("^[0-9a-f]+$").IsMatch(s))
            {
                s = Unicode.Encode(s)[0];
            }
            first = Convert.ToInt32(s, 16) / 0x100 * 0x100;
            ShowCharacters();
            lvCharmap.Items[Convert.ToInt32(s, 16) % 0x100].Selected = true;
            lvCharmap.Focus();
        }

        private void LvCharmap_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lvCharmap.SelectedItems[0].Text);
        }

        private void LvCharmap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCharmap.SelectedItems.Count > 0)
            {
                status.Text = (first + lvCharmap.SelectedItems[0].Index).ToString("X");
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (first < 0x1000000)
            {
                first += 0x100;
            }
            ShowCharacters();
        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            if (first > 0x0)
            {
                first -= 0x100;
            }
            ShowCharacters();
        }

        private void ShowCharacters()
        {
            lvCharmap.Clear();
            for (int i = first; i < first + 0x100; i++)
            {
                lvCharmap.Items.Add(Unicode.Decode(i));
            }
            if (first < Convert.ToInt32(content.Text.Substring(0, content.Text.IndexOf(' ')), 0x10) ||
                first > Convert.ToInt32(content.Text.Substring(content.Text.LastIndexOf(' ') + 1), 0x10))
            {
                content.Text = (first / 0x1000 * 0x1000).ToString("X") + " ~ " + (first / 0x1000 * 0x1000 + 0xfff).ToString("X");
            }
        }
    }

    class Unicode
    {
        public static string Decode(int unicode)
        {
            string bin = Convert.ToString(unicode, 2);
            List<byte> bytes = new List<byte>();
            if (unicode <= 0x7f)
            {
                bytes.Add(Convert.ToByte("0" + bin.PadLeft(7, '0'), 2));
            }
            else
            {
                byte length = 0;
                if (0x80 <= unicode && unicode <= 0x7ff)
                {
                    length = 2;
                }
                else if (0x800 <= unicode && unicode <= 0xffff)
                {
                    length = 3;
                }
                else if (0x10000 <= unicode && unicode <= 0x1fffff)
                {
                    length = 4;
                }
                else if (0x200000 <= unicode && unicode <= 0x3ffffff)
                {
                    length = 5;
                }
                else if (0x4000000 <= unicode && unicode <= 0x7fffffff)
                {
                    length = 6;
                }
                bin = bin.PadLeft(length * 5 + 1, '0');
                bytes.Add(Convert.ToByte("0".PadLeft(length + 1, '1') + bin.Substring(0, 7 - length), 2));
                bin = bin.Substring(7 - length);
                for (int i = 0; i < length - 1; i++)
                {
                    bytes.Add(Convert.ToByte("10" + bin.Substring(i * 6, 6), 2));
                }
            }
            return string.Join("", Encoding.UTF8.GetChars(bytes.ToArray()));
        }

        public static string[] Encode(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            List<string> unicodes = new List<string>();
            foreach (byte b in bytes)
            {
                string bin = Convert.ToString(b, 2).PadLeft(8, '0');
                if (bin.Substring(0, 1) == "0")
                {
                    unicodes.Add(bin.Substring(1));
                }
                else if (bin.Substring(0, 2) == "10")
                {
                    unicodes[unicodes.ToArray().Length - 1] += bin.Substring(2);
                }
                else
                {
                    unicodes.Add(bin.Substring(bin.IndexOf('0') + 1));
                }
            }
            for (int i = 0; i < unicodes.Count; i++)
            {
                unicodes[i] = Convert.ToInt32(unicodes[i], 2).ToString("X");
            }
            return unicodes.ToArray();
        }
    }
}
