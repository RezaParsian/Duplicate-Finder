using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicate_Finder
{

    public partial class Form1 : Form
    {
        List<string> items = new List<string>();
        List<string> duplicate_items = new List<string>();
        List<int> duplicate_index = new List<int>();

        MD5 md5 = MD5.Create();

        string[] files;

        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        string[] FethFiles(string dir)
        {
            return Directory.GetFiles(dir);
        }

        string GetFileMD5(string file_address)
        {
            string result = "";

            using (FileStream stream = File.OpenRead(file_address))
            {
                byte[] checksum = md5.ComputeHash(stream);
                result = BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
            }

            return result;
        }

        void button1_Click(object sender, EventArgs e)
        {
            string dir = @"E:\Phone\Pic";

            files = FethFiles(dir);

            Task.Run(() =>
            {
                foreach (string item in files)
                {
                    items.Add(GetFileMD5(item));
                    lstfiles.Items.Add(item);

                    lstfiles.SelectedIndex = (lstfiles.Items.Count - 1);
                }
            });

            duplicate_items = items.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();

            duplicate_index = items.Select(x => duplicate_items.IndexOf(x)).ToList();

            for (int i = 0; i < duplicate_index.Count; i++)
            {
                if (duplicate_index[i] != -1)
                {
                    lstdup.Items.Add(files[i]);
                }
            }

        }

        void lstfiles_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lstfiles.SelectedItem.ToString());
        }

        void lstdup_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lstdup.SelectedItem.ToString());
        }
    }
}
