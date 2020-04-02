using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form_Original : Form
    {
        public Form_Original()
        {
            InitializeComponent();
            pb_Original.Image = CutPicture.Resize(Form1.originalpicpath, 600, 600);

        }
        private void Form_Original_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
