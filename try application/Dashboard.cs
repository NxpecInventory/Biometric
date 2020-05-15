using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace try_application
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Main.Controls.Add(DashboardUserControl);
        }
        DashboardUserControl DashboardUserControl = new DashboardUserControl();
        RegisterPrints RegisterPrints = new RegisterPrints();
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(DashboardUserControl);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Main.Controls.Add(RegisterPrints);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            Main.Controls.Clear();
            Main.Controls.Add(attendence);
        }
    }
}
