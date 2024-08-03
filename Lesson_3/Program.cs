using System.Globalization;

Console.WriteLine("Detailed Variables - Yazılım Academy!");

#region Part-1
//DateTimeOffset dateTimeOffset1 = new DateTimeOffset(2024, 1, 15, 14, 0, 0, TimeSpan.FromHours(3));

//// 0 - 1 - 2 - 3

//TimeSpan targetTimeZone = TimeSpan.FromHours(1);

//DateTimeOffset dateTimeOffset2 = dateTimeOffset1.ToOffset(targetTimeZone);

//Console.WriteLine($"dateTimeOffset1: {dateTimeOffset1.ToString("F", new CultureInfo("tr-TR"))}");

//Console.WriteLine($"dateTimeOffset2: {dateTimeOffset2}");

//DateTimeOffset dateTimeOffset3 = DateTimeOffset.Now;
//DateTimeOffset dateTimeOffset4 = DateTimeOffset.UtcNow;

//DateTimeOffset dateTimeOffset5 = DateTime.Now;
//DateTimeOffset dateTimeOffset6 = DateTime.UtcNow;

//Console.WriteLine($"DateTimeOffset.Now: {dateTimeOffset3}");
//Console.WriteLine($"DateTimeOffset.UtcNow: {dateTimeOffset4}");

//Console.WriteLine($"DateTime.Now: {dateTimeOffset5}");
//Console.WriteLine($"DateTime.UtcNow: {dateTimeOffset6}");
#endregion

DateTimeOffset dateTimeOffset7 = DateTimeOffset.Parse("8/1/2024 4:43:11 PM +03:00");

Console.WriteLine($"dateTimeOffset7: {dateTimeOffset7}");

string data = "31 Temmuz 2024 14:30:00 +03:00";

DateTimeOffset dateTimeOffset8 = DateTimeOffset.ParseExact(
    data,
    "dd MMMM yyyy HH:mm:ss zzz",
    CultureInfo.CreateSpecificCulture("tr-TR"));

Console.WriteLine($"dateTimeOffset8: {dateTimeOffset8}");
