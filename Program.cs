using System;
using System.IO;

namespace midterm{
    class program {
        static void Main(string[] arg){
        
        /*
          while(i <= 12){
            Console.WriteLine(i + " * "+ x +" :" +i*x );
            i++;
          }
          */

          /*
        int sum = 0;

          for(int i = 1,j = 0 ; i<=10; i++,j++){
            int t = (int)Math.Pow(2,j); //สองยกกำลัง 
            sum = sum +  (i*t); //ผลรวม 1 * สองยกกำลัง j
            Console.WriteLine(i + " * " + t +" : " + sum);
            
          }
            bool d = true;
         */
        /*
         int i = 1 ;
        int sum = 0;
         do{
            sum = sum +i;
            Console.WriteLine(i +" : " +sum);
            i++;
         }while(i <= 5);

        int a = 1 ;
        int f = 0;

        while(a<=5){
            f += a;
            a++;
        }
         
        
        Console.WriteLine(sum +" : "+f );
        */
/*
        for(int i = 1; i <= 5; i++) {
            for(int j = 1; j <= i; ++j) {
                Console.Write(j);
            }

        Console.WriteLine(" i++");
        }
 //Console.WriteLine("Sum is: {0}", sum);
        }
        */

        int x = int.Parse(Console.ReadLine());
        //first row
        for(int i = 1 ; i<= x ;i++){
            Console.Write("*");
        }
        Console.WriteLine();

        //2nd part 
        for(int i = 1 ; i <= x-2 ;i++){
             Console.Write("*");
            for(int j = 1;j <=x-2;j++){
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }

        //3rd part
         for(int i = 1 ; i<= x ;i++){
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
}