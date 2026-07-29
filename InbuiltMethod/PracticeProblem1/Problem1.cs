using System;
public class Date_Time
{
    public static void Main()
    {
        DateTimeOffset utc = DateTimeOffset.UtcNow;
        Console.WriteLine(utc);

        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        TimeZoneInfo gmt = TimeZoneInfo.Utc;

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utc, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utc, pst);
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utc, gmt);

        Console.WriteLine($"UTC time: {utc}");
        Console.WriteLine($"IST time: {istTime}");
        Console.WriteLine($"PST time: {pstTime}");
        Console.WriteLine($"GMC time: {gmtTime}");
    }
}