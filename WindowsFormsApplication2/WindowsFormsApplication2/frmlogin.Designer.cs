namespace WindowsFormsApplication2
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbpic = new System.Windows.Forms.PictureBox();
            this.txtnimage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnpassword = new System.Windows.Forms.TextBox();
            this.txtnusername = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.testbtn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpic)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.pbpic);
            this.groupBox4.Controls.Add(this.txtnimage);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtnpassword);
            this.groupBox4.Controls.Add(this.txtnusername);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(93, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 399);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Register";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbpic
            // 
            this.pbpic.Location = new System.Drawing.Point(103, 168);
            this.pbpic.Name = "pbpic";
            this.pbpic.Size = new System.Drawing.Size(162, 221);
            this.pbpic.TabIndex = 12;
            this.pbpic.TabStop = false;
            // 
            // txtnimage
            // 
            this.txtnimage.Location = new System.Drawing.Point(103, 135);
            this.txtnimage.Name = "txtnimage";
            this.txtnimage.Size = new System.Drawing.Size(163, 20);
            this.txtnimage.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Image";
            // 
            // txtnpassword
            // 
            this.txtnpassword.Location = new System.Drawing.Point(103, 96);
            this.txtnpassword.Name = "txtnpassword";
            this.txtnpassword.PasswordChar = '*';
            this.txtnpassword.Size = new System.Drawing.Size(163, 20);
            this.txtnpassword.TabIndex = 9;
            // 
            // txtnusername
            // 
            this.txtnusername.Location = new System.Drawing.Point(103, 58);
            this.txtnusername.Name = "txtnusername";
            this.txtnusername.Size = new System.Drawing.Size(163, 20);
            this.txtnusername.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "User name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtpassword);
            this.groupBox3.Controls.Add(this.txtusername);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(93, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 197);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(103, 91);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(163, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(103, 53);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(163, 20);
            this.txtusername.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // testbtn
            // 
            this.testbtn.Location = new System.Drawing.Point(502, 621);
            this.testbtn.Name = "testbtn";
            this.testbtn.Size = new System.Drawing.Size(75, 23);
            this.testbtn.TabIndex = 6;
            this.testbtn.Text = "test";
            this.testbtn.UseVisualStyleBackColor = true;
            this.testbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 644);
            this.Controls.Add(this.testbtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmlogin";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpic)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbpic;
        private System.Windows.Forms.TextBox txtnimage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnpassword;
        private System.Windows.Forms.TextBox txtnusername;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button testbtn;
    }
}

