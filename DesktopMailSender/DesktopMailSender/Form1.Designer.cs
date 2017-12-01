namespace DesktopMailSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMailTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.inptMailTo = new System.Windows.Forms.TextBox();
            this.inptSubject = new System.Windows.Forms.TextBox();
            this.inptBody = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.Location = new System.Drawing.Point(23, 38);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(52, 13);
            this.lblMailTo.TabIndex = 0;
            this.lblMailTo.Text = "Primatelj: ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(23, 75);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Naslov";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(23, 114);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(47, 13);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = "Poruka: ";
            // 
            // inptMailTo
            // 
            this.inptMailTo.Location = new System.Drawing.Point(81, 35);
            this.inptMailTo.Name = "inptMailTo";
            this.inptMailTo.Size = new System.Drawing.Size(259, 20);
            this.inptMailTo.TabIndex = 3;
            // 
            // inptSubject
            // 
            this.inptSubject.Location = new System.Drawing.Point(81, 72);
            this.inptSubject.Name = "inptSubject";
            this.inptSubject.Size = new System.Drawing.Size(259, 20);
            this.inptSubject.TabIndex = 4;
            // 
            // inptBody
            // 
            this.inptBody.Location = new System.Drawing.Point(76, 111);
            this.inptBody.Multiline = true;
            this.inptBody.Name = "inptBody";
            this.inptBody.Size = new System.Drawing.Size(264, 150);
            this.inptBody.TabIndex = 5;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(154, 279);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(90, 31);
            this.btnSendMail.TabIndex = 6;
            this.btnSendMail.Text = "Pošalji";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(387, 337);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.inptBody);
            this.Controls.Add(this.inptSubject);
            this.Controls.Add(this.inptMailTo);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMailTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Desktop Mail Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox inptMailTo;
        private System.Windows.Forms.TextBox inptSubject;
        private System.Windows.Forms.TextBox inptBody;
        private System.Windows.Forms.Button btnSendMail;
    }
}

