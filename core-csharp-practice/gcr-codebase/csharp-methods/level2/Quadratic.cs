using System;
class Quadratic{
	static double[] FindRoots(double A,double B,double C){
		double Delta= Math.Pow(B, 2)-4* A*C;

		if(Delta>0){
			double Root1= (-B+Math.Sqrt(Delta))/(2*A);
			double Root2= (-B-Math.Sqrt(Delta))/(2*A);
			return new double[]{Root1,  Root2};
		}

		if(Delta==0){
			double Root=-B/(2*A);
			return new double[]{Root};
		}

		return new double[]{};
	}

	static void Main(){
		Console.WriteLine("Enter Value of a:");
		double A =double.Parse(Console.ReadLine());

		Console.WriteLine("Enter Value of b:");
		double B= double.Parse(Console.ReadLine());

		Console.WriteLine("Enter Value of c:");
		double C =double.Parse(Console.ReadLine());

		double[] Roots=FindRoots(A,B,C);

		if(Roots.Length==2){
			Console.WriteLine("Two Roots are:");
			Console.WriteLine(Roots[0] );
			Console.WriteLine(Roots[1]);
		}
		
		else if(Roots.Length==1){
			Console.WriteLine("One Root is:  ");
			Console.WriteLine(Roots[0]);
		}
		else{
			Console.WriteLine("No Real Roots");
		}
	}
}
