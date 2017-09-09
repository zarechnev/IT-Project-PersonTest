namespace TestApp1
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
            this.label2Variant = new System.Windows.Forms.Label();
            this.FormQuestion_1 = new System.Windows.Forms.RichTextBox();
            this.FormQuestion_2 = new System.Windows.Forms.RichTextBox();
            this.button1Variant1 = new System.Windows.Forms.Button();
            this.button2Variant2 = new System.Windows.Forms.Button();
            this.richTextBox1PersonDescription = new System.Windows.Forms.RichTextBox();
            this.label12PersonDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2Variant
            // 
            this.label2Variant.AutoSize = true;
            this.label2Variant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Variant.Location = new System.Drawing.Point(12, 113);
            this.label2Variant.Name = "label2Variant";
            this.label2Variant.Size = new System.Drawing.Size(356, 17);
            this.label2Variant.TabIndex = 2;
            this.label2Variant.Text = "Выберите наиболее пододящий вам вариант ответа";
            // 
            // FormQuestion_1
            // 
            this.FormQuestion_1.Location = new System.Drawing.Point(12, 145);
            this.FormQuestion_1.Name = "FormQuestion_1";
            this.FormQuestion_1.Size = new System.Drawing.Size(376, 47);
            this.FormQuestion_1.TabIndex = 13;
            this.FormQuestion_1.Text = "";
            // 
            // FormQuestion_2
            // 
            this.FormQuestion_2.Location = new System.Drawing.Point(12, 237);
            this.FormQuestion_2.Name = "FormQuestion_2";
            this.FormQuestion_2.Size = new System.Drawing.Size(376, 48);
            this.FormQuestion_2.TabIndex = 14;
            this.FormQuestion_2.Text = "";
            // 
            // button1Variant1
            // 
            this.button1Variant1.Location = new System.Drawing.Point(178, 198);
            this.button1Variant1.Name = "button1Variant1";
            this.button1Variant1.Size = new System.Drawing.Size(210, 23);
            this.button1Variant1.TabIndex = 15;
            this.button1Variant1.Text = "Мне подходит первый вариант";
            this.button1Variant1.UseVisualStyleBackColor = true;
            this.button1Variant1.Click += new System.EventHandler(this.button1Variant1_Click);
            // 
            // button2Variant2
            // 
            this.button2Variant2.Location = new System.Drawing.Point(178, 291);
            this.button2Variant2.Name = "button2Variant2";
            this.button2Variant2.Size = new System.Drawing.Size(210, 23);
            this.button2Variant2.TabIndex = 16;
            this.button2Variant2.Text = "Мне подходит второй вариант";
            this.button2Variant2.UseVisualStyleBackColor = true;
            this.button2Variant2.Click += new System.EventHandler(this.button2Variant2_Click);
            // 
            // richTextBox1PersonDescription
            // 
            this.richTextBox1PersonDescription.Location = new System.Drawing.Point(420, 50);
            this.richTextBox1PersonDescription.Name = "richTextBox1PersonDescription";
            this.richTextBox1PersonDescription.Size = new System.Drawing.Size(702, 269);
            this.richTextBox1PersonDescription.TabIndex = 17;
            this.richTextBox1PersonDescription.Text = "";
            // 
            // label12PersonDescription
            // 
            this.label12PersonDescription.AutoSize = true;
            this.label12PersonDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12PersonDescription.Location = new System.Drawing.Point(624, 18);
            this.label12PersonDescription.Name = "label12PersonDescription";
            this.label12PersonDescription.Size = new System.Drawing.Size(324, 17);
            this.label12PersonDescription.TabIndex = 18;
            this.label12PersonDescription.Text = "Описание типа личности по результатам теста";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Прогресс:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12PersonDescription);
            this.Controls.Add(this.richTextBox1PersonDescription);
            this.Controls.Add(this.button2Variant2);
            this.Controls.Add(this.button1Variant1);
            this.Controls.Add(this.FormQuestion_2);
            this.Controls.Add(this.FormQuestion_1);
            this.Controls.Add(this.label2Variant);
            this.MaximumSize = new System.Drawing.Size(1150, 380);
            this.MinimumSize = new System.Drawing.Size(1150, 380);
            this.Name = "Form1";
            this.Text = "Определение типа личности (Гуленко)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2Variant;
        private System.Windows.Forms.RichTextBox FormQuestion_2;
        private System.Windows.Forms.Button button1Variant1;
        private System.Windows.Forms.Button button2Variant2;
        private System.Windows.Forms.RichTextBox richTextBox1PersonDescription;
        private System.Windows.Forms.Label label12PersonDescription;
        public System.Windows.Forms.RichTextBox FormQuestion_1;
        private System.Windows.Forms.Label label1;
    }
}

