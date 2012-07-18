using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ENT_Client.WCF;

namespace ENT_Client {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            }

        private void OK_Click(object sender, EventArgs e) {
            ///Test WCF Service
            WCF_client wcf = new WCF_client();
            MessageBox.Show(wcf.name + " " + wcf.count.ToString());
            }
        }
    }
