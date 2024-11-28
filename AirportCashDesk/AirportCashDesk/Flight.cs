using System;
using System.Collections.Generic;
using System.Linq;

public class Flight
{
    public int FlightNumber { get; set; }
    public string Route { get; set; }
    public List<string> StopPoints { get; set; }
    public DateTime DepartureTime { get; set; }
    public List<DayOfWeek> FlightDays { get; set; }
    public int AvailableSeats { get; set; }

    // Властивість для конвертації списку зупинок в строку
    public string StopPointsString => StopPoints != null ? string.Join(", ", StopPoints) : "";

    // Властивість для конвертації списку днів відправлення в строку українською
    public string FlightDaysString => FlightDays != null
        ? string.Join(", ", FlightDays.Select(day => GetUkrainianDayOfWeek(day)))
        : "";

    // Конструктор класу Flight
    public Flight(int flightNumber, string route, List<string> stopPoints, DateTime departureTime, List<DayOfWeek> flightDays, int availableSeats)
    {
        FlightNumber = flightNumber;
        Route = route;
        StopPoints = stopPoints;
        DepartureTime = departureTime;
        FlightDays = flightDays;
        AvailableSeats = availableSeats;
    }

    // Метод для перекладу днів тижня на українську
    private string GetUkrainianDayOfWeek(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Monday: return "Понеділок";
            case DayOfWeek.Tuesday: return "Вівторок";
            case DayOfWeek.Wednesday: return "Середа";
            case DayOfWeek.Thursday: return "Четвер";
            case DayOfWeek.Friday: return "П'ятниця";
            case DayOfWeek.Saturday: return "Субота";
            case DayOfWeek.Sunday: return "Неділя";
            default: return "";
        }
    }
}
