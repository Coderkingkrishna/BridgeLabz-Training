using System;
class LineAndDistance{
	static double FindDistance(double X1,double Y1,double X2,double Y2){
		double Distance=Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
		return Distance;
	}

	static double[] FindLineEquation(double X1,double Y1,double X2,double Y2){
		double[] Result=new double[2];
		double M=(Y2-Y1)/(X2-X1);
		double B=Y1-(M*X1);
		Result[0]=M;
		Result[1]=B;
		return Result;
	}

	static void Main(){
		Console.WriteLine("Enter X1:");
		double X1=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Y1:");
		double Y1=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter X2:");
		double X2=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Y2:");
		double Y2=double.Parse(Console.ReadLine());

		double Distance=FindDistance(X1,Y1,X2,Y2);
		double[] Line=FindLineEquation(X1,Y1,X2,Y2);

		Console.WriteLine("Euclidean Distance: "+Distance);
		Console.WriteLine("Slope (m): "+Line[0]);
		Console.WriteLine("Y-Intercept (b): "+Line[1]);
		Console.WriteLine("Equation: y = "+Line[0]+"x + "+Line[1]);
	}
}
