
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_str
            // 
            this.textBox_str.Location = new System.Drawing.Point(12, 12);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(171, 278);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Дозаписать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Удалить \"*\"",
            "Заменить \"*\" на \"+\"",
            "Заменить IVT на ISAY"});
            this.comboBox1.Location = new System.Drawing.Point(554, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(732, 267);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(131, 44);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Clean_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 412);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Edit;
    }
}

