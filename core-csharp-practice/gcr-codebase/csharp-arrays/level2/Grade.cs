using System;
class Grade{
    public static void Main(){
        int Number = int.Parse(Console.ReadLine());
        int[ ,]Grad = new int[Number,4];
        for(int i = 0; i < Number; i++){
            Grad[i,0] = int.Parse(Console.ReadLine());
            Grad[i,1] = int.Parse(Console.ReadLine());
            Grad[i,2] = int.Parse(Console.ReadLine());
            Grad[i,3] = (Grad[i,0] + Grad[i,1] + Grad[i,2]) / 3;            
        }
        for(int i = 0; i <Number; i++){
            if(Grad[i,3] >= 80) Console.WriteLine("Level 04, above agency-normalized standards");
            else if(Grad[i,3] >= 70) Console.WriteLine("Level 04, above agency-normalized standards");
            else if(Grad[i,3] >= 60) Console.WriteLine("Level 03, at agency-normalized standards");
            else if(Grad[i,3] >= 50) Console.WriteLine("Level 02, below, but approaching  agency-normalized standards");
            else if(Grad[i,3] >= 40) Console.WriteLine("Level 01, well below agency-normalized standards");
            else Console.WriteLine("Remedial Standards");
        }
    }
}