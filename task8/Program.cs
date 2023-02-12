Console.WriteLine("Введите цифру: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Четные числа:" );
for(int i = 1; i <= N; i++) 
{
   if(i % 2 == 0){
    //Console.WriteLine("Четные числа: " );
    Console.Write(i);}
}