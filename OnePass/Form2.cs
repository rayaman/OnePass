using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnePass
{
    public partial class Form2 : Form
    {//
        public string site { get; set; }
        public string login { get; set; }
        public bool opt6 { get; set; }
        public bool opt5 { get; set; }
        public bool opt4 { get; set; }
        public bool opt3 { get; set; }
        public bool opt2 { get; set; }
        public bool opt1 { get; set; }
        public int length { get; set; }
        public int cycle { get; set; }
        public bool state { get; set; }
        public string path { get; }
        List<string> files = new List<string>();
        public Form2()
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OnePassData\\");
            InitializeComponent();
        }
        public void init()
        {
            Logins.Items.Clear();
            files.Clear();
            string[] _files = Directory.GetFiles(path);
            try
            {
                for (int i = 0; i < _files.Length; i++)
                {
                    files.Add(_files[i]);
                    BinaryReader reader = new BinaryReader(File.Open(_files[i], FileMode.Open));
                    site = new string(reader.ReadChars(reader.ReadByte()));
                    login = new string(reader.ReadChars(reader.ReadByte()));
                    Logins.Items.Add(site + ": " + login);
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void close(bool s=true)
        {
            state = s;
            Visible = false;
        }
        private void select_login_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryReader reader = new BinaryReader(File.Open(files[Logins.SelectedIndex],FileMode.Open));

                site = reader.ReadString();
                login = reader.ReadString();
                cycle = reader.ReadInt32();
                length = reader.ReadInt32();
                opt1 = reader.ReadBoolean();
                opt2 = reader.ReadBoolean();
                opt3 = reader.ReadBoolean();
                opt4 = reader.ReadBoolean();
                opt5 = reader.ReadBoolean();
                opt6 = reader.ReadBoolean();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                close(false);
            }
            close(true);
        }
        private void remove_login_Click(object sender, EventArgs e)
        {
            if (Logins.SelectedIndex < 0) return;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove: " + files[Logins.SelectedIndex], "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(files[Logins.SelectedIndex]);
                init();
            }
        }
    }
}
