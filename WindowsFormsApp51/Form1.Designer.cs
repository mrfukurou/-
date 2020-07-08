namespace WindowsFormsApp51
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
            this.final_calc = new System.Windows.Forms.Button();
            this.average_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // final_calc
            // 
            this.final_calc.Location = new System.Drawing.Point(13, 13);
            this.final_calc.Name = "final_calc";
            this.final_calc.Size = new System.Drawing.Size(461, 72);
            this.final_calc.TabIndex = 0;
            this.final_calc.Text = "Расcчитать итоговый расход топлива";
            this.final_calc.UseVisualStyleBackColor = true;
            this.final_calc.Click += new System.EventHandler(this.final_calc_Click);
            // 
            // average_calc
            // 
            this.average_calc.Location = new System.Drawing.Point(13, 104);
            this.average_calc.Name = "average_calc";
            this.average_calc.Size = new System.Drawing.Size(461, 72);
            this.average_calc.TabIndex = 1;
            this.average_calc.Text = "Расcчитать средний расход топлива";
            this.average_calc.UseVisualStyleBackColor = true;
            this.average_calc.Click += new System.EventHandler(this.average_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 193);
            this.Controls.Add(this.average_calc);
            this.Controls.Add(this.final_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button final_calc;
        private System.Windows.Forms.Button average_calc;
    }
}

