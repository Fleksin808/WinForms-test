namespace WinForms_test
{
    partial class MainMenu
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
            StartButton = new Button();
            MenuLayoutPanel = new TableLayoutPanel();
            EditaceButton = new Button();
            ExitButton = new Button();
            MenuLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.AutoSize = true;
            StartButton.BackColor = Color.Thistle;
            StartButton.Cursor = Cursors.Hand;
            StartButton.Dock = DockStyle.Fill;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StartButton.Location = new Point(83, 81);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(848, 150);
            StartButton.TabIndex = 0;
            StartButton.Text = "SEZNAM";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // MenuLayoutPanel
            // 
            MenuLayoutPanel.BackColor = Color.CadetBlue;
            MenuLayoutPanel.ColumnCount = 1;
            MenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MenuLayoutPanel.Controls.Add(StartButton, 0, 1);
            MenuLayoutPanel.Controls.Add(EditaceButton, 0, 2);
            MenuLayoutPanel.Controls.Add(ExitButton, 0, 3);
            MenuLayoutPanel.Dock = DockStyle.Fill;
            MenuLayoutPanel.Location = new Point(0, 0);
            MenuLayoutPanel.Name = "MenuLayoutPanel";
            MenuLayoutPanel.Padding = new Padding(80, 0, 80, 0);
            MenuLayoutPanel.RowCount = 5;
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            MenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuLayoutPanel.Size = new Size(1014, 625);
            MenuLayoutPanel.TabIndex = 1;           
            // 
            // EditaceButton
            // 
            EditaceButton.BackColor = Color.Thistle;
            EditaceButton.Cursor = Cursors.Hand;
            EditaceButton.Dock = DockStyle.Fill;
            EditaceButton.FlatStyle = FlatStyle.Flat;
            EditaceButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            EditaceButton.Location = new Point(83, 237);
            EditaceButton.Name = "EditaceButton";
            EditaceButton.Size = new Size(848, 150);
            EditaceButton.TabIndex = 1;
            EditaceButton.Text = "EDITACE";
            EditaceButton.UseVisualStyleBackColor = false;
            EditaceButton.Click += EditaceButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Thistle;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ExitButton.Location = new Point(83, 393);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(848, 150);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "ODEJÍT";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1014, 625);
            Controls.Add(MenuLayoutPanel);
            Name = "MainMenu";
            Text = "Parek";
            MenuLayoutPanel.ResumeLayout(false);
            MenuLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private TableLayoutPanel MenuLayoutPanel;
        private Button EditaceButton;
        private Button ExitButton;
    }
}
