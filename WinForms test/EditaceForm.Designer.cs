namespace WinForms_test
{
    partial class EditaceForm
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
            EditaceLayoutPanel = new TableLayoutPanel();
            EditButtonLeyout = new TableLayoutPanel();
            SaveGameButton = new Button();
            EditGameButton = new Button();
            AddGameButton = new Button();
            DeleteGameButton = new Button();
            TextBoxFiltrace = new TextBox();
            ZpetButton = new Button();
            ZobrazeniProEditaci = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            hra = new DataGridViewTextBoxColumn();
            zanr = new DataGridViewTextBoxColumn();
            studio = new DataGridViewTextBoxColumn();
            rokVydani = new DataGridViewTextBoxColumn();
            achievementSplnene = new DataGridViewTextBoxColumn();
            achievementCelkem = new DataGridViewTextBoxColumn();
            EditaceLayoutPanel.SuspendLayout();
            EditButtonLeyout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ZobrazeniProEditaci).BeginInit();
            SuspendLayout();
            // 
            // EditaceLayoutPanel
            // 
            EditaceLayoutPanel.BackColor = Color.CadetBlue;
            EditaceLayoutPanel.ColumnCount = 1;
            EditaceLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            EditaceLayoutPanel.Controls.Add(EditButtonLeyout, 0, 1);
            EditaceLayoutPanel.Controls.Add(ZpetButton, 0, 3);
            EditaceLayoutPanel.Controls.Add(ZobrazeniProEditaci, 0, 2);
            EditaceLayoutPanel.Dock = DockStyle.Fill;
            EditaceLayoutPanel.Location = new Point(0, 0);
            EditaceLayoutPanel.Name = "EditaceLayoutPanel";
            EditaceLayoutPanel.Padding = new Padding(80, 0, 80, 0);
            EditaceLayoutPanel.RowCount = 5;
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.Size = new Size(1169, 633);
            EditaceLayoutPanel.TabIndex = 0;
            EditaceLayoutPanel.Paint += TableLayoutPanel1_Paint;
            // 
            // EditButtonLeyout
            // 
            EditButtonLeyout.ColumnCount = 5;
            EditButtonLeyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EditButtonLeyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EditButtonLeyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EditButtonLeyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EditButtonLeyout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EditButtonLeyout.Controls.Add(SaveGameButton, 3, 0);
            EditButtonLeyout.Controls.Add(EditGameButton, 1, 0);
            EditButtonLeyout.Controls.Add(AddGameButton, 0, 0);
            EditButtonLeyout.Controls.Add(DeleteGameButton, 2, 0);
            EditButtonLeyout.Controls.Add(TextBoxFiltrace, 4, 0);
            EditButtonLeyout.Dock = DockStyle.Fill;
            EditButtonLeyout.Location = new Point(83, 66);
            EditButtonLeyout.Name = "EditButtonLeyout";
            EditButtonLeyout.RowCount = 1;
            EditButtonLeyout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            EditButtonLeyout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EditButtonLeyout.Size = new Size(1003, 57);
            EditButtonLeyout.TabIndex = 4;
            // 
            // SaveGameButton
            // 
            SaveGameButton.BackColor = Color.Thistle;
            SaveGameButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveGameButton.Cursor = Cursors.Hand;
            SaveGameButton.Dock = DockStyle.Fill;
            SaveGameButton.FlatStyle = FlatStyle.Flat;
            SaveGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SaveGameButton.Location = new Point(603, 3);
            SaveGameButton.Name = "SaveGameButton";
            SaveGameButton.Size = new Size(194, 51);
            SaveGameButton.TabIndex = 5;
            SaveGameButton.Text = "ULOŽIT ZMĚNY";
            SaveGameButton.UseVisualStyleBackColor = false;
            // 
            // EditGameButton
            // 
            EditGameButton.BackColor = Color.Thistle;
            EditGameButton.Cursor = Cursors.Hand;
            EditGameButton.Dock = DockStyle.Fill;
            EditGameButton.FlatStyle = FlatStyle.Flat;
            EditGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            EditGameButton.Location = new Point(203, 3);
            EditGameButton.Name = "EditGameButton";
            EditGameButton.Size = new Size(194, 51);
            EditGameButton.TabIndex = 2;
            EditGameButton.Text = "UPRAVIT HRU";
            EditGameButton.UseVisualStyleBackColor = false;
            EditGameButton.Click += EditGameButton_Click;
            // 
            // AddGameButton
            // 
            AddGameButton.BackColor = Color.Thistle;
            AddGameButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddGameButton.Cursor = Cursors.Hand;
            AddGameButton.Dock = DockStyle.Fill;
            AddGameButton.FlatStyle = FlatStyle.Flat;
            AddGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddGameButton.Location = new Point(3, 3);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(194, 51);
            AddGameButton.TabIndex = 0;
            AddGameButton.Text = "PŘIDAT HRU";
            AddGameButton.UseVisualStyleBackColor = false;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // DeleteGameButton
            // 
            DeleteGameButton.BackColor = Color.Thistle;
            DeleteGameButton.Cursor = Cursors.Hand;
            DeleteGameButton.Dock = DockStyle.Fill;
            DeleteGameButton.FlatStyle = FlatStyle.Flat;
            DeleteGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeleteGameButton.Location = new Point(403, 3);
            DeleteGameButton.Name = "DeleteGameButton";
            DeleteGameButton.Size = new Size(194, 51);
            DeleteGameButton.TabIndex = 1;
            DeleteGameButton.Text = "ODEBRAT HRU";
            DeleteGameButton.UseVisualStyleBackColor = false;
            DeleteGameButton.Click += DeleteGameButton_Click;
            // 
            // TextBoxFiltrace
            // 
            TextBoxFiltrace.Dock = DockStyle.Bottom;
            TextBoxFiltrace.Location = new Point(803, 31);
            TextBoxFiltrace.Name = "TextBoxFiltrace";
            TextBoxFiltrace.Size = new Size(197, 23);
            TextBoxFiltrace.TabIndex = 6;
            TextBoxFiltrace.Text = "Vyhledat podle názvu";
            TextBoxFiltrace.TextChanged += TextBoxFiltrace_TextChanged;
            // 
            // ZpetButton
            // 
            ZpetButton.BackColor = Color.Thistle;
            ZpetButton.Cursor = Cursors.Hand;
            ZpetButton.Dock = DockStyle.Fill;
            ZpetButton.FlatStyle = FlatStyle.Flat;
            ZpetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZpetButton.Location = new Point(83, 508);
            ZpetButton.Name = "ZpetButton";
            ZpetButton.Size = new Size(1003, 57);
            ZpetButton.TabIndex = 3;
            ZpetButton.Text = "ZPĚT";
            ZpetButton.UseVisualStyleBackColor = false;
            ZpetButton.Click += ZpetButton_Click;
            // 
            // ZobrazeniProEditaci
            // 
            ZobrazeniProEditaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZobrazeniProEditaci.Columns.AddRange(new DataGridViewColumn[] { id, hra, zanr, studio, rokVydani, achievementSplnene, achievementCelkem });
            ZobrazeniProEditaci.Dock = DockStyle.Fill;
            ZobrazeniProEditaci.Location = new Point(83, 129);
            ZobrazeniProEditaci.Name = "ZobrazeniProEditaci";
            ZobrazeniProEditaci.Size = new Size(1003, 373);
            ZobrazeniProEditaci.TabIndex = 5;
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
            achievementSplnene.HeaderText = "Počet Splněných achievementů";
            achievementSplnene.Name = "achievementSplnene";
            // 
            // achievementCelkem
            // 
            achievementCelkem.HeaderText = "Celkový počet achievementů";
            achievementCelkem.Name = "achievementCelkem";
            // 
            // EditaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 633);
            Controls.Add(EditaceLayoutPanel);
            Name = "EditaceForm";
            Text = "EditaceForm";
            Load += EditaceForm_Load;
            EditaceLayoutPanel.ResumeLayout(false);
            EditButtonLeyout.ResumeLayout(false);
            EditButtonLeyout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ZobrazeniProEditaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel EditaceLayoutPanel;
        private Button AddGameButton;
        private Button DeleteGameButton;
        private Button EditGameButton;
        private Button ZpetButton;
        private TableLayoutPanel EditButtonLeyout;
        private Button SaveGameButton;
        private DataGridView ZobrazeniProEditaci;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn hra;
        private DataGridViewTextBoxColumn zanr;
        private DataGridViewTextBoxColumn studio;
        private DataGridViewTextBoxColumn rokVydani;
        private DataGridViewTextBoxColumn achievementSplnene;
        private DataGridViewTextBoxColumn achievementCelkem;
        private TextBox TextBoxFiltrace;
    }
}