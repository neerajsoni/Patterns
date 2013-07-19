namespace EventBrokerPattern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected MyControl1 myControl1 = null;
        protected MyControl2 myControl2 = null;
        protected MyControl3 myControl3 = null;

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
            this.myControl1 = new EventBrokerPattern.MyControl1();
            this.myControl2 = new EventBrokerPattern.MyControl2();
            this.myControl3 = new EventBrokerPattern.MyControl3();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.Location = new System.Drawing.Point(12, 12);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(152, 86);
            this.myControl1.TabIndex = 0;
            // 
            // myControl2
            // 
            this.myControl2.Location = new System.Drawing.Point(184, 58);
            this.myControl2.Name = "myControl2";
            this.myControl2.Size = new System.Drawing.Size(131, 28);
            this.myControl2.TabIndex = 1;
            // 
            // myControl3
            // 
            this.myControl3.Location = new System.Drawing.Point(184, 24);
            this.myControl3.Name = "myControl3";
            this.myControl3.Size = new System.Drawing.Size(131, 28);
            this.myControl3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 110);
            this.Controls.Add(this.myControl1);
            this.Controls.Add(this.myControl2);
            this.Controls.Add(this.myControl3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

    }
}

