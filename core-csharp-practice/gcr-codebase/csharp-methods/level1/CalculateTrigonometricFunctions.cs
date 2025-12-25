using System;
class TrigonometricCalculator{
	static double[] CalculateTrigonometricFunctions(double Angle){
		double Radian=Angle*Math.PI/180;
		double Sine=Math.Sin(Radian);
		double Cosine=Math.Cos(Radian);
		double Tangent=Math.Tan(Radian);
		return new double[]{Sine,Cosine,Tangent};
	}

	static void Main(){
		Console.WriteLine("Enter Angle in Degrees:");
		double Angle=double.Parse(Console.ReadLine());

		double[] Result=CalculateTrigonometricFunctions(Angle);
		Console.WriteLine("Sine:"+Result[0]);
		Console.WriteLine("Cosine:"+Result[1]);
		Console.WriteLine("Tangent:"+Result[2]);
	}
}
