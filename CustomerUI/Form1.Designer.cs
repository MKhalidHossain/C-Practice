
namespace CustomerUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.FlowLayoutPanel();
            this.phoneNoTextBox = new System.Windows.Forms.FlowLayoutPanel();
            this.emailTextBox = new System.Windows.Forms.FlowLayoutPanel();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameValidatorlabel = new System.Windows.Forms.Label();
            this.phoneNoValidatorLabe1 = new System.Windows.Forms.Label();
            this.emailValidatorLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(381, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(124, 29);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Paint += new System.Windows.Forms.PaintEventHandler(this.nameTextBox_Paint);
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(381, 139);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(124, 29);
            this.phoneNoTextBox.TabIndex = 1;
            this.phoneNoTextBox.Paint += new System.Windows.Forms.PaintEventHandler(this.phoneNoTextBox_Paint);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(381, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(124, 29);
            this.emailTextBox.TabIndex = 1;
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(383, 228);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(122, 96);
            this.addressRichTextBox.TabIndex = 2;
            this.addressRichTextBox.Text = "";
            this.addressRichTextBox.TextChanged += new System.EventHandler(this.addressRichTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // nameValidatorlabel
            // 
            this.nameValidatorlabel.AutoSize = true;
            this.nameValidatorlabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidatorlabel.Location = new System.Drawing.Point(516, 114);
            this.nameValidatorlabel.Name = "nameValidatorlabel";
            this.nameValidatorlabel.Size = new System.Drawing.Size(11, 13);
            this.nameValidatorlabel.TabIndex = 8;
            this.nameValidatorlabel.Text = "*";
            this.nameValidatorlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneNoValidatorLabe1
            // 
            this.phoneNoValidatorLabe1.AutoSize = true;
            this.phoneNoValidatorLabe1.ForeColor = System.Drawing.Color.Red;
            this.phoneNoValidatorLabe1.Location = new System.Drawing.Point(516, 155);
            this.phoneNoValidatorLabe1.Name = "phoneNoValidatorLabe1";
            this.phoneNoValidatorLabe1.Size = new System.Drawing.Size(11, 13);
            this.phoneNoValidatorLabe1.TabIndex = 6;
            this.phoneNoValidatorLabe1.Text = "*";
            this.phoneNoValidatorLabe1.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailValidatorLabel1
            // 
            this.emailValidatorLabel1.AutoSize = true;
            this.emailValidatorLabel1.ForeColor = System.Drawing.Color.Red;
            this.emailValidatorLabel1.Location = new System.Drawing.Point(516, 190);
            this.emailValidatorLabel1.Name = "emailValidatorLabel1";
            this.emailValidatorLabel1.Size = new System.Drawing.Size(11, 13);
            this.emailValidatorLabel1.TabIndex = 6;
            this.emailValidatorLabel1.Text = "*";
            this.emailValidatorLabel1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phoneNoValidatorLabe1);
            this.Controls.Add(this.emailValidatorLabel1);
            this.Controls.Add(this.nameValidatorlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressRichTextBox);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel nameTextBox;
        private System.Windows.Forms.FlowLayoutPanel phoneNoTextBox;
        private System.Windows.Forms.FlowLayoutPanel emailTextBox;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nameValidatorlabel;
        private System.Windows.Forms.Label phoneNoValidatorLabe1;
        private System.Windows.Forms.Label emailValidatorLabel1;
    }
}

