Console.WriteLine("Enter number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());
switch(number)
{
    case 1:
        Console.WriteLine("Рабочий день");
        break;
    case 2:
        Console.WriteLine("Рабочий день");
        break;
    case 3:
        Console.WriteLine("Рабочий день");
        break;
    case 4:
        Console.WriteLine("Рабочий день");
        break;
    case 5:
        Console.WriteLine("Рабочий день");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}

