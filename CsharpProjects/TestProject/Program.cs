// Switch Statement

// int employeeLevel = 200;
// int employeeLevel = 201;
// int employeeLevel1 = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel1)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// /* for statement */

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

/* Do-while statement*/

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);