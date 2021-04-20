
namespace Könyvkölcsönzés
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
            this.btn_kolcson = new System.Windows.Forms.Button();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.btn_keses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kolcson
            // 
            this.btn_kolcson.Location = new System.Drawing.Point(31, 79);
            this.btn_kolcson.Name = "btn_kolcson";
            this.btn_kolcson.Size = new System.Drawing.Size(142, 37);
            this.btn_kolcson.TabIndex = 0;
            this.btn_kolcson.Text = "Kölcsönzés";
            this.btn_kolcson.UseVisualStyleBackColor = true;
            this.btn_kolcson.Click += new System.EventHandler(this.btn_kolcson_Click);
            // 
            // btn_vissza
            // 
            this.btn_vissza.Location = new System.Drawing.Point(245, 79);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(159, 37);
            this.btn_vissza.TabIndex = 1;
            this.btn_vissza.Text = "Visszavitel";
            this.btn_vissza.UseVisualStyleBackColor = true;
            this.btn_vissza.Click += new System.EventHandler(this.btn_vissza_Click);
            // 
            // btn_keses
            // 
            this.btn_keses.Location = new System.Drawing.Point(465, 79);
            this.btn_keses.Name = "btn_keses";
            this.btn_keses.Size = new System.Drawing.Size(159, 37);
            this.btn_keses.TabIndex = 2;
            this.btn_keses.Text = "késések";
            this.btn_keses.UseVisualStyleBackColor = true;
            this.btn_keses.Click += new System.EventHandler(this.btn_keses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 188);
            this.Controls.Add(this.btn_keses);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.btn_kolcson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Könyvkölcsönzés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kolcson;
        private System.Windows.Forms.Button btn_vissza;
        private System.Windows.Forms.Button btn_keses;
    }
}

