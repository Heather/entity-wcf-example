namespace ENT_Client {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OK = new System.Windows.Forms.Button();
            this.MainGreed = new System.Windows.Forms.DataGridView();
            this.ParamBox = new System.Windows.Forms.GroupBox();
            this.Date_Start = new System.Windows.Forms.DateTimePicker();
            this.Date_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Shop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Period_Week = new System.Windows.Forms.RadioButton();
            this.Period_Month = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainGreed)).BeginInit();
            this.ParamBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(596, 404);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(79, 21);
            this.OK.TabIndex = 0;
            this.OK.Text = "Just do it";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // MainGreed
            // 
            this.MainGreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGreed.Location = new System.Drawing.Point(12, 174);
            this.MainGreed.Name = "MainGreed";
            this.MainGreed.Size = new System.Drawing.Size(578, 251);
            this.MainGreed.TabIndex = 1;
            // 
            // ParamBox
            // 
            this.ParamBox.Controls.Add(this.groupBox1);
            this.ParamBox.Controls.Add(this.label3);
            this.ParamBox.Controls.Add(this.Shop);
            this.ParamBox.Controls.Add(this.label2);
            this.ParamBox.Controls.Add(this.label1);
            this.ParamBox.Controls.Add(this.Date_End);
            this.ParamBox.Controls.Add(this.Date_Start);
            this.ParamBox.Location = new System.Drawing.Point(12, 12);
            this.ParamBox.Name = "ParamBox";
            this.ParamBox.Size = new System.Drawing.Size(663, 156);
            this.ParamBox.TabIndex = 2;
            this.ParamBox.TabStop = false;
            this.ParamBox.Text = "Input Data";
            // 
            // Date_Start
            // 
            this.Date_Start.Location = new System.Drawing.Point(107, 19);
            this.Date_Start.Name = "Date_Start";
            this.Date_Start.Size = new System.Drawing.Size(200, 20);
            this.Date_Start.TabIndex = 0;
            // 
            // Date_End
            // 
            this.Date_End.Location = new System.Drawing.Point(457, 19);
            this.Date_End.Name = "Date_End";
            this.Date_End.Size = new System.Drawing.Size(200, 20);
            this.Date_End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date:";
            // 
            // Shop
            // 
            this.Shop.FormattingEnabled = true;
            this.Shop.Location = new System.Drawing.Point(107, 95);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(200, 21);
            this.Shop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shop :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Period_Month);
            this.groupBox1.Controls.Add(this.Period_Week);
            this.groupBox1.Location = new System.Drawing.Point(369, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period Box";
            // 
            // Period_Week
            // 
            this.Period_Week.AutoSize = true;
            this.Period_Week.Location = new System.Drawing.Point(88, 19);
            this.Period_Week.Name = "Period_Week";
            this.Period_Week.Size = new System.Drawing.Size(105, 17);
            this.Period_Week.TabIndex = 0;
            this.Period_Week.TabStop = true;
            this.Period_Week.Text = "Use week period";
            this.Period_Week.UseVisualStyleBackColor = true;
            // 
            // Period_Month
            // 
            this.Period_Month.AutoSize = true;
            this.Period_Month.Location = new System.Drawing.Point(88, 42);
            this.Period_Month.Name = "Period_Month";
            this.Period_Month.Size = new System.Drawing.Size(108, 17);
            this.Period_Month.TabIndex = 1;
            this.Period_Month.TabStop = true;
            this.Period_Month.Text = "Use month period";
            this.Period_Month.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 437);
            this.Controls.Add(this.ParamBox);
            this.Controls.Add(this.MainGreed);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainGreed)).EndInit();
            this.ParamBox.ResumeLayout(false);
            this.ParamBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridView MainGreed;
        private System.Windows.Forms.GroupBox ParamBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date_End;
        private System.Windows.Forms.DateTimePicker Date_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Shop;
        private System.Windows.Forms.RadioButton Period_Month;
        private System.Windows.Forms.RadioButton Period_Week;
        }
    }

