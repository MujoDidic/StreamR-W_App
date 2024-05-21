namespace StreamR_W_App
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
            this.Speichern = new System.Windows.Forms.Button();
            this.Laden = new System.Windows.Forms.Button();
            this.Einfuegen = new System.Windows.Forms.Button();
            this.EintragTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(254, 24);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(121, 30);
            this.Speichern.TabIndex = 0;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // Laden
            // 
            this.Laden.Location = new System.Drawing.Point(254, 73);
            this.Laden.Name = "Laden";
            this.Laden.Size = new System.Drawing.Size(121, 30);
            this.Laden.TabIndex = 1;
            this.Laden.Text = "Laden";
            this.Laden.UseVisualStyleBackColor = true;
            this.Laden.Click += new System.EventHandler(this.Laden_Click);
            // 
            // Einfuegen
            // 
            this.Einfuegen.Location = new System.Drawing.Point(254, 325);
            this.Einfuegen.Name = "Einfuegen";
            this.Einfuegen.Size = new System.Drawing.Size(116, 30);
            this.Einfuegen.TabIndex = 2;
            this.Einfuegen.Text = "Einfügen";
            this.Einfuegen.UseVisualStyleBackColor = true;
            this.Einfuegen.Click += new System.EventHandler(this.Einfuegen_Click);
            // 
            // EintragTextBox
            // 
            this.EintragTextBox.Location = new System.Drawing.Point(254, 288);
            this.EintragTextBox.Name = "EintragTextBox";
            this.EintragTextBox.Size = new System.Drawing.Size(115, 20);
            this.EintragTextBox.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 316);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 367);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EintragTextBox);
            this.Controls.Add(this.Einfuegen);
            this.Controls.Add(this.Laden);
            this.Controls.Add(this.Speichern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.Button Laden;
        private System.Windows.Forms.Button Einfuegen;
        private System.Windows.Forms.TextBox EintragTextBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

