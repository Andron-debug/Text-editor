
namespace Text_editor
{
    partial class Clean_up
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_str = new System.Windows.Forms.TextBox();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_str
            // 
            this.textBox_str.Location = new System.Drawing.Point(38, 12);
            this.textBox_str.Name = "textBox_str";
            this.textBox_str.Size = new System.Drawing.Size(1008, 27);
            this.textBox_str.TabIndex = 1;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(38, 275);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(94, 29);
            this.Clean.TabIndex = 2;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clean_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 412);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.textBox_str);
            this.Name = "Clean_up";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_str;
        private System.Windows.Forms.Button Clean;
    }
}

