using CalendarApp.classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarApp.forms
{
    public partial class EditForm : Form
    {
        private AllActivities allActivities; // Поле хранит ссылку объекта всех событий из основной формы.
        private MainForm mainForm; // Поле хранит ссылку основной формы.
        private Panel panelActivity; // Поле хранит ссылку панели событий.

        private string textBeforeChange = ""; // Поле хранит текст из элементов до их изменения.
        private bool isRemider = false; // Поле указывает тип создаваемого события

        private Activity oldActivity = null; // Поле необходимо для сохранения ссылки на объект до его изменения.

        //Конструктор для инициализации формы с целью создания события.
        public EditForm(MainForm mainForm, AllActivities allActivities, Panel panelActivity)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.allActivities = allActivities;
            this.panelActivity = panelActivity;

            dateTextBox.Text = mainForm.Now.Date.ToString("dd.MM");
        }

        //Конструктор для инициализации формы с целью редактирования события.
        public EditForm(MainForm mainForm, AllActivities allActivities, Panel panelActivity, string title, string date, string time)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.allActivities = allActivities;
            this.panelActivity = panelActivity;

            titleTextBox.Text = title;
            dateTextBox.Text = date;
            // Если было передано время, значит, редактируется событие типа напоминание.
            if (time != null) 
            {
                activivtyCheckBox.Checked = true;
                timeTextBox.Text = time;
            }

            oldActivity = CreateActivity(); // Создается объект события, который подлежит изменению.
        }

        //Метод для подтверждения изменения/создания события
        private void Confirm (object sender, EventArgs e)
        {
            Activity activity = CreateActivity();

            if (oldActivity != null)
                allActivities.Edit(oldActivity, activity);
            else
                allActivities.Add(activity);

            if (activity != null)
            {
                mainForm.ActivityPanelUpdate();
                Close();
            }
            else
                MessageBox.Show("Ошибка при сохранении даты или времени", "Сайт", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Метод для создания события
        private Activity CreateActivity ()
        {
            Activity activity = null;
            string title = titleTextBox.Text;
            bool dateSuccess = DateTime.TryParse(dateTextBox.Text, out DateTime date);
            bool timeSuccess = TimeSpan.TryParse(timeTextBox.Text, out TimeSpan time);

            if (isRemider & timeSuccess)
                activity = new Remider(title, date, time);
            if (!isRemider & dateSuccess)
                activity = new Holiday(title, date);

            return activity;
        } 

        // Метод активирует ранее отключенную форму
        private void CloseForm (object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        //изменение элемента при фокусе
        private void TextBoxFocus (object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.Black;
        }

        //Изменение элемента при расфокусе
        private void TextBoxUnfocus (object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.DarkGray;
        }

        //Метод для переключения вида события
        private void ActivityChange (object sender, EventArgs e)
        {
            isRemider = activivtyCheckBox.Checked;

            string time = "00:00";
            if (timeTextBox.Text != "")
                time = timeTextBox.Text;

            if (isRemider == true)
                SetRemiderSettings(time);
            else
                SetHolidaySettings();
        }

        //Метод устанавливает настройки при редактировании события типа напоминание.
        private void SetRemiderSettings(string time)
        {
            timeLabel.Enabled = true;
            timeTextBox.Enabled = true;
            dateTextBox.Mask = "00/00/0000";
            dateTextBox.Text = mainForm.Now.Date.ToString();
            timeTextBox.Mask = "00:00";
            timeTextBox.Text = time;
            timeTextBox.BackColor = Color.FromArgb(253, 253, 253);
        }

        //Метод устанавливает настройки при редактировании события типа праздник.
        private void SetHolidaySettings()
        {
            timeLabel.Enabled = false;
            timeTextBox.Enabled = false;
            dateTextBox.Mask = "00/00";
            dateTextBox.Text = mainForm.Now.Date.ToString("dd.MM");
            timeTextBox.Mask = "";
            timeTextBox.Text = "";
            timeTextBox.BackColor = Color.WhiteSmoke;
        }

        // Метод сохраняет текс до кадого нажатия на кнопку 
        private void SaveTextOnKeyPress(object sender, KeyEventArgs e)
        {
            textBeforeChange = ((MaskedTextBox)sender).Text;
        }

        // Метод предотвращающий удаление символов из элемента
        private void DisableChangeByBackspace(object sender, EventArgs e)
        {
            if (((MaskedTextBox)sender).Text.Length < textBeforeChange.Length)
                ((MaskedTextBox)sender).Text = textBeforeChange;
        }
    }
}
