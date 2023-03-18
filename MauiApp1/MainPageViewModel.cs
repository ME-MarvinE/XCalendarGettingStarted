using System.Windows.Input;
using XCalendar.Core.Extensions;
using XCalendar.Core.Models;

namespace MauiApp1
{
    internal class MainPageViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

        //Below code is for making the calendar navigatable.
        public ICommand NavigateCalendarCommand { get; set; }
        public MainPageViewModel()
        {
            NavigateCalendarCommand = new Command<int>(NavigateCalendar);
        }
        public void NavigateCalendar(int amount)
        {
            //Months are variable length, calculate the timespan needed to get to the result.
            DateTime targetDateTime = MyCalendar.NavigatedDate.AddMonths(amount);

            MyCalendar.Navigate(targetDateTime - MyCalendar.NavigatedDate);


            //The below code additionally handles the case that adding months leads to an unrepresentable date.

            //if (MyCalendar.NavigatedDate.TryAddMonths(amount, out DateTime TargetDate))
            //{
            //    MyCalendar.Navigate(TargetDate - MyCalendar.NavigatedDate);
            //}
            //else
            //{
            //    //The calendar handles unrepresentable dates so just use the min or max bounds of TimeSpan depending on if we tried to add or subtract months.
            //    MyCalendar.Navigate(amount > 0 ? TimeSpan.MaxValue : TimeSpan.MinValue);
            //}
        }
    }
}
