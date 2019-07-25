using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialKey
{
    public partial class Form1 : Form
    {
        private object txtPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SKGL.Validate validate = new SKGL.Validate();
            validate.secretPhase = txtPassword.Text;
            validate.Key = txtSerial.Text;
            txtsStatus.Text"Creation date: " + validate.CreationDate + "\r\n" + "Expire date: " + validate.ExpireDate + "\r\n" + "Day left: " + validate.DaysLeft;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            SKGL.Generate generate = new SKGL.Generate();
            generate.secretPhase = txtPassword.Text;
            txtSerial.Text = generate.doKey(Convert.ToInt32(txtDay.Text));
        }
    }
}
