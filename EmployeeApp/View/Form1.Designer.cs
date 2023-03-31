namespace EmployeeApp.View
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.jobTypeBox3 = new System.Windows.Forms.RadioButton();
            this.jobTypeBox2 = new System.Windows.Forms.RadioButton();
            this.jobTypeBox = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.jobTypeBox3);
            this.groupBox1.Controls.Add(this.jobTypeBox2);
            this.groupBox1.Controls.Add(this.jobTypeBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jobBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.salaryBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.Imie);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Pracownika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add);
            // 
            // jobTypeBox3
            // 
            this.jobTypeBox3.AutoSize = true;
            this.jobTypeBox3.Location = new System.Drawing.Point(122, 383);
            this.jobTypeBox3.Name = "jobTypeBox3";
            this.jobTypeBox3.Size = new System.Drawing.Size(139, 24);
            this.jobTypeBox3.TabIndex = 14;
            this.jobTypeBox3.TabStop = true;
            this.jobTypeBox3.Text = "Umowa zlecenie";
            this.jobTypeBox3.UseVisualStyleBackColor = true;
            this.jobTypeBox3.CheckedChanged += new System.EventHandler(this.get_jobType);
            // 
            // jobTypeBox2
            // 
            this.jobTypeBox2.AutoSize = true;
            this.jobTypeBox2.Location = new System.Drawing.Point(122, 353);
            this.jobTypeBox2.Name = "jobTypeBox2";
            this.jobTypeBox2.Size = new System.Drawing.Size(200, 24);
            this.jobTypeBox2.TabIndex = 13;
            this.jobTypeBox2.TabStop = true;
            this.jobTypeBox2.Text = "Umowa na czas okreśłony";
            this.jobTypeBox2.UseVisualStyleBackColor = true;
            this.jobTypeBox2.CheckedChanged += new System.EventHandler(this.get_jobType);
            // 
            // jobTypeBox
            // 
            this.jobTypeBox.AutoSize = true;
            this.jobTypeBox.Location = new System.Drawing.Point(123, 323);
            this.jobTypeBox.Name = "jobTypeBox";
            this.jobTypeBox.Size = new System.Drawing.Size(220, 24);
            this.jobTypeBox.TabIndex = 12;
            this.jobTypeBox.TabStop = true;
            this.jobTypeBox.Text = "Umowa na czas nieokreślony";
            this.jobTypeBox.UseVisualStyleBackColor = true;
            this.jobTypeBox.CheckedChanged += new System.EventHandler(this.get_jobType);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rodzaj umowy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stanowisko";
            // 
            // jobBox
            // 
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Location = new System.Drawing.Point(122, 267);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(251, 28);
            this.jobBox.TabIndex = 9;
            this.jobBox.SelectedIndexChanged += new System.EventHandler(this.get_job);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pensja";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(123, 218);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(250, 27);
            this.salaryBox.TabIndex = 7;
            this.salaryBox.ValueChanged += new System.EventHandler(this.get_salary);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data urodzenia";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(123, 165);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(250, 27);
            this.dateBox.TabIndex = 5;
            this.dateBox.ValueChanged += new System.EventHandler(this.get_DoB);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(123, 114);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(250, 27);
            this.lastNameBox.TabIndex = 4;
            this.lastNameBox.TextChanged += new System.EventHandler(this.get_Nazwisko);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwisko";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(123, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 27);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.get_Imie);
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(6, 63);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(38, 20);
            this.Imie.TabIndex = 0;
            this.Imie.Text = "Imie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Wczytaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.load);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(419, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 524);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 570);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameBox;
        private Label Imie;
        private TextBox lastNameBox;
        private Label label1;
        private Button button1;
        private RadioButton jobTypeBox3;
        private RadioButton jobTypeBox2;
        private RadioButton jobTypeBox;
        private Label label5;
        private Label label4;
        private ComboBox jobBox;
        private Label label3;
        private NumericUpDown salaryBox;
        private Label label2;
        private DateTimePicker dateBox;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}