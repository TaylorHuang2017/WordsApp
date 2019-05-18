using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wordapp
{
    public partial class FrmMain : Form
    {
        AccessHelper access = new AccessHelper(); //打开access数据库
        List<string> english = new List<string>(); //存放单词的列表
        List<string> meaning = new List<string>(); //存放释义的列表
        List<bool> newWords = new List<bool>(); // 存放是否为生词的列表
        Random rnd = new Random();
        int idx;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            DataTable dt = access.Get("select * from Grade4");

            foreach (DataRow item in dt.Rows)
            {
                english.Add(item[1].ToString());
                meaning.Add(item[2].ToString());
                newWords.Add(Convert.ToBoolean(item[4]));
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            idx = rnd.Next(english.Count);  // 随机取单词          
            lblEnglish.Visible = true;
            lblEnglish.Text = english[idx];
            lblMeaning.Visible = true;
            lblMeaning.Text = meaning[idx];
            cBoxNew.Checked = newWords[idx];
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Grade4 set unfamiliar = true where vocabulary ='{0}'", english[idx]);
            if (!access.Change(sql)) MessageBox.Show("数据库连接有误！");
        }

        private void btnUnmark_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Grade4 set unfamiliar = false where vocabulary ='{0}'", english[idx]);
            if (!access.Change(sql)) MessageBox.Show("数据库连接有误！");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fname = "生词表" + DateTime.Now.ToString("dd-MM-yy") + ".txt";
            if (File.Exists(fname))
            {
                File.Delete(fname);
            }
            StreamWriter writer = new StreamWriter(fname,true,Encoding.Unicode);
            DataTable dtSc = access.Get("select * from Grade4 where unfamiliar = true");
            foreach (DataRow item in dtSc.Rows)
            {
                writer.WriteLine(string.Format("{0},{1},{2}",item[0],item[1],item[2]));
            }
            writer.Close();
            MessageBox.Show("生词表已经保存");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.access.dbConnection.Close(); //关闭access数据库
        }
    }
}
