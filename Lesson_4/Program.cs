Console.WriteLine("Detailed Variables - Yazılım Academy!");

//TimeSpan timeSpan1 = new TimeSpan(15, 12, 0, 0);
//TimeSpan timeSpan1 = TimeSpan.FromDays(15);
//Console.WriteLine($"timeSpan1.TotalDays: {timeSpan1.TotalDays}");

#region Part-1
//Console.WriteLine($"timeSpan1.Seconds: {timeSpan1.Seconds}");
//Console.WriteLine($"timeSpan1.TotalSeconds: {timeSpan1.TotalSeconds}");
//Console.WriteLine($"timeSpan1.TotalMilliseconds: {timeSpan1.TotalMilliseconds}");
//Console.WriteLine($"timeSpan1.TotalMicroseconds: {timeSpan1.TotalMicroseconds}");
//Console.WriteLine($"timeSpan1.Ticks: {timeSpan1.Ticks}");
#endregion

DateTime dateTime1 = DateTime.Now;
DateTime dateTime2 = new DateTime(2002, 10, 29);

TimeSpan timeSpan2 = dateTime1 - dateTime2;

Console.WriteLine($"Difference: {timeSpan2.TotalDays}");
