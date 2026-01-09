namespace WinForms_test
{
    partial class SeznamHerForm : Form
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
            SeznamLayoutPanel = new TableLayoutPanel();
            ZpetDoMenuButton = new Button();
            ZobrazeniZaznamuHer = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            hra = new DataGridViewTextBoxColumn();
            zanr = new DataGridViewTextBoxColumn();
            studio = new DataGridViewTextBoxColumn();
            rokVydani = new DataGridViewTextBoxColumn();
            achievementSplnene = new DataGridViewTextBoxColumn();
            achievementCelkem = new DataGridViewTextBoxColumn();

            SeznamLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ZobrazeniZaznamuHer).BeginInit();
            SuspendLayout();
            // 
            // SeznamLayoutPanel
            // 
            SeznamLayoutPanel.BackColor = Color.CadetBlue;
            SeznamLayoutPanel.ColumnCount = 1;
            SeznamLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SeznamLayoutPanel.Controls.Add(ZpetDoMenuButton, 0, 2);
            SeznamLayoutPanel.Controls.Add(ZobrazeniZaznamuHer, 0, 1);
            SeznamLayoutPanel.Dock = DockStyle.Fill;
            SeznamLayoutPanel.Location = new Point(0, 0);
            SeznamLayoutPanel.Name = "SeznamLayoutPanel";
            SeznamLayoutPanel.Padding = new Padding(80, 0, 80, 0);
            SeznamLayoutPanel.RowCount = 4;
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SeznamLayoutPanel.Size = new Size(1165, 618);
            SeznamLayoutPanel.TabIndex = 0;
            // 
            // ZpetDoMenuButton
            // 
            ZpetDoMenuButton.BackColor = Color.Thistle;
            ZpetDoMenuButton.Cursor = Cursors.Hand;
            ZpetDoMenuButton.Dock = DockStyle.Fill;
            ZpetDoMenuButton.FlatStyle = FlatStyle.Flat;
            ZpetDoMenuButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZpetDoMenuButton.Location = new Point(83, 434);
            ZpetDoMenuButton.Name = "ZpetDoMenuButton";
            ZpetDoMenuButton.Size = new Size(999, 117);
            ZpetDoMenuButton.TabIndex = 1;
            ZpetDoMenuButton.Text = "ZPĚT";
            ZpetDoMenuButton.UseVisualStyleBackColor = false;
            ZpetDoMenuButton.Click += ZpetDoMenuButton_Click;
            // 
            // ZobrazeniZaznamuHer
            // 
            ZobrazeniZaznamuHer.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            ZobrazeniZaznamuHer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZobrazeniZaznamuHer.Columns.AddRange(new DataGridViewColumn[] { id, hra, zanr, studio, rokVydani, achievementSplnene, achievementCelkem });
            ZobrazeniZaznamuHer.Dock = DockStyle.Fill;
            ZobrazeniZaznamuHer.Location = new Point(83, 64);
            ZobrazeniZaznamuHer.Name = "ZobrazeniZaznamuHer";
            ZobrazeniZaznamuHer.Size = new Size(999, 364);
            ZobrazeniZaznamuHer.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // hra
            // 
            hra.HeaderText = "Hra";
            hra.Name = "hra";
            // 
            // zanr
            // 
            zanr.HeaderText = "Žánr";
            zanr.Name = "zanr";
            // 
            // studio
            // 
            studio.HeaderText = "Vývojářské studio";
            studio.Name = "studio";
            // 
            // rokVydani
            // 
            rokVydani.HeaderText = "Rok vydání";
            rokVydani.Name = "rokVydani";
            // 
            // achievementSplnene
            // 
            achievementSplnene.HeaderText = "Počet splněných achievementů";
            achievementSplnene.Name = "achievementSplnene";
            //
            // achievementCelkem
            //
            achievementCelkem.HeaderText = "Celkový počet achievementů";
            achievementCelkem.Name = "achievementCelkem";
            // 
            // SeznamHerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 618);
            Controls.Add(SeznamLayoutPanel);
            Name = "SeznamHerForm";
            Text = "SeznamHerForm";
            Load += SeznamHerForm_Load;
            SeznamLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ZobrazeniZaznamuHer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SeznamLayoutPanel;
        private DataGridView ZobrazeniZaznamuHer;
        private Button ZpetDoMenuButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn hra;
        private DataGridViewTextBoxColumn zanr;
        private DataGridViewTextBoxColumn studio;
        private DataGridViewTextBoxColumn rokVydani;
        private DataGridViewTextBoxColumn achievementSplnene;
        private DataGridViewTextBoxColumn achievementCelkem;
    }
}