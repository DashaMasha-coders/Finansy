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
            comboBox2 = new ComboBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            tollStripMenuItem1 = new ToolStripMenuItem();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            счетаToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(maskedTextBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Font = new Font("Segoe UI", 18F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.RightToLeft = RightToLeft.Yes;
            tabPage2.Size = new Size(792, 373);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            tabPage2.UseVisualStyleBackColor = true;
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
            listView2.Font = new Font("Segoe UI", 12F);
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
            label2.Location = new Point(37, 218);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
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
            label6.Location = new Point(30, 19);
            label6.Name = "label6";
            label6.Size = new Size(196, 32);
            label6.TabIndex = 15;
            label6.Text = "Сумма расходов";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 115);
            label7.Name = "label7";
            label7.Size = new Size(235, 32);
            label7.TabIndex = 13;
            label7.Text = "Категория расходов";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(75, 322);
            button2.Name = "button2";
            button2.Size = new Size(85, 31);
            button2.TabIndex = 12;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
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
            label8.Size = new Size(193, 32);
            label8.TabIndex = 10;
            label8.Text = "Список доходов";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tollStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tollStripMenuItem1
            // 
            tollStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, счетаToolStripMenuItem });
            tollStripMenuItem1.Name = "tollStripMenuItem1";
            tollStripMenuItem1.Size = new Size(53, 20);
            tollStripMenuItem1.Text = "Меню";
            tollStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(180, 22);
            главнаяToolStripMenuItem.Text = "Главная";
            // 
            // счетаToolStripMenuItem
            // 
            счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            счетаToolStripMenuItem.Size = new Size(180, 22);
            счетаToolStripMenuItem.Text = "Счета";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 401);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 18F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(792, 373);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Segoe UI", 12F);
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
            label5.Location = new Point(45, 214);
            label5.Name = "label5";
            label5.Size = new Size(167, 32);
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
            label4.Location = new Point(41, 15);
            label4.Name = "label4";
            label4.Size = new Size(171, 32);
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
            label3.Location = new Point(24, 111);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 4;
            label3.Text = "Категория дохода";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(83, 318);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
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
            label1.Location = new Point(464, 15);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 1;
            label1.Text = "Список доходов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tollStripMenuItem1;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem счетаToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Button button1;
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
        private Button button2;
        private MaskedTextBox maskedTextBox2;
        private Label label8;
        private ComboBox comboBox2;
    }
}
