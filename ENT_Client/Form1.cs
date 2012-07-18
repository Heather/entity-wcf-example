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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            }

        private void OK_Click(object sender, EventArgs e) {
            ///Test WCF Service
            WCF_client wcf = new WCF_client();
            }
        }
    }
