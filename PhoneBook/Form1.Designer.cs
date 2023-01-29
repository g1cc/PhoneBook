
namespace PhoneBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Organization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cabinet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExternalPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternalPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.OrganizatrionFilter = new System.Windows.Forms.ComboBox();
            this.orgfFilterLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FIO,
            this.Departament,
            this.Organization,
            this.Position,
            this.Street,
            this.Cabinet,
            this.ExternalPhoneNumber,
            this.InternalPhoneNumber});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 165);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1652, 510);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.Width = 140;
            // 
            // Departament
            // 
            this.Departament.Text = "Отдел";
            this.Departament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Departament.Width = 245;
            // 
            // Organization
            // 
            this.Organization.Text = "Организация";
            this.Organization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Organization.Width = 240;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 90;
            // 
            // Street
            // 
            this.Street.Text = "Адрес";
            this.Street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Street.Width = 160;
            // 
            // Cabinet
            // 
            this.Cabinet.Text = "Кабинет";
            this.Cabinet.Width = 70;
            // 
            // ExternalPhoneNumber
            // 
            this.ExternalPhoneNumber.Text = "Внешний телефон";
            this.ExternalPhoneNumber.Width = 135;
            // 
            // InternalPhoneNumber
            // 
            this.InternalPhoneNumber.Text = "Внутренний телефон";
            this.InternalPhoneNumber.Width = 156;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(695, 129);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 28);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 132);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLabel.Location = new System.Drawing.Point(16, 107);
            this.sortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(110, 20);
            this.sortLabel.TabIndex = 5;
            this.sortLabel.Text = "Сортировка";
            // 
            // OrganizatrionFilter
            // 
            this.OrganizatrionFilter.FormattingEnabled = true;
            this.OrganizatrionFilter.Location = new System.Drawing.Point(884, 129);
            this.OrganizatrionFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrganizatrionFilter.Name = "OrganizatrionFilter";
            this.OrganizatrionFilter.Size = new System.Drawing.Size(469, 24);
            this.OrganizatrionFilter.TabIndex = 6;
            this.OrganizatrionFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // orgfFilterLabel
            // 
            this.orgfFilterLabel.AutoSize = true;
            this.orgfFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgfFilterLabel.Location = new System.Drawing.Point(884, 105);
            this.orgfFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orgfFilterLabel.Name = "orgfFilterLabel";
            this.orgfFilterLabel.Size = new System.Drawing.Size(202, 20);
            this.orgfFilterLabel.TabIndex = 7;
            this.orgfFilterLabel.Text = "Фильтр (Организация)";
            this.orgfFilterLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(1488, 129);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(87, 28);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExportButton.Location = new System.Drawing.Point(1583, 129);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(87, 28);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(300, 107);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 20);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Поиск";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(789, 129);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 28);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(884, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фильтр (Отдел)";
            // 
            // DepartmentFilter
            // 
            this.DepartmentFilter.FormattingEnabled = true;
            this.DepartmentFilter.Location = new System.Drawing.Point(884, 75);
            this.DepartmentFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartmentFilter.Name = "DepartmentFilter";
            this.DepartmentFilter.Size = new System.Drawing.Size(469, 24);
            this.DepartmentFilter.TabIndex = 12;
            this.DepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.DepartmentFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentFilter);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.orgfFilterLabel);
            this.Controls.Add(this.OrganizatrionFilter);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sortLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ColumnHeader Organization;
        private System.Windows.Forms.ComboBox OrganizatrionFilter;
        private System.Windows.Forms.Label orgfFilterLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader Departament;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader Cabinet;
        private System.Windows.Forms.ColumnHeader ExternalPhoneNumber;
        private System.Windows.Forms.ColumnHeader InternalPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepartmentFilter;
    }
}

