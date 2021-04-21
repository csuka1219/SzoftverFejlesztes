
namespace április_20
{
    partial class MainForm
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
            this.CB_dolgozok = new System.Windows.Forms.ComboBox();
            this.NUD_Penz = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl_atlagfizu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Penz)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_dolgozok
            // 
            this.CB_dolgozok.FormattingEnabled = true;
            this.CB_dolgozok.Location = new System.Drawing.Point(64, 54);
            this.CB_dolgozok.Name = "CB_dolgozok";
            this.CB_dolgozok.Size = new System.Drawing.Size(202, 24);
            this.CB_dolgozok.TabIndex = 0;
            this.CB_dolgozok.SelectedIndexChanged += new System.EventHandler(this.CB_dolgozok_SelectedIndexChanged);
            this.CB_dolgozok.Enter += new System.EventHandler(this.CB_dolgozok_Enter);
            // 
            // NUD_Penz
            // 
            this.NUD_Penz.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Penz.Location = new System.Drawing.Point(320, 54);
            this.NUD_Penz.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.NUD_Penz.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_Penz.Name = "NUD_Penz";
            this.NUD_Penz.Size = new System.Drawing.Size(180, 22);
            this.NUD_Penz.TabIndex = 1;
            this.NUD_Penz.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 308);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dolgozó neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Money:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(457, 131);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 17);
            this.label.TabIndex = 6;
            this.label.Text = "átlagos fizetése";
            // 
            // lbl_atlagfizu
            // 
            this.lbl_atlagfizu.AutoSize = true;
            this.lbl_atlagfizu.Location = new System.Drawing.Point(628, 131);
            this.lbl_atlagfizu.Name = "lbl_atlagfizu";
            this.lbl_atlagfizu.Size = new System.Drawing.Size(16, 17);
            this.lbl_atlagfizu.TabIndex = 7;
            this.lbl_atlagfizu.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.lbl_atlagfizu);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NUD_Penz);
            this.Controls.Add(this.CB_dolgozok);
            this.Name = "MainForm";
            this.Text = "Kifizető-inátor";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Penz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_dolgozok;
        private System.Windows.Forms.NumericUpDown NUD_Penz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_atlagfizu;
    }
}

