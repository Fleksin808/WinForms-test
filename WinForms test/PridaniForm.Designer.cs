namespace WinForms_test
{
    partial class PridaniForm
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
            LeyoutPridaniZaznamu = new TableLayoutPanel();
            ZpetDoEditace = new Button();
            LeyoutPanelZadaniDat = new TableLayoutPanel();
            PridaniNazevBox = new TextBox();
            PridaniZanrBox = new TextBox();
            PridaniStudioBox = new TextBox();
            PridaniRokNum = new NumericUpDown();
            PridaniSplnenychNum = new NumericUpDown();
            PridaniCelkemNum = new NumericUpDown();
            LabelPridaniNazev = new Label();
            LabelPridaniZanr = new Label();
            LabelPridaniStudio = new Label();
            LabelPridaniRok = new Label();
            LabelPridaniSplnene = new Label();
            LabelPridaniCelkem = new Label();
            LeyoutPridaniZaznamu.SuspendLayout();
            LeyoutPanelZadaniDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PridaniRokNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PridaniSplnenychNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PridaniCelkemNum).BeginInit();
            SuspendLayout();
            // 
            // LeyoutPridaniZaznamu
            // 
            LeyoutPridaniZaznamu.ColumnCount = 1;
            LeyoutPridaniZaznamu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LeyoutPridaniZaznamu.Controls.Add(ZpetDoEditace, 0, 2);
            LeyoutPridaniZaznamu.Controls.Add(LeyoutPanelZadaniDat, 0, 1);
            LeyoutPridaniZaznamu.Dock = DockStyle.Fill;
            LeyoutPridaniZaznamu.Location = new Point(0, 0);
            LeyoutPridaniZaznamu.Name = "LeyoutPridaniZaznamu";
            LeyoutPridaniZaznamu.RowCount = 4;
            LeyoutPridaniZaznamu.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LeyoutPridaniZaznamu.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            LeyoutPridaniZaznamu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeyoutPridaniZaznamu.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LeyoutPridaniZaznamu.Size = new Size(800, 450);
            LeyoutPridaniZaznamu.TabIndex = 5;
            // 
            // ZpetDoEditace
            // 
            ZpetDoEditace.BackColor = Color.Thistle;
            ZpetDoEditace.Cursor = Cursors.Hand;
            ZpetDoEditace.Dock = DockStyle.Fill;
            ZpetDoEditace.FlatStyle = FlatStyle.Flat;
            ZpetDoEditace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZpetDoEditace.Location = new Point(3, 318);
            ZpetDoEditace.Name = "ZpetDoEditace";
            ZpetDoEditace.Size = new Size(794, 84);
            ZpetDoEditace.TabIndex = 5;
            ZpetDoEditace.Text = "ULOŽIT A ZAVŘÍT";
            ZpetDoEditace.UseVisualStyleBackColor = false;
            ZpetDoEditace.Click += ZpetDoEditace_Click;
            // 
            // LeyoutPanelZadaniDat
            // 
            LeyoutPanelZadaniDat.ColumnCount = 2;
            LeyoutPanelZadaniDat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LeyoutPanelZadaniDat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LeyoutPanelZadaniDat.Controls.Add(PridaniNazevBox, 1, 0);
            LeyoutPanelZadaniDat.Controls.Add(PridaniZanrBox, 1, 1);
            LeyoutPanelZadaniDat.Controls.Add(PridaniStudioBox, 1, 2);
            LeyoutPanelZadaniDat.Controls.Add(PridaniRokNum, 1, 3);
            LeyoutPanelZadaniDat.Controls.Add(PridaniSplnenychNum, 1, 4);
            LeyoutPanelZadaniDat.Controls.Add(PridaniCelkemNum, 1, 5);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniNazev, 0, 0);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniZanr, 0, 1);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniStudio, 0, 2);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniRok, 0, 3);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniSplnene, 0, 4);
            LeyoutPanelZadaniDat.Controls.Add(LabelPridaniCelkem, 0, 5);
            LeyoutPanelZadaniDat.Dock = DockStyle.Fill;
            LeyoutPanelZadaniDat.Location = new Point(3, 48);
            LeyoutPanelZadaniDat.Name = "LeyoutPanelZadaniDat";
            LeyoutPanelZadaniDat.RowCount = 6;
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            LeyoutPanelZadaniDat.Size = new Size(794, 264);
            LeyoutPanelZadaniDat.TabIndex = 6;
            // 
            // PridaniNazevBox
            // 
            PridaniNazevBox.Dock = DockStyle.Fill;
            PridaniNazevBox.Location = new Point(400, 3);
            PridaniNazevBox.Name = "PridaniNazevBox";
            PridaniNazevBox.Size = new Size(391, 23);
            PridaniNazevBox.TabIndex = 0;
            // 
            // PridaniZanrBox
            // 
            PridaniZanrBox.Dock = DockStyle.Fill;
            PridaniZanrBox.Location = new Point(400, 47);
            PridaniZanrBox.Name = "PridaniZanrBox";
            PridaniZanrBox.Size = new Size(391, 23);
            PridaniZanrBox.TabIndex = 1;
            // 
            // PridaniStudioBox
            // 
            PridaniStudioBox.Dock = DockStyle.Fill;
            PridaniStudioBox.Location = new Point(400, 91);
            PridaniStudioBox.Name = "PridaniStudioBox";
            PridaniStudioBox.Size = new Size(391, 23);
            PridaniStudioBox.TabIndex = 2;
            // 
            // PridaniRokNum
            // 
            PridaniRokNum.Dock = DockStyle.Fill;
            PridaniRokNum.Location = new Point(400, 135);
            PridaniRokNum.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            PridaniRokNum.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            PridaniRokNum.Name = "PridaniRokNum";
            PridaniRokNum.Size = new Size(391, 23);
            PridaniRokNum.TabIndex = 3;
            PridaniRokNum.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // PridaniSplnenychNum
            // 
            PridaniSplnenychNum.Dock = DockStyle.Fill;
            PridaniSplnenychNum.Location = new Point(400, 179);
            PridaniSplnenychNum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PridaniSplnenychNum.Name = "PridaniSplnenychNum";
            PridaniSplnenychNum.Size = new Size(391, 23);
            PridaniSplnenychNum.TabIndex = 4;
            // 
            // PridaniCelkemNum
            // 
            PridaniCelkemNum.Dock = DockStyle.Fill;
            PridaniCelkemNum.Location = new Point(400, 223);
            PridaniCelkemNum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PridaniCelkemNum.Name = "PridaniCelkemNum";
            PridaniCelkemNum.Size = new Size(391, 23);
            PridaniCelkemNum.TabIndex = 5;
            PridaniCelkemNum.ValueChanged += PridaniCelkemNum_ValueChanged;
            // 
            // LabelPridaniNazev
            // 
            LabelPridaniNazev.AutoSize = true;
            LabelPridaniNazev.Dock = DockStyle.Fill;
            LabelPridaniNazev.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniNazev.ForeColor = SystemColors.ControlText;
            LabelPridaniNazev.Location = new Point(3, 0);
            LabelPridaniNazev.Name = "LabelPridaniNazev";
            LabelPridaniNazev.Size = new Size(391, 44);
            LabelPridaniNazev.TabIndex = 6;
            LabelPridaniNazev.Text = "Název Hry:";
            // 
            // LabelPridaniZanr
            // 
            LabelPridaniZanr.AutoSize = true;
            LabelPridaniZanr.Dock = DockStyle.Fill;
            LabelPridaniZanr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniZanr.Location = new Point(3, 44);
            LabelPridaniZanr.Name = "LabelPridaniZanr";
            LabelPridaniZanr.Size = new Size(391, 44);
            LabelPridaniZanr.TabIndex = 7;
            LabelPridaniZanr.Text = "Žánr:";
            // 
            // LabelPridaniStudio
            // 
            LabelPridaniStudio.AutoSize = true;
            LabelPridaniStudio.Dock = DockStyle.Fill;
            LabelPridaniStudio.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniStudio.Location = new Point(3, 88);
            LabelPridaniStudio.Name = "LabelPridaniStudio";
            LabelPridaniStudio.Size = new Size(391, 44);
            LabelPridaniStudio.TabIndex = 8;
            LabelPridaniStudio.Text = "Název Studia:";
            // 
            // LabelPridaniRok
            // 
            LabelPridaniRok.AutoSize = true;
            LabelPridaniRok.Dock = DockStyle.Fill;
            LabelPridaniRok.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniRok.Location = new Point(3, 132);
            LabelPridaniRok.Name = "LabelPridaniRok";
            LabelPridaniRok.Size = new Size(391, 44);
            LabelPridaniRok.TabIndex = 9;
            LabelPridaniRok.Text = "Rok Vydání:";
            // 
            // LabelPridaniSplnene
            // 
            LabelPridaniSplnene.AutoSize = true;
            LabelPridaniSplnene.Dock = DockStyle.Fill;
            LabelPridaniSplnene.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniSplnene.Location = new Point(3, 176);
            LabelPridaniSplnene.Name = "LabelPridaniSplnene";
            LabelPridaniSplnene.Size = new Size(391, 44);
            LabelPridaniSplnene.TabIndex = 10;
            LabelPridaniSplnene.Text = "Počet Splněných Achievementů:";
            // 
            // LabelPridaniCelkem
            // 
            LabelPridaniCelkem.AutoSize = true;
            LabelPridaniCelkem.Dock = DockStyle.Fill;
            LabelPridaniCelkem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabelPridaniCelkem.Location = new Point(3, 220);
            LabelPridaniCelkem.Name = "LabelPridaniCelkem";
            LabelPridaniCelkem.Size = new Size(391, 44);
            LabelPridaniCelkem.TabIndex = 11;
            LabelPridaniCelkem.Text = "Celkový Počet Achievementů:";
            // 
            // PridaniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LeyoutPridaniZaznamu);
            Name = "PridaniForm";
            Text = "PridaniForm";
            LeyoutPridaniZaznamu.ResumeLayout(false);
            LeyoutPanelZadaniDat.ResumeLayout(false);
            LeyoutPanelZadaniDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PridaniRokNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PridaniSplnenychNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PridaniCelkemNum).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel LeyoutPridaniZaznamu;
        private Button ZpetDoEditace;
        private TableLayoutPanel LeyoutPanelZadaniDat;
        private TextBox PridaniNazevBox;
        private TextBox PridaniZanrBox;
        private TextBox PridaniStudioBox;
        private NumericUpDown PridaniRokNum;
        private NumericUpDown PridaniSplnenychNum;
        private NumericUpDown PridaniCelkemNum;
        private Label LabelPridaniNazev;
        private Label LabelPridaniZanr;
        private Label LabelPridaniStudio;
        private Label LabelPridaniRok;
        private Label LabelPridaniSplnene;
        private Label LabelPridaniCelkem;
    }
}