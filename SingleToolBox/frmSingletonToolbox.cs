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
    public partial class frmSingletonToolbox : Form
    {
        //窗体单例设计
        private static frmSingletonToolbox frm;

        private frmSingletonToolbox()
        {
            InitializeComponent();
        }

        public static frmSingletonToolbox GetInstance()
        {
            //dispose的窗体仍指向释放的内存地址，而不是null
            if (frm == null||frm.IsDisposed)
            {
                frm = new frmSingletonToolbox();
            }
            return frm;
        }
    }
}
