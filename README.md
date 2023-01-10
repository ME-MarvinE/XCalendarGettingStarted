# .NET

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Core/

#### Now you can use the Calendar
```C#
public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();
```

# Xamarin Forms

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Forms/

#### Create a Calendar in your ViewModel
```C#
public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();
```

#### Add the following xmlns to your page or view
```xaml
xmlns:xc="clr-namespace:XCalendar.Forms.Views;assembly=XCalendar.Forms"
```

#### Bind to the properties of your Calendar
```xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    x:Class="App1.MainPage"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:xc="clr-namespace:XCalendar.Forms.Views;assembly=XCalendar.Forms">
    
        <xc:CalendarView
            Days="{Binding MyCalendar.Days}"
            DaysOfWeek="{Binding MyCalendar.DayNamesOrder}"
            NavigatedDate="{Binding MyCalendar.NavigatedDate}"/>

</ContentPage>

```

# .NET MAUI

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Maui/

#### Create a Calendar in your ViewModel
```C#
public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();
```

#### Add the following xmlns to your page or view
```xaml
xmlns:xc="clr-namespace:XCalendar.Maui.Views;assembly=XCalendar.Maui"
```

#### Bind to the properties of your Calendar
```xaml
<ContentPage
    x:Class="MauiApp1.MainPage"
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:xc="clr-namespace:XCalendar.Maui.Views;assembly=XCalendar.Maui">
    
        <xc:CalendarView
            Days="{Binding MyCalendar.Days}"
            DaysOfWeek="{Binding MyCalendar.DayNamesOrder}"
            NavigatedDate="{Binding MyCalendar.NavigatedDate}"/>

</ContentPage>
```
