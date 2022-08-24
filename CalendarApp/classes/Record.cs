using CalendarApp.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace CalendarApp.classes
{
    class Record
    {
        private static int index; //Поле необходимо для присвоения оригинальных имен элементам.

        //Метод создает массив элементов (запись) для панели событий из добавляемого события.
        private static Control[] Create(Activity addedActivity)
        {
            index++;

            //Создание контестного меню для каждого элемента записи события.
            MenuItem editMenuItem = new MenuItem("Редактировать", Edit);
            MenuItem deleteMenuItem = new MenuItem("Удалить", Delete);
            ContextMenu contextMenu = new ContextMenu(new MenuItem[] { editMenuItem, deleteMenuItem });

            //Элемент кнопки предстваляет событие
            Button activity = new Button();
            activity.Dock = DockStyle.Top;
            activity.FlatAppearance.BorderSize = 0;
            activity.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 250, 250);
            activity.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 250);
            activity.FlatStyle = FlatStyle.Flat;
            activity.Location = new Point(0, 51);
            activity.Name = "Activity" + index;
            activity.Padding = new Padding(40, 0, 0, 0);
            activity.Size = new Size(784, 50);
            activity.TabIndex = 0;
            activity.TabStop = false;
            activity.Text = addedActivity.Print();
            activity.TextAlign = ContentAlignment.MiddleLeft;
            activity.UseVisualStyleBackColor = true;
            activity.ContextMenu = contextMenu;

            //Разделительная черта
            Panel border = new Panel();
            border.BackColor = Color.Silver;
            border.Dock = DockStyle.Top;
            border.Location = new Point(0, 101);
            border.Margin = new Padding(0);
            border.Name = "border" + index;
            border.Size = new Size(784, 1);
            border.TabIndex = 4;

            return new Control[] { border, activity };
        }

        //Метод для редактирования элемента записи события.
        private static void Edit(object sender, EventArgs e)
        {
            string[] args = null;
            MainForm mainForm = GetArgsFromRecord(sender, ref args);
            mainForm.CreateEditForm(args);
        }

        //Метод для удаления элемента записи события.
        private static void Delete(object sender, EventArgs e)
        {
            string[] args = null;
            MainForm mainForm = GetArgsFromRecord(sender, ref args);

            Activity activity;
            if (args[2] != null)
                activity = new Remider(args[0], DateTime.Parse(args[1]), TimeSpan.Parse(args[2]));         
            else
                activity = new Holiday(args[0], DateTime.Parse(args[1]));

            mainForm.Delete(activity);
        }

        //Метод берет аргументы для создания события из элемента записи. Так же возвращает ссылку на основную форму.
        private static MainForm GetArgsFromRecord(object sender, ref string[] args)
        {
            ContextMenu contextMenu = (ContextMenu)((MenuItem)sender).Parent;
            Button record = (Button)contextMenu.SourceControl;
            MainForm mainForm = (MainForm)record.Parent.Parent.Parent;

            args = ConvertTextToActivity(record.Text);

            return mainForm;
        }

        //Метод создает из текстовой записи объект события.
        private static string[] ConvertTextToActivity(string text)
        {
            byte startTitleIndex = 2;

            string[] rows = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string date = rows[1];
            string time = null;
            string title = "";

            if (rows[0] == "(Напоминание)")
            {
                startTitleIndex = 3;
                time = rows[2];
            }

            title = rows[startTitleIndex];
            for (int i = startTitleIndex + 1; i < rows.Length; i++)
                title += " " + rows[i];

            return new string[] {title, date, time};
        }

        //Метод нужен для создания массива элементов, представляющих события.
        public static Control[] CreateRange(List<Activity> activities)
        {
            index = 0;
            Control[] records = new Control[activities.Count * 2];
            Control[] record = new Control[2];
            Activity activity;

            int i = 0, j = 0;
            for (; i < activities.Count; i++, j +=2)
            {
                activity = activities[i];
                record = Create(activity);
                records[j] = record[0];
                records[j + 1] = record[1];
            }

            return records;
        }
    }
}
