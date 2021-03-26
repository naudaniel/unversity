
namespace oop_3laba
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
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.RadioButton();
            this.a2 = new System.Windows.Forms.RadioButton();
            this.a_3 = new System.Windows.Forms.RadioButton();
            this.combo_b = new System.Windows.Forms.ComboBox();
            this.z1 = new System.Windows.Forms.CheckBox();
            this.z2 = new System.Windows.Forms.CheckBox();
            this.z3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(623, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a";
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(626, 33);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(40, 17);
            this.a1.TabIndex = 2;
            this.a1.TabStop = true;
            this.a1.Text = "0.8";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Location = new System.Drawing.Point(626, 56);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(40, 17);
            this.a2.TabIndex = 3;
            this.a2.TabStop = true;
            this.a2.Text = "2.2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a_3
            // 
            this.a_3.AutoSize = true;
            this.a_3.Location = new System.Drawing.Point(626, 79);
            this.a_3.Name = "a_3";
            this.a_3.Size = new System.Drawing.Size(40, 17);
            this.a_3.TabIndex = 4;
            this.a_3.TabStop = true;
            this.a_3.Text = "3.2";
            this.a_3.UseVisualStyleBackColor = true;
            // 
            // combo_b
            // 
            this.combo_b.FormattingEnabled = true;
            this.combo_b.Location = new System.Drawing.Point(12, 183);
            this.combo_b.Name = "combo_b";
            this.combo_b.Size = new System.Drawing.Size(121, 21);
            this.combo_b.TabIndex = 5;
            // 
            // z1
            // 
            this.z1.AutoSize = true;
            this.z1.Location = new System.Drawing.Point(223, 183);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(43, 17);
            this.z1.TabIndex = 6;
            this.z1.Text = "e^x";
            this.z1.UseVisualStyleBackColor = true;
            // 
            // z2
            // 
            this.z2.AutoSize = true;
            this.z2.Location = new System.Drawing.Point(223, 206);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(50, 17);
            this.z2.TabIndex = 7;
            this.z2.Text = "e^2a";
            this.z2.UseVisualStyleBackColor = true;
            // 
            // z3
            // 
            this.z3.AutoSize = true;
            this.z3.Location = new System.Drawing.Point(223, 229);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(50, 17);
            this.z3.TabIndex = 8;
            this.z3.Text = "e^3b";
            this.z3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(220, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose z";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose b";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Відповідь:";
            // 
            // result_label
            // 
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(355, 310);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(263, 20);
            this.result_label.TabIndex = 13;
            this.result_label.Text = "0";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(391, 179);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_x.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "x = ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::oop_3laba.Properties.Resources.picture;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 130);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.combo_b);
            this.Controls.Add(this.a_3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton a1;
        private System.Windows.Forms.RadioButton a2;
        private System.Windows.Forms.RadioButton a_3;
        private System.Windows.Forms.ComboBox combo_b;
        private System.Windows.Forms.CheckBox z1;
        private System.Windows.Forms.CheckBox z2;
        private System.Windows.Forms.CheckBox z3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

