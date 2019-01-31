namespace Fangame_Stats
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SelectTextColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectBackgroundColor = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Preview);
            this.groupBox1.Controls.Add(this.SelectBackgroundColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SelectTextColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // SelectTextColor
            // 
            this.SelectTextColor.Location = new System.Drawing.Point(7, 37);
            this.SelectTextColor.Name = "SelectTextColor";
            this.SelectTextColor.Size = new System.Drawing.Size(75, 23);
            this.SelectTextColor.TabIndex = 2;
            this.SelectTextColor.Text = "Select Color";
            this.SelectTextColor.UseVisualStyleBackColor = true;
            this.SelectTextColor.Click += new System.EventHandler(this.SelectTextColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background";
            // 
            // SelectBackgroundColor
            // 
            this.SelectBackgroundColor.Location = new System.Drawing.Point(7, 84);
            this.SelectBackgroundColor.Name = "SelectBackgroundColor";
            this.SelectBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.SelectBackgroundColor.TabIndex = 4;
            this.SelectBackgroundColor.Text = "Select color";
            this.SelectBackgroundColor.UseVisualStyleBackColor = true;
            this.SelectBackgroundColor.Click += new System.EventHandler(this.SelectBackgroundColor_Click);
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(161, 19);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(92, 23);
            this.Preview.TabIndex = 5;
            this.Preview.Text = "Show Preview";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.Button SelectBackgroundColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectTextColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}