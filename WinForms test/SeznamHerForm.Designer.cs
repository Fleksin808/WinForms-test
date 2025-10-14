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
            dataGridView1 = new DataGridView();
            SeznamLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SeznamLayoutPanel
            // 
            SeznamLayoutPanel.BackColor = Color.CadetBlue;
            SeznamLayoutPanel.ColumnCount = 1;
            SeznamLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SeznamLayoutPanel.Controls.Add(ZpetDoMenuButton, 0, 2);
            SeznamLayoutPanel.Controls.Add(dataGridView1, 0, 1);
            SeznamLayoutPanel.Dock = DockStyle.Fill;
            SeznamLayoutPanel.Location = new Point(0, 0);
            SeznamLayoutPanel.Name = "SeznamLayoutPanel";
            SeznamLayoutPanel.Padding = new Padding(80, 0, 80, 0);
            SeznamLayoutPanel.RowCount = 4;
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SeznamLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SeznamLayoutPanel.Size = new Size(800, 450);
            SeznamLayoutPanel.TabIndex = 0;
            // 
            // ZpetDoMenuButton
            // 
            ZpetDoMenuButton.BackColor = Color.Thistle;
            ZpetDoMenuButton.Cursor = Cursors.Hand;
            ZpetDoMenuButton.Dock = DockStyle.Fill;
            ZpetDoMenuButton.FlatStyle = FlatStyle.Flat;
            ZpetDoMenuButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ZpetDoMenuButton.Location = new Point(83, 318);
            ZpetDoMenuButton.Name = "ZpetDoMenuButton";
            ZpetDoMenuButton.Size = new Size(634, 84);
            ZpetDoMenuButton.TabIndex = 1;
            ZpetDoMenuButton.Text = "ZPĚT";
            ZpetDoMenuButton.UseVisualStyleBackColor = false;
            ZpetDoMenuButton.Click += ZpetDoMenuButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(83, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 264);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SeznamHerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SeznamLayoutPanel);
            Name = "SeznamHerForm";
            Text = "SeznamHerForm";
            SeznamLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SeznamLayoutPanel;
        private DataGridView dataGridView1;
        private Button ZpetDoMenuButton;
    }
}