using System;
class CollinearPoints{
	static bool CheckCollinearBySlope(double X1, double Y1,double X2 ,double Y2 ,double X3, double Y3){
		double SlopeAB=(Y2-Y1)/(X2-X1);
		double SlopeBC=(Y3-Y2)/(X3-X2);
		double SlopeAC=(Y3-Y1)/(X3-X1);
		if(SlopeAB ==SlopeBC && SlopeBC == SlopeAC){
			return true;
		}
		return false;
	}

	static bool CheckCollinearByArea(double X1 ,double Y1, double X2 ,double Y2,double X3,double Y3){
		double Area=X1*(Y2-Y3)+X2*(Y3-Y1)+X3*(Y1-Y2);
		if(Area== 0){
			return true;
		}
		return false;
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
		Console.WriteLine("Enter X3:");
		double X3=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Y3:");
		double Y3=double.Parse(Console.ReadLine());
		bool ResultSlope=CheckCollinearBySlope(X1,Y1,X2,Y2,X3,Y3);
		bool ResultArea=CheckCollinearByArea(X1,Y1,X2,Y2,X3,Y3);
		if(ResultSlope){
			Console.WriteLine("Collinear using Slope Formula");
		}
		else{
			Console.WriteLine("Not Collinear using Slope Formula");
		}

		if(ResultArea){
			Console.WriteLine("Collinear using Area Formula");
		}
		else{
			Console.WriteLine("Not Collinear using Area Formula");
		}
	}
}
