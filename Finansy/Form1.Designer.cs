namespace Finansy
{
    partial class Form1
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
            TabPage tabPage2;
            pictureBox2 = new PictureBox();
            comboBox2 = new ComboBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            but_subtr = new Button();
            maskedTextBox2 = new MaskedTextBox();
            label8 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            but_add = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            bank_account = new Button();
            tabPage2 = new TabPage();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 192, 255);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(but_subtr);
            tabPage2.Controls.Add(maskedTextBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Font = new Font("Segoe Script", 18F, FontStyle.Underline, GraphicsUnit.Point, 204);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.RightToLeft = RightToLeft.Yes;
            tabPage2.Size = new Size(792, 369);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.image;
            pictureBox2.Location = new Point(725, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 47);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Здоровье", "Досуг", "Дом", "Кафе и рестораны", "Образование", "Такси и транспорт", "Платежи", "Не запланированные", "Другое" });
            comboBox2.Location = new Point(16, 173);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 29);
            comboBox2.TabIndex = 19;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.Location = new Point(299, 54);
            listView2.Name = "listView2";
            listView2.Size = new Size(477, 299);
            listView2.TabIndex = 18;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Категория расходов";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Сумма дохода";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Комментарий";
            columnHeader6.Width = 155;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(213, 38);
            label2.TabIndex = 17;
            label2.Text = "Комментарий";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(16, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 29);
            textBox2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 19);
            label6.Name = "label6";
            label6.Size = new Size(238, 38);
            label6.TabIndex = 15;
            label6.Text = "Сумма расходов";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 134);
            label7.Name = "label7";
            label7.Size = new Size(272, 36);
            label7.TabIndex = 13;
            label7.Text = "Категория расходов";
            // 
            // but_subtr
            // 
            but_subtr.BackColor = Color.FromArgb(128, 128, 255);
            but_subtr.Font = new Font("Segoe Script", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            but_subtr.Location = new Point(75, 322);
            but_subtr.Name = "but_subtr";
            but_subtr.Size = new Size(85, 31);
            but_subtr.TabIndex = 12;
            but_subtr.Text = "Добавить";
            but_subtr.UseVisualStyleBackColor = false;
            but_subtr.Click += but_subtr_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 12F);
            maskedTextBox2.Location = new Point(19, 65);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(210, 29);
            maskedTextBox2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(439, 19);
            label8.Name = "label8";
            label8.Size = new Size(235, 38);
            label8.TabIndex = 10;
            label8.Text = "Список расходов";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(0, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 401);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(but_add);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 18F);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(792, 369);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.изображение_2024_04_15_193153305;
            pictureBox1.Location = new Point(733, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 44);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView1.Location = new Point(307, 50);
            listView1.Name = "listView1";
            listView1.Size = new Size(477, 299);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Категория дохода";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Сумма дохода";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Комментарий";
            columnHeader3.Width = 155;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(213, 38);
            label5.TabIndex = 8;
            label5.Text = "Комментарий";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(24, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 29);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(210, 38);
            label4.TabIndex = 6;
            label4.Text = "Сумма дохода";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зарплата", "Подарок", "Проценты по вкладам", "Другое" });
            comboBox1.Location = new Point(24, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 29);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 119);
            label3.Name = "label3";
            label3.Size = new Size(255, 38);
            label3.TabIndex = 4;
            label3.Text = "Категория дохода";
            // 
            // but_add
            // 
            but_add.BackColor = Color.FromArgb(128, 128, 255);
            but_add.Font = new Font("Segoe Script", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            but_add.Location = new Point(83, 318);
            but_add.Name = "but_add";
            but_add.Size = new Size(85, 31);
            but_add.TabIndex = 3;
            but_add.Text = "Добавить";
            but_add.UseVisualStyleBackColor = false;
            but_add.Click += but_add_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F);
            maskedTextBox1.Location = new Point(24, 60);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(210, 29);
            maskedTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(443, 15);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 1;
            label1.Text = "Список доходов";
            // 
            // bank_account
            // 
            bank_account.Font = new Font("Segoe UI", 18F);
            bank_account.Location = new Point(294, 8);
            bank_account.Name = "bank_account";
            bank_account.Size = new Size(180, 49);
            bank_account.TabIndex = 21;
            bank_account.Text = "Счет";
            bank_account.UseVisualStyleBackColor = true;
            bank_account.Click += bank_account_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(bank_account);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Button but_add;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label5;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Button but_subtr;
        private MaskedTextBox maskedTextBox2;
        private Label label8;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button bank_account;
    }
}
