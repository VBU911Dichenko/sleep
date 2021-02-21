using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace sleep
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
            callk = new Cal_sleep();

            numeric_in = new NumericUpDown();
            rezult = new Label();
            info = new Label();
            call = new Button();

            SuspendLayout();
            // 
            // numeric_in
            // 
            numeric_in.BackColor = Color.FromArgb(255, 255, 128);
            numeric_in.Location = new Point(15, 113);
            numeric_in.Maximum = 24;
            numeric_in.Minimum = 0;
            numeric_in.Name = "numeric_in";
            numeric_in.Size = new Size(72, 20);
            numeric_in.TabIndex = 0;
            numeric_in.TextAlign = HorizontalAlignment.Center;
            // 
            // rezult
            // 
            rezult.BackColor = Color.FromArgb(255, 255, 128);
            rezult.Location = new Point(12, 183);
            rezult.Name = "rezult";
            rezult.Size = new Size(206, 103);
            rezult.TabIndex = 1;
            rezult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            info.BackColor = Color.FromArgb(255, 255, 128);
            info.Location = new Point(12, 9);
            info.Name = "info";
            info.Size = new Size(206, 63);
            info.TabIndex = 2;
            info.Text = "Введит сколько вы хотите поспать";
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // call
            // 
            call.BackColor = Color.FromArgb(128, 255, 128);
            call.ForeColor = Color.Black;
            call.Location = new Point(143, 113);
            call.Name = "call";
            call.Size = new Size(75, 23);
            call.TabIndex = 3;
            call.Text = "Расчитать";
            call.UseVisualStyleBackColor = false;
            call.Click += Call_Click;
            // 
            // Form1
            // 
            FormBorderStyle = FormBorderStyle.FixedDialog;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(234, 305);
            Controls.Add(call);
            Controls.Add(info);
            Controls.Add(rezult);
            Controls.Add(numeric_in);
            Name = "Form1";
            Text = "Form1";

            ResumeLayout(false);

        }

        private void Call_Click(object sender, System.EventArgs e)
        {
            rezult.Text = callk.Calculating(Convert.ToInt32(numeric_in.Value));
        }

        #endregion
        private Cal_sleep callk;
        private NumericUpDown numeric_in;
        private Label rezult;
        private Label info;
        private Button call;

    }
}

