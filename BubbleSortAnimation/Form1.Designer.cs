namespace BubbleSortAnimation
{
    partial class Form1
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
            lstSayilar = new ListBox();
            btnDoldur = new Button();
            nudAdet = new NumericUpDown();
            btnSirala = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // lstSayilar
            // 
            lstSayilar.FormattingEnabled = true;
            lstSayilar.ItemHeight = 15;
            lstSayilar.Location = new Point(84, 42);
            lstSayilar.Name = "lstSayilar";
            lstSayilar.Size = new Size(215, 349);
            lstSayilar.TabIndex = 0;
            // 
            // btnDoldur
            // 
            btnDoldur.Location = new Point(135, 12);
            btnDoldur.Name = "btnDoldur";
            btnDoldur.Size = new Size(164, 23);
            btnDoldur.TabIndex = 1;
            btnDoldur.Text = "Rastgele Sayilarla Doldur";
            btnDoldur.UseVisualStyleBackColor = true;
            btnDoldur.Click += btnDoldur_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(84, 12);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(45, 23);
            nudAdet.TabIndex = 2;
            nudAdet.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnSirala
            // 
            btnSirala.Location = new Point(305, 12);
            btnSirala.Name = "btnSirala";
            btnSirala.Size = new Size(146, 23);
            btnSirala.TabIndex = 3;
            btnSirala.Text = "button1";
            btnSirala.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(356, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSirala);
            Controls.Add(nudAdet);
            Controls.Add(btnDoldur);
            Controls.Add(lstSayilar);
            Name = "Form1";
            Text = "Bubble Sort Animasyonu";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSayilar;
        private Button btnDoldur;
        private NumericUpDown nudAdet;
        private Button btnSirala;
        private Button button1;
    }
}