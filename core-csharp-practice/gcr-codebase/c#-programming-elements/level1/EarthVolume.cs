using System;
class EarthVolume{
	static void Main(){
		int Radius = 6378;
		double VolInKm = (4/3) * Math.PI * Math.Pow(Radius , 3);
		double VolInMiles = VolInKm * 1.6;
		Console.WriteLine("The volume of earth in cubic kilometers is "+VolInKm+" and cubic miles is "+VolInMiles);
	}
}