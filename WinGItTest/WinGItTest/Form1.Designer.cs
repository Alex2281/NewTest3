namespace WinGItTest
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
            this.Alex = new System.Windows.Forms.Button();
            this.Ryan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alex
            // 
            this.Alex.Location = new System.Drawing.Point(39, 56);
            this.Alex.Name = "Alex";
            this.Alex.Size = new System.Drawing.Size(110, 59);
            this.Alex.TabIndex = 0;
            this.Alex.Text = "Alex";
            this.Alex.UseVisualStyleBackColor = true;
            this.Alex.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ryan
            // 
            this.Ryan.Location = new System.Drawing.Point(39, 182);
            this.Ryan.Name = "Ryan";
            this.Ryan.Size = new System.Drawing.Size(110, 59);
            this.Ryan.TabIndex = 1;
            this.Ryan.Text = "Ryan";
            this.Ryan.UseVisualStyleBackColor = true;
            this.Ryan.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Josh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Ryan);
            this.Controls.Add(this.Alex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Alex;
        private System.Windows.Forms.Button Ryan;
        private System.Windows.Forms.Button button3;
    }
}

