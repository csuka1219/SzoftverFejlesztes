
namespace Könyvkölcsönzés
{
    partial class kesesek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kesesek));
            this.cb_kesok = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cb_kesok
            // 
            this.cb_kesok.FormattingEnabled = true;
            this.cb_kesok.Location = new System.Drawing.Point(66, 59);
            this.cb_kesok.Name = "cb_kesok";
            this.cb_kesok.Size = new System.Drawing.Size(448, 24);
            this.cb_kesok.TabIndex = 0;
            this.cb_kesok.SelectedIndexChanged += new System.EventHandler(this.cb_kesok_SelectedIndexChanged);
            this.cb_kesok.Enter += new System.EventHandler(this.cb_kesok_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(66, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 388);
            this.listBox1.TabIndex = 1;
            // 
            // kesesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 543);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb_kesok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kesesek";
            this.Text = "Harminc napnál régebben kölcsönözve";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_kesok;
        private System.Windows.Forms.ListBox listBox1;
    }
}