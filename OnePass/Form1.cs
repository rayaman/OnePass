using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OnePass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atoz_Click(object sender, EventArgs e)
        {
            if(atoz.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                atoz.BackColor = System.Drawing.SystemColors.Highlight;
            } else
            {
                atoz.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void uAtoZ_Click(object sender, EventArgs e)
        {
            if (uAtoZ.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                uAtoZ.BackColor = System.Drawing.SystemColors.Highlight;
            }
            else
            {
                uAtoZ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            if (numbers.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                numbers.BackColor = System.Drawing.SystemColors.Highlight;
            }
            else
            {
                numbers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void special_Click(object sender, EventArgs e)
        {
            if (special.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                special.BackColor = System.Drawing.SystemColors.Highlight;
            }
            else
            {
                special.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        void addSpecial(ref ArrayList list)
        {
            foreach(int c in new int[]{ 33,35,36,37,38,39,40,41,42,43,44,45,46,47,64 })
            {
                list.Add(Char.ConvertFromUtf32(c));
            }
        }
        void addExtended(ref ArrayList list)
        {
            for (int i = 56; i <= 63; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
            for (int i = 91; i <= 96; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
            for (int i = 123; i <= 126; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
        }
        void addNumbers(ref ArrayList list)
        {
            for(int i = 48; i <= 57; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
        }
        void addLower(ref ArrayList list)
        {
            for (int i = 97; i <= 122; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
        }
        void addUpper(ref ArrayList list)
        {
            for (int i = 65; i <= 90; i++)
            {
                list.Add(Char.ConvertFromUtf32(i));
            }
        }
        public string GenerateKey(uint length, ulong seed, ref ArrayList list)
        {
            int to = list.Count;
            Random r = new Random((int)seed + (int)length);

            StringBuilder qs = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                qs.Append(list[r.Next(0,to)]);
            }
            return qs.ToString();
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (sitename.Text == "" || username.Text == "" || masterpass.Text == "")
            {
                MessageBox.Show("Cannot leave a field blank!");
                return;
            }
            ArrayList chars = new ArrayList();
            if (special.BackColor == System.Drawing.SystemColors.Highlight)
                addSpecial(ref chars);
            if (numbers.BackColor == System.Drawing.SystemColors.Highlight)
                addNumbers(ref chars);
            if (atoz.BackColor == System.Drawing.SystemColors.Highlight)
                addLower(ref chars);
            if (uAtoZ.BackColor == System.Drawing.SystemColors.Highlight)
                addUpper(ref chars);
            if (extspc.BackColor == System.Drawing.SystemColors.Highlight)
                addExtended(ref chars);
            if (chars.Count == 0)
            {
                MessageBox.Show("Must have at least one option turned on to generate a password!");
                return;
            }
            byte[] sn_bytes = Encoding.ASCII.GetBytes(sitename.Text);
            byte[] un_bytes = Encoding.ASCII.GetBytes(username.Text);
            byte[] mp_bytes = Encoding.ASCII.GetBytes(masterpass.Text);
            ulong seed = (ulong)passCycle.Value * 0x13AFF5b8;
            byte c = 0;
            uint temp=0;
            foreach(byte b in sn_bytes)
            {
                temp = b;
                seed^= (temp << (c++%16)*4);
            }
            foreach (byte b in un_bytes)
            {
                seed += b;
            }
            foreach (byte b in mp_bytes)
            {
                temp = b;
                seed ^= (temp << (c++ % 8) * 8);
            }
            Clipboard.SetText(GenerateKey((uint)passLength.Value, seed, ref chars));
            Generate.Text = "Copied to Clipboard";
            Generate.Enabled = false;
            this.Update();
            Thread.Sleep(1000);
            Generate.Text = "Generate Password";
            Generate.Enabled = true;
        }

        private void extspc_Click(object sender, EventArgs e)
        {
            if (extspc.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                extspc.BackColor = System.Drawing.SystemColors.Highlight;
            }
            else
            {
                extspc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }
    }
}
