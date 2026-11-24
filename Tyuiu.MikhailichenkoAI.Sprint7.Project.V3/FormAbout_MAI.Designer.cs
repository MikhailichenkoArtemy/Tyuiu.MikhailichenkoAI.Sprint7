namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    partial class FormAbout_MAI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeaderAbout_MAI = new System.Windows.Forms.Panel();
            this.labelTitleAbout_MAI = new System.Windows.Forms.Label();
            this.labelSubtitleAbout_MAI = new System.Windows.Forms.Label();
            this.textBoxInfoAbout_MAI = new System.Windows.Forms.TextBox();
            this.buttonCloseAbout_MAI = new System.Windows.Forms.Button();
            this.panelHeaderAbout_MAI.SuspendLayout();
            this.SuspendLayout();

            this.panelHeaderAbout_MAI.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.panelHeaderAbout_MAI.Controls.Add(this.labelSubtitleAbout_MAI);
            this.panelHeaderAbout_MAI.Controls.Add(this.labelTitleAbout_MAI);
            this.panelHeaderAbout_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderAbout_MAI.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderAbout_MAI.Name = "panelHeaderAbout_MAI";
            this.panelHeaderAbout_MAI.Size = new System.Drawing.Size(500, 74);
            this.panelHeaderAbout_MAI.TabIndex = 0;

            this.labelTitleAbout_MAI.AutoSize = true;
            this.labelTitleAbout_MAI.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleAbout_MAI.ForeColor = System.Drawing.Color.White;
            this.labelTitleAbout_MAI.Location = new System.Drawing.Point(16, 12);
            this.labelTitleAbout_MAI.Name = "labelTitleAbout_MAI";
            this.labelTitleAbout_MAI.Size = new System.Drawing.Size(280, 25);
            this.labelTitleAbout_MAI.TabIndex = 0;
            this.labelTitleAbout_MAI.Text = "ИС «Университет» (Вариант 3)";

            this.labelSubtitleAbout_MAI.AutoSize = true;
            this.labelSubtitleAbout_MAI.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelSubtitleAbout_MAI.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSubtitleAbout_MAI.Location = new System.Drawing.Point(18, 42);
            this.labelSubtitleAbout_MAI.Name = "labelSubtitleAbout_MAI";
            this.labelSubtitleAbout_MAI.Size = new System.Drawing.Size(340, 17);
            this.labelSubtitleAbout_MAI.TabIndex = 1;
            this.labelSubtitleAbout_MAI.Text = "Учёт преподавателей, дисциплин, кафедр и аудиторий";

            this.textBoxInfoAbout_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfoAbout_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfoAbout_MAI.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxInfoAbout_MAI.Location = new System.Drawing.Point(18, 90);
            this.textBoxInfoAbout_MAI.Multiline = true;
            this.textBoxInfoAbout_MAI.Name = "textBoxInfoAbout_MAI";
            this.textBoxInfoAbout_MAI.ReadOnly = true;
            this.textBoxInfoAbout_MAI.Size = new System.Drawing.Size(464, 155);
            this.textBoxInfoAbout_MAI.TabIndex = 1;
            this.textBoxInfoAbout_MAI.TabStop = false;
            this.textBoxInfoAbout_MAI.Text = "Разработчик: Михайличенко Артемий Игоревич\r\nГруппа: ИИПБ26-1\r\nСпринт #7 | Итоговый проект | Вариант 3\r\n\r\nТюменский индустриальный университет (с) 2026\r\nВысшая школа цифровых технологий (с) 2026\r\n\r\nВнутреннее имя: Tyuiu.MikhailichenkoAI.Sprint7.Project.V3\r\nПлатформа: .NET 8.0 Windows Forms";

            this.buttonCloseAbout_MAI.Location = new System.Drawing.Point(392, 255);
            this.buttonCloseAbout_MAI.Name = "buttonCloseAbout_MAI";
            this.buttonCloseAbout_MAI.Size = new System.Drawing.Size(90, 30);
            this.buttonCloseAbout_MAI.TabIndex = 2;
            this.buttonCloseAbout_MAI.Text = "Закрыть";
            this.buttonCloseAbout_MAI.UseVisualStyleBackColor = true;
            this.buttonCloseAbout_MAI.Click += new System.EventHandler(this.buttonCloseAbout_MAI_Click);

            this.AcceptButton = this.buttonCloseAbout_MAI;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.buttonCloseAbout_MAI);
            this.Controls.Add(this.textBoxInfoAbout_MAI);
            this.Controls.Add(this.panelHeaderAbout_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_MAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе — Университет";
            this.panelHeaderAbout_MAI.ResumeLayout(false);
            this.panelHeaderAbout_MAI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeaderAbout_MAI;
        private System.Windows.Forms.Label labelTitleAbout_MAI;
        private System.Windows.Forms.Label labelSubtitleAbout_MAI;
        private System.Windows.Forms.TextBox textBoxInfoAbout_MAI;
        private System.Windows.Forms.Button buttonCloseAbout_MAI;
    }
}
