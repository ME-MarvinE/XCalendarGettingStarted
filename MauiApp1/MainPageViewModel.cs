using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
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
            MyCalendar.NavigateCalendar(amount);
        }
    }
}
