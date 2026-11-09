namespace k_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDiscriminant = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbVieta = new System.Windows.Forms.RichTextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "c =";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(88, 64);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(141, 28);
            this.txt_A.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(445, 164);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 28);
            this.txtB.TabIndex = 4;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(684, 64);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(152, 28);
            this.txt_C.TabIndex = 5;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(332, 140);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(318, 52);
            this.btnSolve.TabIndex = 6;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDiscriminant);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод 1: Дискриминант.";
            // 
            // rtbDiscriminant
            // 
            this.rtbDiscriminant.BackColor = System.Drawing.Color.White;
            this.rtbDiscriminant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDiscriminant.Location = new System.Drawing.Point(0, 27);
            this.rtbDiscriminant.Name = "rtbDiscriminant";
            this.rtbDiscriminant.ReadOnly = true;
            this.rtbDiscriminant.Size = new System.Drawing.Size(368, 155);
            this.rtbDiscriminant.TabIndex = 0;
            this.rtbDiscriminant.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbVieta);
            this.groupBox2.Location = new System.Drawing.Point(491, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод 2: Теорема Виета";
            // 
            // rtbVieta
            // 
            this.rtbVieta.BackColor = System.Drawing.Color.White;
            this.rtbVieta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbVieta.Location = new System.Drawing.Point(0, 27);
            this.rtbVieta.Name = "rtbVieta";
            this.rtbVieta.ReadOnly = true;
            this.rtbVieta.Size = new System.Drawing.Size(394, 155);
            this.rtbVieta.TabIndex = 0;
            this.rtbVieta.Text = "";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(397, 64);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(158, 28);
            this.txt_B.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(972, 566);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратного уравнения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDiscriminant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbVieta;
        private System.Windows.Forms.TextBox txt_B;
    }
}

