namespace WFA2406072
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            pbxBlue = new PictureBox();
            pbxGold = new PictureBox();
            pbxCrimson = new PictureBox();
            pbxGreen = new PictureBox();
            pbxMagenta = new PictureBox();
            pbxSky = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxGold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCrimson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMagenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSky).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(btn, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1105, 356);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn.Location = new Point(113, 56);
            btn.Name = "btn";
            btn.Size = new Size(546, 243);
            btn.TabIndex = 0;
            btn.Text = "Legyen már vége ennek az évnek!";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            btn.MouseEnter += btn_MouseEnter;
            btn.MouseLeave += btn_MouseLeave;
            btn.MouseMove += btn_MouseMove;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pbxBlue, 0, 5);
            tableLayoutPanel2.Controls.Add(pbxGold, 0, 0);
            tableLayoutPanel2.Controls.Add(pbxCrimson, 0, 4);
            tableLayoutPanel2.Controls.Add(pbxGreen, 0, 1);
            tableLayoutPanel2.Controls.Add(pbxMagenta, 0, 3);
            tableLayoutPanel2.Controls.Add(pbxSky, 0, 2);
            tableLayoutPanel2.Location = new Point(775, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(327, 350);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pbxBlue
            // 
            pbxBlue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxBlue.BackColor = Color.MediumBlue;
            pbxBlue.Location = new Point(3, 293);
            pbxBlue.Name = "pbxBlue";
            pbxBlue.Size = new Size(321, 54);
            pbxBlue.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxBlue.TabIndex = 1;
            pbxBlue.TabStop = false;
            // 
            // pbxGold
            // 
            pbxGold.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxGold.BackColor = Color.Gold;
            pbxGold.Location = new Point(3, 3);
            pbxGold.Name = "pbxGold";
            pbxGold.Size = new Size(321, 52);
            pbxGold.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxGold.TabIndex = 1;
            pbxGold.TabStop = false;
            // 
            // pbxCrimson
            // 
            pbxCrimson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxCrimson.BackColor = Color.Crimson;
            pbxCrimson.Location = new Point(3, 235);
            pbxCrimson.Name = "pbxCrimson";
            pbxCrimson.Size = new Size(321, 52);
            pbxCrimson.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxCrimson.TabIndex = 1;
            pbxCrimson.TabStop = false;
            // 
            // pbxGreen
            // 
            pbxGreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxGreen.BackColor = Color.LawnGreen;
            pbxGreen.Location = new Point(3, 61);
            pbxGreen.Name = "pbxGreen";
            pbxGreen.Size = new Size(321, 52);
            pbxGreen.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxGreen.TabIndex = 1;
            pbxGreen.TabStop = false;
            // 
            // pbxMagenta
            // 
            pbxMagenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxMagenta.BackColor = Color.Fuchsia;
            pbxMagenta.Location = new Point(3, 177);
            pbxMagenta.Name = "pbxMagenta";
            pbxMagenta.Size = new Size(321, 52);
            pbxMagenta.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxMagenta.TabIndex = 1;
            pbxMagenta.TabStop = false;
            // 
            // pbxSky
            // 
            pbxSky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxSky.BackColor = Color.SkyBlue;
            pbxSky.Location = new Point(3, 119);
            pbxSky.Name = "pbxSky";
            pbxSky.Size = new Size(321, 52);
            pbxSky.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxSky.TabIndex = 1;
            pbxSky.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 380);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "Gomb események";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxGold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCrimson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMagenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSky).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn;
        private PictureBox pbxGold;
        private PictureBox pbxGreen;
        private PictureBox pbxSky;
        private PictureBox pbxMagenta;
        private PictureBox pbxCrimson;
        private PictureBox pbxBlue;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
