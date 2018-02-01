using Bab_1.GUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbConnection.Text = DBGUIHandler.GetConnectionStatus();
            dbConnection.BackColor = Color.Transparent;

            gameTitleLabel.Text = "BaB";
            gameTitleLabel.BackColor = Color.Transparent;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            DBGUIHandler.LoginDataCorrect("a", "b");
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
