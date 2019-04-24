namespace Discount_sh
{
    partial class MainForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_IDvalue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_BONUS = new System.Windows.Forms.Label();
            this.label_PHONEvalue = new System.Windows.Forms.Label();
            this.label_NAMEvalue = new System.Windows.Forms.Label();
            this.label_PHONE = new System.Windows.Forms.Label();
            this.label_NAME = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(80, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(37, 32);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.Visible = false;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(6, 29);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 6;
            this.label_ID.Text = "ID";
            // 
            // label_IDvalue
            // 
            this.label_IDvalue.AutoSize = true;
            this.label_IDvalue.Location = new System.Drawing.Point(77, 29);
            this.label_IDvalue.Name = "label_IDvalue";
            this.label_IDvalue.Size = new System.Drawing.Size(10, 13);
            this.label_IDvalue.TabIndex = 7;
            this.label_IDvalue.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label_PHONEvalue);
            this.groupBox1.Controls.Add(this.label_NAMEvalue);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.label_PHONE);
            this.groupBox1.Controls.Add(this.label_NAME);
            this.groupBox1.Controls.Add(this.label_ID);
            this.groupBox1.Controls.Add(this.label_IDvalue);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_BONUS);
            this.groupBox2.Location = new System.Drawing.Point(19, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скидка";
            // 
            // label_BONUS
            // 
            this.label_BONUS.AutoSize = true;
            this.label_BONUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BONUS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_BONUS.Location = new System.Drawing.Point(43, 16);
            this.label_BONUS.Name = "label_BONUS";
            this.label_BONUS.Size = new System.Drawing.Size(36, 29);
            this.label_BONUS.TabIndex = 0;
            this.label_BONUS.Text = "%";
            // 
            // label_PHONEvalue
            // 
            this.label_PHONEvalue.AutoSize = true;
            this.label_PHONEvalue.Location = new System.Drawing.Point(77, 76);
            this.label_PHONEvalue.Name = "label_PHONEvalue";
            this.label_PHONEvalue.Size = new System.Drawing.Size(10, 13);
            this.label_PHONEvalue.TabIndex = 11;
            this.label_PHONEvalue.Text = "-";
            // 
            // label_NAMEvalue
            // 
            this.label_NAMEvalue.AutoSize = true;
            this.label_NAMEvalue.Location = new System.Drawing.Point(77, 52);
            this.label_NAMEvalue.Name = "label_NAMEvalue";
            this.label_NAMEvalue.Size = new System.Drawing.Size(10, 13);
            this.label_NAMEvalue.TabIndex = 10;
            this.label_NAMEvalue.Text = "-";
            // 
            // label_PHONE
            // 
            this.label_PHONE.AutoSize = true;
            this.label_PHONE.Location = new System.Drawing.Point(6, 76);
            this.label_PHONE.Name = "label_PHONE";
            this.label_PHONE.Size = new System.Drawing.Size(52, 13);
            this.label_PHONE.TabIndex = 9;
            this.label_PHONE.Text = "Телефон";
            // 
            // label_NAME
            // 
            this.label_NAME.AutoSize = true;
            this.label_NAME.Location = new System.Drawing.Point(6, 52);
            this.label_NAME.Name = "label_NAME";
            this.label_NAME.Size = new System.Drawing.Size(29, 13);
            this.label_NAME.TabIndex = 8;
            this.label_NAME.Text = "Имя";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(31, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 307);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Дискаунт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_IDvalue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_PHONEvalue;
        private System.Windows.Forms.Label label_NAMEvalue;
        private System.Windows.Forms.Label label_PHONE;
        private System.Windows.Forms.Label label_NAME;
        private System.Windows.Forms.Label label_BONUS;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

