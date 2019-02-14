using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleToolBox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //工具栏按钮与菜单栏的菜单指向同一个工具箱窗体，同时只能存在一个窗体
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var toolBox = frmSingletonToolbox.GetInstance();
            toolBox.MdiParent = this;
            toolBox.Show();
        }

        private void 单例工具箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toolBox = frmSingletonToolbox.GetInstance();
            toolBox.MdiParent = this;
            toolBox.Show();

        }
    }
}
