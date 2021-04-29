using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OnePass
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        public Form1()
        {
            Directory.CreateDirectory(form2.path);
            InitializeComponent();
        }



        string vowels = "aaaaaeeeeeeeiiiiiooooouuu";
        string consonants = "bbcccdddfffgghhhhjklllmmmnnnnnpprrrrrsssssttttttvwwxyyz";

        string[] vowelafter = { "th", "ch", "sh", "qu" };
        string[] consonantafter = { "oo", "ee" };

        public string GeneratePassword(int length, int seed)
        {
            Random rnd = new Random(seed);
            string pass = "";
            bool isvowel = false;

            for (int i = 0; i < length; i++)
            {
                if (isvowel)
                {
                    if (rnd.Next(0, 5) == 0 && i < (length - 1))
                    {
                        pass += consonantafter[rnd.Next(0, consonantafter.Length)];
                    }
                    else
                    {
                        pass += vowels.Substring(rnd.Next(0, vowels.Length), 1);
                    }
                }
                else
                {
                    if (rnd.Next(0, 5) == 0 && i < (length - 1))
                    {
                        pass += vowelafter[rnd.Next(0, vowelafter.Length)];
                    }
                    else
                    {
                        pass += consonants.Substring(rnd.Next(0, consonants.Length), 1);
                    }
                }
                isvowel = !isvowel;
            }
            return pass;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = SystemColors.Highlight;
            atoz.BackColor = SystemColors.InactiveCaption;
            uAtoZ.BackColor = SystemColors.InactiveCaption;
            numbers.BackColor = SystemColors.InactiveCaption;
            special.BackColor = SystemColors.InactiveCaption;
            extspc.BackColor = SystemColors.InactiveCaption;
        }
        private void atoz_Click(object sender, EventArgs e)
        {
            label7.BackColor = SystemColors.InactiveCaption;
            if (atoz.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                atoz.BackColor = System.Drawing.SystemColors.Highlight;
            } else
            {
                atoz.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void uAtoZ_Click(object sender, EventArgs e)
        {
            label7.BackColor = SystemColors.InactiveCaption;
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
            label7.BackColor = SystemColors.InactiveCaption;
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
            label7.BackColor = SystemColors.InactiveCaption;
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
            foreach (int c in new int[] { 33, 35, 36, 37, 38, 40, 41, 42, 43, 44, 45, 64 })
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
            if(label7.BackColor == SystemColors.Highlight)
            {
                chars.Add('A');
            }
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
            try
            {
                if (label7.BackColor == SystemColors.Highlight)
                    Clipboard.SetText(GeneratePassword((int)passLength.Value, (int)seed));
                else
                    Clipboard.SetText(GenerateKey((uint)passLength.Value, seed, ref chars));
            } catch
            {
                MessageBox.Show("Attempt to capture clipboard data over the network! (Are you using remote desktop w/clipboard)");
            }
            masterpass.Text = "";
            Generate.Text = "Copied to Clipboard";
            Generate.Enabled = false;
            this.Update();
            Thread.Sleep(7000);
            Generate.Text = "Generate Password";
            Generate.Enabled = true;
            Clipboard.Clear();
        }

        private void extspc_Click(object sender, EventArgs e)
        {
            label7.BackColor = SystemColors.InactiveCaption;
            if (extspc.BackColor == System.Drawing.SystemColors.InactiveCaption)
            {
                extspc.BackColor = System.Drawing.SystemColors.Highlight;
            }
            else
            {
                extspc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When a password is generated the password will live on your clipboard for 7 seconds (paste it quick). Then your master password and the clipboard is also cleared out! Make sure nothing important is on the clipboard!","Help!");
        }
        private string MakeValidFileName(string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return form2.path + "\\" + System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
        }
        private void load_login_Click(object sender, EventArgs e)
        {
            form2.init();
            this.Enabled = false;
            form2.ShowDialog(this);
            this.Enabled = true;
            if (form2.state == true)
            {
                sitename.Text = form2.site;
                username.Text = form2.login;
                passCycle.Value = (decimal)form2.cycle;
                passLength.Value = (decimal)form2.length;
                special.BackColor = (form2.opt1) ? SystemColors.Highlight : SystemColors.InactiveCaption;
                numbers.BackColor = (form2.opt2) ? SystemColors.Highlight : SystemColors.InactiveCaption;
                atoz.BackColor = (form2.opt3) ? SystemColors.Highlight : SystemColors.InactiveCaption;
                uAtoZ.BackColor = (form2.opt4) ? SystemColors.Highlight : SystemColors.InactiveCaption;
                extspc.BackColor = (form2.opt5) ? SystemColors.Highlight : SystemColors.InactiveCaption;
                label7.BackColor = (form2.opt6) ? SystemColors.Highlight : SystemColors.InactiveCaption;
            }
        }

        private void save_login_Click(object sender, EventArgs e)
        {
            if(sitename.Text=="" || username.Text == "")
            {
                MessageBox.Show("Cannot save data if fields are incomplete!");
                return;
            }
            try
            {
                BinaryWriter writer = new BinaryWriter(File.Open(MakeValidFileName(sitename.Text + username.Text), FileMode.Create));
                writer.Write(sitename.Text);
                writer.Write(username.Text);
                writer.Write((int)passCycle.Value);
                writer.Write((int)passLength.Value);
                writer.Write(special.BackColor == SystemColors.Highlight);
                writer.Write(numbers.BackColor == SystemColors.Highlight);
                writer.Write(atoz.BackColor == SystemColors.Highlight);
                writer.Write(uAtoZ.BackColor == SystemColors.Highlight);
                writer.Write(extspc.BackColor == SystemColors.Highlight);
                writer.Write(label7.BackColor == SystemColors.Highlight);
                writer.Flush();
                writer.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
