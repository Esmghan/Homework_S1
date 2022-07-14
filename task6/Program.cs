Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = number % 2;

if (even == 0) { 
    Console.WriteLine("Да");
}
else { 
    Console.WriteLine("Нет");
}