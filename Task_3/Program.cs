// See https://aka.ms/new-console-template for more information
  

                                        //Задание 1
//______________________________________________________________________________________________
// создаем две строки
string firstString;
string secondString;


// считываем вводимые с клавиатуры строки и присваиваем переменным firstString и secondString
Console.WriteLine("Введите первую строку: ");
firstString = Console.ReadLine();
Console.WriteLine("Введите вторую строку : ");
secondString = Console.ReadLine();

// выполним 5 разных методов со строками
// 1 метод
Console.WriteLine($"В первой строке {firstString.Length} знаков.");
// 2 метод
Console.WriteLine($"Результат сложения двух строк через пробел выглядит так: {firstString + " " + secondString}.");
// 3 метод
Console.Write("Вторая строка с добавлением в середину второй строки, первой строки выглядит так: ");
Console.WriteLine($"{secondString.Insert(secondString.Length/2, firstString)}.");
// 4 метод
Console.WriteLine($"Первая строка приведенная к верхнему регистру выглядит так: {firstString.ToUpper()}.");
// 5 метод
// результат обрезки первой строки первого и последнего символа присвоим строке firstString
firstString = firstString.Substring(1,firstString.Length-2);
Console.WriteLine(firstString);
//_______________________________________________________________________________________________________


                                        //Задание 2
//_______________________________________________________________________________________________________
int firstInteger;
int secondInteger;
do
{ 
    Console.WriteLine("Введите первое целое число");
    string firstIntRead = Console.ReadLine();
    bool result = Int32.TryParse(firstIntRead, out int i);
    if (result)
    {
        firstInteger = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);
do
{ 
    Console.WriteLine("Введите первое целое число");
    string secondIntRead = Console.ReadLine();
    bool result = Int32.TryParse(secondIntRead, out int i);
    if (result)
    {
        secondInteger = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

Console.WriteLine($"{firstInteger} + {secondInteger} = {firstInteger + secondInteger}");
Console.WriteLine($"{firstInteger} - {secondInteger} = {firstInteger - secondInteger}");
Console.WriteLine($"{firstInteger} / {secondInteger} = {firstInteger / secondInteger}");
Console.WriteLine($"{firstInteger} * {secondInteger} = {firstInteger * secondInteger}");

Console.WriteLine($"{firstInteger} > {secondInteger} = {firstInteger > secondInteger}");
Console.WriteLine($"{firstInteger} < {secondInteger} = {firstInteger < secondInteger}");
Console.WriteLine($"{firstInteger} == {secondInteger} = {firstInteger == secondInteger}");
Console.WriteLine($"{firstInteger} != {secondInteger} = {firstInteger != secondInteger}");
Console.WriteLine($"({firstInteger}>0) && ({secondInteger}>0) = {(firstInteger>0) && (secondInteger>0)}");
Console.WriteLine($"({firstInteger}>0) || ({secondInteger}>0) = {(firstInteger>0) || (secondInteger>0)}");

Console.ReadLine();

