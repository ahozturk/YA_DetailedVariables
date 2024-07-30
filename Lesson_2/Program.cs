using System.Globalization;

Console.WriteLine("Detailed Variables - Yazılım Academy!");

//DateTime, TimeSpan, DateTimeOffset
#region Part-1
//DateTime dateTime1 = DateTime.Now;
//Console.WriteLine($"dateTime1: {dateTime1}");

//DateTime dateTime2 = DateTime.UtcNow;
//Console.WriteLine($"dateTime2: {dateTime2}");

//DateTime dateTime3 = new DateTime(2000, 2, 20, 20, 0, 0);
//Console.WriteLine($"dateTime3: {dateTime3}");
//Console.WriteLine($"dateTime3 (TR): {dateTime3.ToString("dd/MM/yyyy HH:mm")}");
//Console.WriteLine($"dateTime3 (TR): {dateTime3.ToString("g", new CultureInfo("tr-TR"))}");
#endregion

string data = "20.April.2000 20:00";

DateTime dateTimeFromData = DateTime.ParseExact(
    data,
    "dd.MMMM.yyyy HH:mm",
    CultureInfo.CreateSpecificCulture("en-US"));

Console.WriteLine($"dateTimeFromData: {dateTimeFromData.ToString("D", new CultureInfo("tr-TR"))}");
