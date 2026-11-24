namespace Tyuiu.MikhailichenkoAI.Sprint7.Project.V3
{
    partial class FormGuide_MAI
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
            this.textBoxGuideContent_MAI = new System.Windows.Forms.TextBox();
            this.buttonCloseGuide_MAI = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBoxGuideContent_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGuideContent_MAI.BackColor = System.Drawing.Color.White;
            this.textBoxGuideContent_MAI.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxGuideContent_MAI.Location = new System.Drawing.Point(14, 14);
            this.textBoxGuideContent_MAI.Multiline = true;
            this.textBoxGuideContent_MAI.Name = "textBoxGuideContent_MAI";
            this.textBoxGuideContent_MAI.ReadOnly = true;
            this.textBoxGuideContent_MAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGuideContent_MAI.Size = new System.Drawing.Size(612, 345);
            this.textBoxGuideContent_MAI.TabIndex = 0;
            this.textBoxGuideContent_MAI.Text = "КРАТКОЕ РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ\r\nИнформационная система «Университет» (Вариант 3)\r\n\r\n1. РАБОТА С ФАЙЛАМИ CSV\r\n- При запуске автоматически загружается файл UniversityData.csv из папки программы.\r\n- «Файл -> Открыть CSV» (Ctrl+O) позволяет загрузить любую совместимую таблицу CSV с разделителем «;».\r\n- «Файл -> Сохранить» (Ctrl+S) сохраняет изменения в текущий открытый файл.\r\n- «Файл -> Сохранить как...» позволяет сохранить данные в новый CSV-файл.\r\n\r\n2. ВВОД, РЕДАКТИРОВАНИЕ И УДАЛЕНИЕ ЗАПИСЕЙ\r\n- «Добавить» (Ctrl+N) открывает форму ввода новой записи о преподавателе, предмете, кафедре и аудитории.\r\n- «Редактировать» (Ctrl+E или двойной щелчок по строке таблицы) открывает выбранную запись для изменения.\r\n- «Удалить» (Del) удаляет выделенную запись после подтверждения.\r\n\r\n3. ПОИСК, ФИЛЬТРАЦИЯ И СОРТИРОВКА\r\n- Введите любой текст или число в поле «Поиск» для мгновенного отбора по всем столбцам.\r\n- Используйте выпадающие списки «Должность», «Тип контроля» и «Кафедра» для комбинированной фильтрации.\r\n- Выберите поле в списке «Сортировка» и отметьте направление (по возрастанию или убыванию).\r\n- Кнопка «Сбросить» очищает все фильтры и строку поиска.\r\n\r\n4. СТАТИСТИКА И ДИАГРАММЫ\r\n- Блок статистики автоматически пересчитывает количество записей, сумму, среднее, минимум и максимум часов для текущей выборки.\r\n- В блоке диаграммы можно переключать режим отображения: часы по кафедрам, часы по должностям или распределение по типам контроля.";

            this.buttonCloseGuide_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseGuide_MAI.Location = new System.Drawing.Point(526, 370);
            this.buttonCloseGuide_MAI.Name = "buttonCloseGuide_MAI";
            this.buttonCloseGuide_MAI.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseGuide_MAI.TabIndex = 1;
            this.buttonCloseGuide_MAI.Text = "Понятно";
            this.buttonCloseGuide_MAI.UseVisualStyleBackColor = true;
            this.buttonCloseGuide_MAI.Click += new System.EventHandler(this.buttonCloseGuide_MAI_Click);

            this.AcceptButton = this.buttonCloseGuide_MAI;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Controls.Add(this.buttonCloseGuide_MAI);
            this.Controls.Add(this.textBoxGuideContent_MAI);
            this.MinimumSize = new System.Drawing.Size(500, 340);
            this.Name = "FormGuide_MAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Руководство пользователя — Университет";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxGuideContent_MAI;
        private System.Windows.Forms.Button buttonCloseGuide_MAI;
    }
}
