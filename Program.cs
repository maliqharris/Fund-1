// See https://aka.ms/new-console-template for more information

for(int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}




Random rand = new Random();
for(int i = 1; i < 6; i++)
{
   
    Console.WriteLine(rand.Next(10,20));
}




Random rand = new Random();
int sum = 0;
Console.WriteLine("Nums used -");
for(int i = 1; i < 6; i++)
{
    int nums = rand.Next(10,20);
    sum += nums;
    
    Console.WriteLine(nums);
}
Console.WriteLine("Sum of Nums - " + sum);






for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 != 0 )
    {
        Console.WriteLine(i);
    } else if(i % 5 == 0 && i % 3 != 0) {
        Console.WriteLine(i);
    }
    
}     





for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 != 0 )
    {
        Console.WriteLine("Fizz");
    } else if(i % 5 == 0 && i % 3 != 0) {
        Console.WriteLine("Buzz");
    } 
    
}   





for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 != 0 )
    {
        Console.WriteLine("Fizz");
    } else if(i % 5 == 0 && i % 3 != 0) {
        Console.WriteLine("Buzz");
    } else if(i % 5 == 0 && i % 3 == 0){
        Console.WriteLine("FizzBuzz");
    }
    
}   

