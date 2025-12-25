# Basic Usage
## .NET

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Core [![NuGet](https://img.shields.io/nuget/v/XCalendar.Core.svg?label=NuGet)](https://www.nuget.org/packages/XCalendar.Core/)

#### Now you can use the Calendar
```C#
public Calendar MyCalendar { get; set; } = new Calendar();
```

## Xamarin Forms

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Forms [![NuGet](https://img.shields.io/nuget/v/XCalendar.Forms.svg?label=NuGet)](https://www.nuget.org/packages/XCalendar.Forms/)

#### Create a Calendar in your ViewModel
```C#
public Calendar MyCalendar { get; set; } = new Calendar();
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

*Alternatively, these properties can be set directly from code-behind without the use of MVVM.*

#### Youtube Tutorial (Outdated - Uses version 1.2.1 for Xamarin Forms)
[![Beautiful, Extensive and FREE Calendar Control for Xamarin.Forms](https://img.youtube.com/vi/aw7b_Xt1fng/0.jpg)]([https://www.youtube.com/watch?v=bmkizbS4jb4](https://www.youtube.com/watch?v=aw7b_Xt1fng))

## .NET MAUI

#### Install the NuGet package
* https://www.nuget.org/packages/XCalendar.Maui [![NuGet](https://img.shields.io/nuget/v/XCalendar.Maui.svg?label=NuGet)](https://www.nuget.org/packages/XCalendar.Maui/)

#### Create a Calendar in your ViewModel
```C#
public Calendar MyCalendar { get; set; } = new Calendar();
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

*Alternatively, these properties can be set directly from code-behind without the use of MVVM.*
