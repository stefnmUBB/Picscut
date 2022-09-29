using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picscut
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PicsList.Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            for (int k = 1; k < 20; k++)
            {
                PicsList.AddPicture($@"C:\Users\Stefan\Pictures\Screenshots\Screenshot ({k}).png");
            }
            //PicsList.Refresh();
        }
    }
}
