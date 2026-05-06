using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPicTest : Form
    {
        public frmPicTest()
        {
            InitializeComponent();
        }

        private Image GetImage(string name)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private Image GetImage(int number)
        {
            return GetImage($"pic{number}");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 53);
            picTest.Image = Poker.Properties.Resources.
            ResourceManager.GetObject($"pic{r}")
            as Image;
            lblNum.Text = r.ToString();
        }
    }
}
