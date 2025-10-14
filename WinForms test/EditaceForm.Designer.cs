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
            AddGameButton = new Button();
            DeleteGameButton = new Button();
            EditGameButton = new Button();
            ZpetButton = new Button();
            EditaceLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EditaceLayoutPanel
            // 
            EditaceLayoutPanel.BackColor = Color.CadetBlue;
            EditaceLayoutPanel.ColumnCount = 1;
            EditaceLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            EditaceLayoutPanel.Controls.Add(AddGameButton, 0, 1);
            EditaceLayoutPanel.Controls.Add(DeleteGameButton, 0, 2);
            EditaceLayoutPanel.Controls.Add(EditGameButton, 0, 3);
            EditaceLayoutPanel.Controls.Add(ZpetButton, 0, 4);
            EditaceLayoutPanel.Dock = DockStyle.Fill;
            EditaceLayoutPanel.Location = new Point(0, 0);
            EditaceLayoutPanel.Name = "EditaceLayoutPanel";
            EditaceLayoutPanel.Padding = new Padding(80, 0, 80, 0);
            EditaceLayoutPanel.RowCount = 6;
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditaceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EditaceLayoutPanel.Size = new Size(800, 450);
            EditaceLayoutPanel.TabIndex = 0;
            EditaceLayoutPanel.Paint += TableLayoutPanel1_Paint;
            // 
            // AddGameButton
            // 
            AddGameButton.BackColor = Color.Thistle;
            AddGameButton.Cursor = Cursors.Hand;
            AddGameButton.Dock = DockStyle.Fill;
            AddGameButton.FlatStyle = FlatStyle.Flat;
            AddGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddGameButton.Location = new Point(83, 48);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(634, 84);
            AddGameButton.TabIndex = 0;
            AddGameButton.Text = "PŘIDAT HRU";
            AddGameButton.UseVisualStyleBackColor = false;
            // 
            // DeleteGameButton
            // 
            DeleteGameButton.BackColor = Color.Thistle;
            DeleteGameButton.Cursor = Cursors.Hand;
            DeleteGameButton.Dock = DockStyle.Fill;
            DeleteGameButton.FlatStyle = FlatStyle.Flat;
            DeleteGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeleteGameButton.Location = new Point(83, 138);
            DeleteGameButton.Name = "DeleteGameButton";
            DeleteGameButton.Size = new Size(634, 84);
            DeleteGameButton.TabIndex = 1;
            DeleteGameButton.Text = "ODEBRAT HRU";
            DeleteGameButton.UseVisualStyleBackColor = false;
            // 
            // EditGameButton
            // 
            EditGameButton.BackColor = Color.Thistle;
            EditGameButton.Cursor = Cursors.Hand;
            EditGameButton.Dock = DockStyle.Fill;
            EditGameButton.FlatStyle = FlatStyle.Flat;
            EditGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            EditGameButton.Location = new Point(83, 228);
            EditGameButton.Name = "EditGameButton";
            EditGameButton.Size = new Size(634, 84);
            EditGameButton.TabIndex = 2;
            EditGameButton.Text = "UPRAVIT HRU";
            EditGameButton.UseVisualStyleBackColor = false;
            // 
            // ZpetButton
            // 
            ZpetButton.BackColor = Color.Thistle;
            ZpetButton.Cursor = Cursors.Hand;
            ZpetButton.Dock = DockStyle.Fill;
            ZpetButton.FlatStyle = FlatStyle.Flat;
            ZpetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZpetButton.Location = new Point(83, 318);
            ZpetButton.Name = "ZpetButton";
            ZpetButton.Size = new Size(634, 84);
            ZpetButton.TabIndex = 3;
            ZpetButton.Text = "ZPĚT";
            ZpetButton.UseVisualStyleBackColor = false;
            ZpetButton.Click += ZpetButton_Click;
            // 
            // EditaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditaceLayoutPanel);
            Name = "EditaceForm";
            Text = "EditaceForm";
            Load += EditaceForm_Load;
            EditaceLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel EditaceLayoutPanel;
        private Button AddGameButton;
        private Button DeleteGameButton;
        private Button EditGameButton;
        private Button ZpetButton;
    }
}