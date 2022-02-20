using CalendarApp.classes;
using CalendarApp.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class MainForm : Form
    {
        private AllActivities allActivities; // Поле объекта, в котором хранятся все события.
        private bool isListForToday = true; // Поле необходимо для переключения настроек элекментов.

        public MainForm()
        {
            InitializeComponent();
            TimeUpdate(null, null);
            allActivities = new AllActivities();
        }

        //Метод обновляет панель на которой отображаются записи событий.
        public void ActivityPanelUpdate()
        {
            List<Activity> ActivitieForRecords;

            if (isListForToday)
                ActivitieForRecords = allActivities.GetByDate(Now.Date);
            else
                ActivitieForRecords = allActivities.GetAll();

            panelActivity.Controls.Clear();
            panelActivity.Controls.AddRange(Record.CreateRange(ActivitieForRecords)); // Добавление элементов, представляющих записи событий.
        }

        // Мето для переключения настроек элементов.
        private void SwitchClick(object sender, EventArgs e)
        {
            titleLabel.Focus(); // Сброс фокуса с кнопки

            if (isListForToday)
                SetupsForAll();
            else
                SetupsForToday();

            ActivityPanelUpdate();
        }

        // Метод выставляется настройки для элементов интерфейса.
        private void SetupsForAll()
        {
            isListForToday = false;
            switchActivityButton.Text = "Показать на сегодня";
            dateTimer.Stop();
            titleLabel.Text = "Список всех событий:";
        }

        // Метод выставляется настройки для элементов интерфейса.
        private void SetupsForToday()
        {
            isListForToday = true;
            switchActivityButton.Text = "Показать всё";
            TimeUpdate(null,null);
            dateTimer.Start();
        }

        // Метод для добавления события.
        private void AddActivity(object sender, EventArgs e)
        {
            titleLabel.Focus(); // Сброс фокуса с кнопки
            CreateEditForm(null);
        }

        // Метод для создания формы редактирования. В нем так же определяется с какими целями создается форма (для создания или редактирования).
        public void CreateEditForm (string[] args)
        {
            EditForm editForm;

            if (args != null)
                editForm = new EditForm(this, allActivities, panelActivity, args[0], args[1], args[2]); // Инициализация формы с целью редактирования.
            else
                editForm = new EditForm(this, allActivities, panelActivity); // Инициализация формы с целью создания.

            editForm.Show();
            Enabled = false; // Деактивирует форму для выключения всех элементов
        }

        // Метод необходим для удаления стрроки события. Вызывается из контекстного меню строки события.
        public void Delete(Activity activity)
        {
            allActivities.Delete(activity);
            ActivityPanelUpdate();
        }

        // Метод обновляет дату и время каждую секунду.
        private void TimeUpdate(object sender, EventArgs e)
        {
            Now = DateTime.Now;
            string dayOfWeak = $"{Now:dddd}"; // День недели
            dayOfWeak = char.ToUpper(dayOfWeak[0]) + dayOfWeak.Substring(1); // Смена регистра первой буквы дня недели

            titleLabel.Text = $"Сегодня: \n{Now:M}, {Now.Year}, {dayOfWeak}, {Now:HH:mm:ss}"; // Тексту на форме задается дата
        }

        // Метод изменяет размер разделительной черты.
        private void BorderResize(object sender, EventArgs e)
        {
            menuBorder2.Location = new Point(0,panelButtons.Location.Y - 2);
            menuBorder2.Width = Width;
        }
        
        // Свойство хранящее текующую дату.
        public DateTime Now { get; private set; } = DateTime.Now;
    }
}
