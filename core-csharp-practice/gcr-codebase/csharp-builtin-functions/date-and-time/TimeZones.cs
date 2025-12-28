using System;
class TimeZones{
	static void ShowTime(string zoneId){
		TimeZoneInfo tz=TimeZoneInfo.FindSystemTimeZoneById(zoneId);
		DateTimeOffset utc=DateTimeOffset.UtcNow;
		DateTimeOffset time=TimeZoneInfo.ConvertTime(utc,tz);
		Console.WriteLine(zoneId+" : "+time);
	}
	static void Main(){
		ShowTime("GMT Standard Time");
		ShowTime("India Standard Time");
		ShowTime("Pacific Standard Time");
	}
}
