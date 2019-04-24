namespace Discount_sh
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._ADDID = new System.Windows.Forms.TextBox();
            this._ADDNAME = new System.Windows.Forms.TextBox();
            this._ADDPHONE = new System.Windows.Forms.TextBox();
            this._ADDBONUS = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скидка";
            // 
            // _ADDID
            // 
            this._ADDID.Location = new System.Drawing.Point(73, 19);
            this._ADDID.Name = "_ADDID";
            this._ADDID.Size = new System.Drawing.Size(100, 20);
            this._ADDID.TabIndex = 4;
            // 
            // _ADDNAME
            // 
            this._ADDNAME.Location = new System.Drawing.Point(73, 48);
            this._ADDNAME.Name = "_ADDNAME";
            this._ADDNAME.Size = new System.Drawing.Size(100, 20);
            this._ADDNAME.TabIndex = 5;
            // 
            // _ADDPHONE
            // 
            this._ADDPHONE.Location = new System.Drawing.Point(73, 77);
            this._ADDPHONE.Name = "_ADDPHONE";
            this._ADDPHONE.Size = new System.Drawing.Size(100, 20);
            this._ADDPHONE.TabIndex = 6;
            // 
            // _ADDBONUS
            // 
            this._ADDBONUS.Location = new System.Drawing.Point(73, 106);
            this._ADDBONUS.Name = "_ADDBONUS";
            this._ADDBONUS.Size = new System.Drawing.Size(100, 20);
            this._ADDBONUS.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(73, 154);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "OK";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 220);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this._ADDBONUS);
            this.Controls.Add(this._ADDPHONE);
            this.Controls.Add(this._ADDNAME);
            this.Controls.Add(this._ADDID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _ADDID;
        private System.Windows.Forms.TextBox _ADDNAME;
        private System.Windows.Forms.TextBox _ADDPHONE;
        private System.Windows.Forms.TextBox _ADDBONUS;
        private System.Windows.Forms.Button AddButton;
    }
}