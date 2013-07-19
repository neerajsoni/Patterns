namespace EventBrokerPattern
{
    partial class MyControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.Location = new System.Drawing.Point(3, 3);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(144, 79);
            this.buttonTrigger.TabIndex = 0;
            this.buttonTrigger.Text = "button1";
            this.buttonTrigger.UseVisualStyleBackColor = true;
            this.buttonTrigger.Click += new System.EventHandler(this.buttonTrigger_Click);
            // 
            // MyControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTrigger);
            this.Name = "MyControl1";
            this.Size = new System.Drawing.Size(150, 85);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTrigger;
    }
}
