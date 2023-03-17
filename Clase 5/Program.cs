using System;

class program{
    static void Main(string[]args) {
        Console.Write("Ingrese numero: ");
        int num = int.Parse(Console.ReadLine());
        bool siesprimo = true; 

        for (int i = 2; i<num; i++ ) {
            if(num % i==0) {
                siesprimo = false;
                break;
            }
        } 
      
      if (siesprimo) {
        Console.WriteLine(num + " Es numero primo");

      } else {
        Console.WriteLine(num + " No es numero primo");
      }

    
    }
}