//int x = int.Parse(Console.ReadLine());

//switch (x)
//{
//    case 0:
//        Console.WriteLine("Zero");
//        break;

//    case 1:
//        Console.WriteLine("One");
//        break;

//    case 10:
//        Console.WriteLine("Ten");
//        break;

//    case 22:
//        Console.WriteLine("Twenty two");
//        break;

//    default:
//        Console.WriteLine("incorrect number");
//        break;
//}


int y = int.Parse(Console.ReadLine());
if (y < 0 && y > 10)
{
    Console.WriteLine("Incorrect number");
}
else
{
    switch (y)
    {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Mardood");
            break;

        case 6:
            Console.WriteLine("F");
            break;
        case 7:
            Console.WriteLine("D");
            break;
        case 8:
            Console.WriteLine("C");
            break;
        case 9:
            Console.WriteLine("B");
            break;
        case 10:
            Console.WriteLine("A");
            break;
    }
}
