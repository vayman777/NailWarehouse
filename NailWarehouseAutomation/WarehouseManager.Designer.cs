﻿namespace NailWarehouseAutomation
{
    partial class WarehouseManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManager));
            MainText = new Label();
            TopPanel = new Panel();
            NameTextBox = new TextBox();
            RightPanel = new Panel();
            NameLabel = new Label();
            SizeLabel = new Label();
            DiameterLabel = new Label();
            LengthLabel = new Label();
            MaterialComboBox = new ComboBox();
            MaterialLabel = new Label();
            QuantityLabel = new Label();
            PriceExcludingVATLabel = new Label();
            DownPanel = new Panel();
            OkButton = new Button();
            CancelButton = new Button();
            QuantityNnumericUpDown = new NumericUpDown();
            SizePanel = new Panel();
            NamePanel = new Panel();
            errorProvider = new ErrorProvider(components);
            DiameterNumericUpDown = new NumericUpDown();
            LengthNumericUpDown = new NumericUpDown();
            PriceExcludingVATNumericUpDown = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            времяToolStripMenuItem = new ToolStripMenuItem();
            ррпрToolStripMenuItem = new ToolStripMenuItem();
            паорToolStripMenuItem = new ToolStripMenuItem();
            апрапрарToolStripMenuItem = new ToolStripMenuItem();
            папароппмToolStripMenuItem = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiameterNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceExcludingVATNumericUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.AutoSize = true;
            MainText.BackColor = Color.FromArgb(255, 211, 0);
            MainText.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainText.ForeColor = Color.FromArgb(18, 64, 171);
            MainText.Location = new Point(12, 12);
            MainText.Name = "MainText";
            MainText.Size = new Size(547, 50);
            MainText.TabIndex = 0;
            MainText.Text = "Добавление товара на склад\r\n";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(255, 211, 0);
            TopPanel.Controls.Add(MainText);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 24);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(591, 78);
            TopPanel.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(113, 9, 170);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameTextBox.ForeColor = Color.FromArgb(255, 211, 0);
            NameTextBox.Location = new Point(32, 134);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(427, 25);
            NameTextBox.TabIndex = 2;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(18, 64, 171);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(542, 102);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(49, 522);
            RightPanel.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.FromArgb(255, 211, 0);
            NameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.ForeColor = Color.FromArgb(18, 64, 171);
            NameLabel.Location = new Point(32, 106);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(180, 25);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Название гвоздей";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.BackColor = Color.FromArgb(255, 211, 0);
            SizeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            SizeLabel.ForeColor = Color.FromArgb(18, 64, 171);
            SizeLabel.Location = new Point(32, 178);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(159, 25);
            SizeLabel.TabIndex = 6;
            SizeLabel.Text = "Размер гвоздей";
            // 
            // DiameterLabel
            // 
            DiameterLabel.AutoSize = true;
            DiameterLabel.BackColor = Color.FromArgb(18, 64, 171);
            DiameterLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiameterLabel.ForeColor = Color.FromArgb(255, 211, 0);
            DiameterLabel.Location = new Point(32, 210);
            DiameterLabel.Name = "DiameterLabel";
            DiameterLabel.Size = new Size(172, 21);
            DiameterLabel.TabIndex = 8;
            DiameterLabel.Text = "Диаметр гвоздя(мм)";
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.BackColor = Color.FromArgb(18, 64, 171);
            LengthLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LengthLabel.ForeColor = Color.FromArgb(255, 211, 0);
            LengthLabel.Location = new Point(228, 210);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(154, 21);
            LengthLabel.TabIndex = 10;
            LengthLabel.Text = "Длина гвоздя(мм)";
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.BackColor = Color.FromArgb(113, 9, 170);
            MaterialComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            MaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaterialComboBox.FlatStyle = FlatStyle.Flat;
            MaterialComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MaterialComboBox.ForeColor = Color.FromArgb(255, 211, 0);
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Location = new Point(32, 311);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(183, 26);
            MaterialComboBox.TabIndex = 11;
            MaterialComboBox.DrawItem += MaterialComboBox_DrawItem;
            // 
            // MaterialLabel
            // 
            MaterialLabel.AutoSize = true;
            MaterialLabel.BackColor = Color.FromArgb(255, 211, 0);
            MaterialLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MaterialLabel.ForeColor = Color.FromArgb(18, 64, 171);
            MaterialLabel.Location = new Point(32, 279);
            MaterialLabel.Name = "MaterialLabel";
            MaterialLabel.Size = new Size(183, 25);
            MaterialLabel.TabIndex = 12;
            MaterialLabel.Text = "Материал гвоздей";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.BackColor = Color.FromArgb(255, 211, 0);
            QuantityLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuantityLabel.ForeColor = Color.FromArgb(18, 64, 171);
            QuantityLabel.Location = new Point(32, 354);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(200, 25);
            QuantityLabel.TabIndex = 13;
            QuantityLabel.Text = "Количество гвоздей";
            // 
            // PriceExcludingVATLabel
            // 
            PriceExcludingVATLabel.AutoSize = true;
            PriceExcludingVATLabel.BackColor = Color.FromArgb(255, 211, 0);
            PriceExcludingVATLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceExcludingVATLabel.ForeColor = Color.FromArgb(18, 64, 171);
            PriceExcludingVATLabel.Location = new Point(32, 428);
            PriceExcludingVATLabel.Name = "PriceExcludingVATLabel";
            PriceExcludingVATLabel.Size = new Size(342, 25);
            PriceExcludingVATLabel.TabIndex = 15;
            PriceExcludingVATLabel.Text = " Цена одного гвоздя без НДС(Руб.)";
            // 
            // DownPanel
            // 
            DownPanel.BackColor = Color.FromArgb(113, 9, 170);
            DownPanel.Dock = DockStyle.Bottom;
            DownPanel.Location = new Point(0, 575);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(542, 49);
            DownPanel.TabIndex = 17;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.FromArgb(255, 211, 0);
            OkButton.BackgroundImageLayout = ImageLayout.None;
            OkButton.FlatAppearance.BorderColor = Color.FromArgb(18, 64, 171);
            OkButton.FlatAppearance.BorderSize = 2;
            OkButton.FlatAppearance.MouseDownBackColor = Color.White;
            OkButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 211, 0);
            OkButton.FlatStyle = FlatStyle.Flat;
            OkButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OkButton.ForeColor = Color.FromArgb(18, 64, 171);
            OkButton.Location = new Point(32, 516);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(88, 43);
            OkButton.TabIndex = 18;
            OkButton.Text = "OK\r\n";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(255, 211, 0);
            CancelButton.BackgroundImageLayout = ImageLayout.None;
            CancelButton.FlatAppearance.BorderColor = Color.FromArgb(18, 64, 171);
            CancelButton.FlatAppearance.BorderSize = 2;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.White;
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 211, 0);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.FromArgb(18, 64, 171);
            CancelButton.Location = new Point(175, 516);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(92, 43);
            CancelButton.TabIndex = 19;
            CancelButton.Text = " Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // QuantityNnumericUpDown
            // 
            QuantityNnumericUpDown.BackColor = Color.FromArgb(113, 9, 170);
            QuantityNnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuantityNnumericUpDown.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuantityNnumericUpDown.ForeColor = Color.FromArgb(255, 211, 0);
            QuantityNnumericUpDown.Location = new Point(32, 386);
            QuantityNnumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            QuantityNnumericUpDown.Name = "QuantityNnumericUpDown";
            QuantityNnumericUpDown.Size = new Size(200, 25);
            QuantityNnumericUpDown.TabIndex = 20;
            QuantityNnumericUpDown.ThousandsSeparator = true;
            // 
            // SizePanel
            // 
            SizePanel.BackColor = Color.FromArgb(255, 211, 0);
            SizePanel.Location = new Point(32, 178);
            SizePanel.Name = "SizePanel";
            SizePanel.Size = new Size(356, 25);
            SizePanel.TabIndex = 21;
            // 
            // NamePanel
            // 
            NamePanel.BackColor = Color.FromArgb(255, 211, 0);
            NamePanel.Location = new Point(32, 106);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(427, 25);
            NamePanel.TabIndex = 22;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // DiameterNumericUpDown
            // 
            DiameterNumericUpDown.BackColor = Color.FromArgb(113, 9, 170);
            DiameterNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            DiameterNumericUpDown.DecimalPlaces = 2;
            DiameterNumericUpDown.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiameterNumericUpDown.ForeColor = Color.FromArgb(255, 211, 0);
            DiameterNumericUpDown.Location = new Point(32, 236);
            DiameterNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            DiameterNumericUpDown.Name = "DiameterNumericUpDown";
            DiameterNumericUpDown.Size = new Size(172, 25);
            DiameterNumericUpDown.TabIndex = 23;
            DiameterNumericUpDown.ThousandsSeparator = true;
            // 
            // LengthNumericUpDown
            // 
            LengthNumericUpDown.BackColor = Color.FromArgb(113, 9, 170);
            LengthNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            LengthNumericUpDown.DecimalPlaces = 2;
            LengthNumericUpDown.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LengthNumericUpDown.ForeColor = Color.FromArgb(255, 211, 0);
            LengthNumericUpDown.Location = new Point(228, 236);
            LengthNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            LengthNumericUpDown.Name = "LengthNumericUpDown";
            LengthNumericUpDown.Size = new Size(154, 25);
            LengthNumericUpDown.TabIndex = 24;
            LengthNumericUpDown.TextAlign = HorizontalAlignment.Right;
            LengthNumericUpDown.ThousandsSeparator = true;
            // 
            // PriceExcludingVATNumericUpDown
            // 
            PriceExcludingVATNumericUpDown.BackColor = Color.FromArgb(113, 9, 170);
            PriceExcludingVATNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceExcludingVATNumericUpDown.DecimalPlaces = 2;
            PriceExcludingVATNumericUpDown.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceExcludingVATNumericUpDown.ForeColor = Color.FromArgb(255, 211, 0);
            PriceExcludingVATNumericUpDown.Location = new Point(32, 460);
            PriceExcludingVATNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            PriceExcludingVATNumericUpDown.Name = "PriceExcludingVATNumericUpDown";
            PriceExcludingVATNumericUpDown.Size = new Size(342, 25);
            PriceExcludingVATNumericUpDown.TabIndex = 25;
            PriceExcludingVATNumericUpDown.ThousandsSeparator = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { времяToolStripMenuItem, ррпрToolStripMenuItem, паорToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(591, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // времяToolStripMenuItem
            // 
            времяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { апрапрарToolStripMenuItem, папароппмToolStripMenuItem });
            времяToolStripMenuItem.Name = "времяToolStripMenuItem";
            времяToolStripMenuItem.Size = new Size(53, 20);
            времяToolStripMenuItem.Text = "время";
            // 
            // ррпрToolStripMenuItem
            // 
            ррпрToolStripMenuItem.Name = "ррпрToolStripMenuItem";
            ррпрToolStripMenuItem.Size = new Size(47, 20);
            ррпрToolStripMenuItem.Text = "ррпр";
            // 
            // паорToolStripMenuItem
            // 
            паорToolStripMenuItem.Name = "паорToolStripMenuItem";
            паорToolStripMenuItem.Size = new Size(46, 20);
            паорToolStripMenuItem.Text = "паор";
            // 
            // апрапрарToolStripMenuItem
            // 
            апрапрарToolStripMenuItem.Name = "апрапрарToolStripMenuItem";
            апрапрарToolStripMenuItem.Size = new Size(180, 22);
            апрапрарToolStripMenuItem.Text = "апрапрар";
            // 
            // папароппмToolStripMenuItem
            // 
            папароппмToolStripMenuItem.Name = "папароппмToolStripMenuItem";
            папароппмToolStripMenuItem.Size = new Size(180, 22);
            папароппмToolStripMenuItem.Text = "папароппм";
            // 
            // WarehouseManager
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 624);
            Controls.Add(PriceExcludingVATNumericUpDown);
            Controls.Add(LengthNumericUpDown);
            Controls.Add(DiameterNumericUpDown);
            Controls.Add(QuantityNnumericUpDown);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(DownPanel);
            Controls.Add(PriceExcludingVATLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(MaterialLabel);
            Controls.Add(MaterialComboBox);
            Controls.Add(LengthLabel);
            Controls.Add(DiameterLabel);
            Controls.Add(SizeLabel);
            Controls.Add(NameLabel);
            Controls.Add(RightPanel);
            Controls.Add(NameTextBox);
            Controls.Add(TopPanel);
            Controls.Add(SizePanel);
            Controls.Add(NamePanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WarehouseManager";
            Text = "Warehouse Manager";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiameterNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceExcludingVATNumericUpDown).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainText;
        private Panel TopPanel;
        private TextBox NameTextBox;
        private Panel RightPanel;
        private Label NameLabel;
        private Label SizeLabel;
        private Label DiameterLabel;
        private Label LengthLabel;
        private ComboBox MaterialComboBox;
        private Label MaterialLabel;
        private Label QuantityLabel;
        private Label PriceExcludingVATLabel;
        private Panel DownPanel;
        private Button OkButton;
        private Button CancelButton;
        private NumericUpDown QuantityNnumericUpDown;
        private Panel SizePanel;
        private Panel NamePanel;
        private ErrorProvider errorProvider;
        private NumericUpDown DiameterNumericUpDown;
        private NumericUpDown PriceExcludingVATNumericUpDown;
        private NumericUpDown LengthNumericUpDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem времяToolStripMenuItem;
        private ToolStripMenuItem апрапрарToolStripMenuItem;
        private ToolStripMenuItem папароппмToolStripMenuItem;
        private ToolStripMenuItem ррпрToolStripMenuItem;
        private ToolStripMenuItem паорToolStripMenuItem;
    }
}