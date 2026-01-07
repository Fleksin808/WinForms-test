namespace WinForms_test
{
    partial class UpravaForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ZpetDoEditace = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            UpravaNazevLabel = new Label();
            UpravaZanrLabel = new Label();
            UpravaStudioLabel = new Label();
            UpravaRokLabel = new Label();
            UpravaSplneneLabel = new Label();
            UpravaCelkemLabel = new Label();
            UpravaNazevBox = new TextBox();
            UpravaZanrBox = new TextBox();
            UpravaStudioBox = new TextBox();
            UpravaRokNum = new NumericUpDown();
            UpravaSplneneNum = new NumericUpDown();
            UpravaCelkemNum = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpravaRokNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpravaSplneneNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpravaCelkemNum).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ZpetDoEditace, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
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
            ZpetDoEditace.TabIndex = 6;
            ZpetDoEditace.Text = "ULOŽIT A ZAVŘÍT";
            ZpetDoEditace.UseVisualStyleBackColor = false;
            ZpetDoEditace.Click += ZpetDoEditace_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(UpravaNazevLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(UpravaZanrLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(UpravaStudioLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(UpravaRokLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(UpravaSplneneLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(UpravaCelkemLabel, 0, 5);
            tableLayoutPanel2.Controls.Add(UpravaNazevBox, 1, 0);
            tableLayoutPanel2.Controls.Add(UpravaZanrBox, 1, 1);
            tableLayoutPanel2.Controls.Add(UpravaStudioBox, 1, 2);
            tableLayoutPanel2.Controls.Add(UpravaRokNum, 1, 3);
            tableLayoutPanel2.Controls.Add(UpravaSplneneNum, 1, 4);
            tableLayoutPanel2.Controls.Add(UpravaCelkemNum, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(794, 264);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // UpravaNazevLabel
            // 
            UpravaNazevLabel.AutoSize = true;
            UpravaNazevLabel.Dock = DockStyle.Fill;
            UpravaNazevLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaNazevLabel.Location = new Point(3, 0);
            UpravaNazevLabel.Name = "UpravaNazevLabel";
            UpravaNazevLabel.Size = new Size(391, 44);
            UpravaNazevLabel.TabIndex = 0;
            UpravaNazevLabel.Text = "Název Hry:";
            // 
            // UpravaZanrLabel
            // 
            UpravaZanrLabel.AutoSize = true;
            UpravaZanrLabel.Dock = DockStyle.Fill;
            UpravaZanrLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaZanrLabel.Location = new Point(3, 44);
            UpravaZanrLabel.Name = "UpravaZanrLabel";
            UpravaZanrLabel.Size = new Size(391, 44);
            UpravaZanrLabel.TabIndex = 1;
            UpravaZanrLabel.Text = "Žánr";
            // 
            // UpravaStudioLabel
            // 
            UpravaStudioLabel.AutoSize = true;
            UpravaStudioLabel.Dock = DockStyle.Fill;
            UpravaStudioLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaStudioLabel.Location = new Point(3, 88);
            UpravaStudioLabel.Name = "UpravaStudioLabel";
            UpravaStudioLabel.Size = new Size(391, 44);
            UpravaStudioLabel.TabIndex = 2;
            UpravaStudioLabel.Text = "Název Studia:";
            // 
            // UpravaRokLabel
            // 
            UpravaRokLabel.AutoSize = true;
            UpravaRokLabel.Dock = DockStyle.Fill;
            UpravaRokLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaRokLabel.Location = new Point(3, 132);
            UpravaRokLabel.Name = "UpravaRokLabel";
            UpravaRokLabel.Size = new Size(391, 44);
            UpravaRokLabel.TabIndex = 3;
            UpravaRokLabel.Text = "Rok Vydání:";
            // 
            // UpravaSplneneLabel
            // 
            UpravaSplneneLabel.AutoSize = true;
            UpravaSplneneLabel.Dock = DockStyle.Fill;
            UpravaSplneneLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaSplneneLabel.Location = new Point(3, 176);
            UpravaSplneneLabel.Name = "UpravaSplneneLabel";
            UpravaSplneneLabel.Size = new Size(391, 44);
            UpravaSplneneLabel.TabIndex = 4;
            UpravaSplneneLabel.Text = "Počet Spněných Achievementů:";
            // 
            // UpravaCelkemLabel
            // 
            UpravaCelkemLabel.AutoSize = true;
            UpravaCelkemLabel.Dock = DockStyle.Fill;
            UpravaCelkemLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            UpravaCelkemLabel.Location = new Point(3, 220);
            UpravaCelkemLabel.Name = "UpravaCelkemLabel";
            UpravaCelkemLabel.Size = new Size(391, 44);
            UpravaCelkemLabel.TabIndex = 5;
            UpravaCelkemLabel.Text = "Celkový Počet Achievementů:";
            // 
            // UpravaNazevBox
            // 
            UpravaNazevBox.Dock = DockStyle.Fill;
            UpravaNazevBox.Location = new Point(400, 3);
            UpravaNazevBox.Name = "UpravaNazevBox";
            UpravaNazevBox.Size = new Size(391, 23);
            UpravaNazevBox.TabIndex = 6;
            // 
            // UpravaZanrBox
            // 
            UpravaZanrBox.Dock = DockStyle.Fill;
            UpravaZanrBox.Location = new Point(400, 47);
            UpravaZanrBox.Name = "UpravaZanrBox";
            UpravaZanrBox.Size = new Size(391, 23);
            UpravaZanrBox.TabIndex = 7;
            // 
            // UpravaStudioBox
            // 
            UpravaStudioBox.Dock = DockStyle.Fill;
            UpravaStudioBox.Location = new Point(400, 91);
            UpravaStudioBox.Name = "UpravaStudioBox";
            UpravaStudioBox.Size = new Size(391, 23);
            UpravaStudioBox.TabIndex = 8;
            // 
            // UpravaRokNum
            // 
            UpravaRokNum.Dock = DockStyle.Fill;
            UpravaRokNum.Location = new Point(400, 135);
            UpravaRokNum.Name = "UpravaRokNum";
            UpravaRokNum.Size = new Size(391, 23);
            UpravaRokNum.TabIndex = 9;
            // 
            // UpravaSplneneNum
            // 
            UpravaSplneneNum.Dock = DockStyle.Fill;
            UpravaSplneneNum.Location = new Point(400, 179);
            UpravaSplneneNum.Name = "UpravaSplneneNum";
            UpravaSplneneNum.Size = new Size(391, 23);
            UpravaSplneneNum.TabIndex = 10;
            // 
            // UpravaCelkemNum
            // 
            UpravaCelkemNum.Dock = DockStyle.Fill;
            UpravaCelkemNum.Location = new Point(400, 223);
            UpravaCelkemNum.Name = "UpravaCelkemNum";
            UpravaCelkemNum.Size = new Size(391, 23);
            UpravaCelkemNum.TabIndex = 11;
            // 
            // UpravaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "UpravaForm";
            Text = "UpravaForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpravaRokNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpravaSplneneNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpravaCelkemNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ZpetDoEditace;
        private TableLayoutPanel tableLayoutPanel2;
        private Label UpravaNazevLabel;
        private Label UpravaZanrLabel;
        private Label UpravaStudioLabel;
        private Label UpravaRokLabel;
        private Label UpravaSplneneLabel;
        private Label UpravaCelkemLabel;
        private TextBox UpravaNazevBox;
        private TextBox UpravaZanrBox;
        private TextBox UpravaStudioBox;
        private NumericUpDown UpravaRokNum;
        private NumericUpDown UpravaSplneneNum;
        private NumericUpDown UpravaCelkemNum;
    }
}