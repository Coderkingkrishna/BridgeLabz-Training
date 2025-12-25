using System;
class OtpGenerator{
	static int GenerateOtp(){
		Random Random = new Random();
		int Otp =Random.Next(100000,1000000);
		return Otp;
	}

	static bool IsUnique(int[] Otps){
		for(int i=0; i <Otps.Length;i++){
			for(int j=i+1;j<Otps.Length; j++){
				if(Otps[i] ==Otps[j]){
					return false;
				}
			}
		}
		return true;
	}

	static void Main(){
		int[] Otps=new int[10];

		for(int i=0;i< Otps.Length; i++){
			Otps[i]= GenerateOtp();
		}

		Console.WriteLine("Generated OTPs:");
		for(int i=0;i<Otps.Length;i++){
			Console.WriteLine(Otps[i]);
		}

		bool Result =IsUnique(Otps);
		if(Result){
			Console.WriteLine("All OTPs are Unique");
		}else{
			Console.WriteLine("Duplicate OTPs Found");
		}
	}
}
