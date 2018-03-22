using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManagement
{
    public partial class Form1 : Form
    {
        private static string FilePath = @"D:\0413.Net就业班第二天";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTree(FileTree.Nodes);
        }

        private void FileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void LoadTree(TreeNodeCollection tc)
        {
            string[] dics = Directory.GetDirectories(FilePath);
            for (var i = 0; i < dics.Length;i++)
            {
                string nodeName = Path.GetFileNameWithoutExtension(dics[i]);
                TreeNode tn = new TreeNode(nodeName);
                tc.Add(tn);
            }
        }
    }
}
