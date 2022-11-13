

// Калинин Павел 13.11.2022 
// Знакомство с языками программирования (семинары) 
// Урок 9. Как не нужно писать код. Часть 3
// Домашняя работа

bool isRepeat = true; 
string s = "";
string taskName = "";

string SeqIntNumbers(int begin, int end) {
    if (begin > end) return "";
    else return $"{begin} {SeqIntNumbers(++begin, end)}";
}

taskName = "Задание  №1. Показать натуральные числа от M до N, N и M заданы";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("-----------------------------------\n\r"+taskName);
    Console.Write("Введите натуральное число M: ");
    int M = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите натуральное число N: ");
    int N = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    Console.WriteLine(SeqIntNumbers(M,N));
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


long SumIntNumbers(int begin, int end) {
    if (begin > end) return 0;
    else return begin + SumIntNumbers(++begin, end);
}

taskName = "Задание  №2. Найти сумму элементов от M до N, N и M заданы";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("-----------------------------------\n\r"+taskName);
    Console.Write("Введите целое число M: ");
    int M = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите целое число N: ");
    int N = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    Console.WriteLine(SumIntNumbers(M,N));
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


long Deep = 0;
long AckermanFunction(long m,long n) {
        Deep++;
        if(m == 0) 
            return n+1;
        else if(m > 0 && n == 0)
            return AckermanFunction(m-1,1);
        else 
            return AckermanFunction(m-1, AckermanFunction(m,n-1));
}

taskName = "Задание  №3. Написать программу вычисления функции Аккермана";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("-----------------------------------\n\r"+taskName);
    Console.Write("Введите не отрицательное целое число явяющееся первым аргументом функции Аккермана: ");
    int m = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите не отрицательное целое число явяющееся вторым аргументом функции Аккермана: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if(m >= 0 && n >= 0) Console.WriteLine(AckermanFunction(m,n));
    else Console.WriteLine("Аргументы функции Аккермана должны быть положительными числами.");
    Console.WriteLine($"Глубина рекурсии {Deep}");    
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


string SeqLikeFibonacci(int N, int num1, int num2) {
    if (N <= 0) return "";
    else { 
        int num3 = num1+num2;
        return $"{num3} {SeqLikeFibonacci(--N,num2,num3)}";
    }    
}

taskName = "Задание  №4. Написать программу показывающие первые N чисел,"
         + " для которых каждое следующее равно сумме двух предыдущих."
         + " Первые два элемента последовательности задаются пользователем";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("-----------------------------------\n\r"+taskName);
    Console.Write("Введите целое число N явяющееся кол-вом элементов последовательности: ");
    int N = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите целое число явяющееся первым элементом последовательности: ");
    int num1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите целое число явяющееся вторым элементом последовательности: ");
    int num2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if(N == 1)      Console.WriteLine(num1);
    else if(N == 2) Console.WriteLine($"{num1} {num2}");
    else if(N > 2)  Console.WriteLine($"{num1} {num2} {SeqLikeFibonacci(N-2,num1,num2)}");
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    
