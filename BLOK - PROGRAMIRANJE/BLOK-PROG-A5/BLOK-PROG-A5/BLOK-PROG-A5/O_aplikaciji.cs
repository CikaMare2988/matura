using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOK_PROG_A5
{
    public partial class O_aplikaciji : Form
    {
        public O_aplikaciji()
        {
            InitializeComponent();
        }

        private void O_aplikaciji_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Users\User\Desktop\BLOK-PROG-A5\BLOK-PROG-A5\A5Uputstvo.rtf");
        }
    }
}
