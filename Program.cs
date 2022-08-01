void Zadacha1()
{
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;

if(number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
Console.Write("Максимальное число явлется:" + " " + max);
}



void Zadacha2()
{
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;

max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.Write("Максимальное число является:" + " " + max);
}



void Zadacha3()
{
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number %2 == 0)
{
    Console.Write("Число:" + " " + number + " " + "является четным");
}
else
{
   Console.Write("Число:" + " " + number + " " + "не является четным"); 
}
}


void Zadacha4()
{
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine("Все четные числа от 1 до" + " " + number + ":");
while(count <= number)
{
    if(count %2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
}






