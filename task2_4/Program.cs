//Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
//в числе, которые являются делителями этого числа
int  n, sum = 0, m = 1;         
   Console.Write("Ввести число: ");      
   n = int.Parse(Console.ReadLine());     
       while(n > 0)      
       {      
        m = n % 10;              
        n = n / 10;
		  sum = sum + (n - m);      
       }  
		 if (n / m == 0)
		 {
			
		 }    
   Console.Write("Сумма " + sum); 