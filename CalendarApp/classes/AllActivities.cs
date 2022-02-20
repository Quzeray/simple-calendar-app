using System;
using System.Collections.Generic;

namespace CalendarApp.classes
{
    public class AllActivities
    {
        private List<Activity> activities; // Поле для хранения объекта всех событий.

        public AllActivities()
        {
            activities = new List<Activity>();
        }

        //Метод добалвяет в начало списка событие, если список пустой, в ином случае использует другой метот для добавления.
        public void Add(Activity activity)
        {
            if (activities.Count == 0)
                activities.Add(activity);
            else
                SortedAdd(activity);
        }

        //Метод добавляет событие исходя из даты.
        private void SortedAdd(Activity activity)
        {
            DateTime date = activity.Date;
            bool isDateLess(Activity a) => date > a.Date;
            int index = activities.FindIndex(isDateLess);

            if (index == -1)
                activities.Add(activity);
            else
                activities.Insert(index, activity);
        }

        //Метод возварщает список событий на указанную дату.
        public List<Activity> GetByDate (DateTime date)
        {
            bool isDateEqual(Activity a) => date.Date == a.Date.Date;
            return activities.FindAll(isDateEqual);
        }

        // Метод возвращает список всех событий.
        public List<Activity> GetAll ()
        {
            return activities;
        }

        // Метод удаляет событие.
        public void Delete (Activity activity)
        {
            bool isEqual(Activity a) => activity.Print() == a.Print();
            int index = activities.FindIndex(isEqual);
            activities.RemoveAt(index);
        }

        // Метод Редактирует событие.
        public void Edit (Activity activityOld, Activity activityNew)
        {
            Delete(activityOld);
            SortedAdd(activityNew);
        }

    }
}
