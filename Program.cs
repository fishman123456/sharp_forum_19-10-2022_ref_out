// See https://aka.ms/new-console-template for more information
// Задача 1
// Используя REF и OUT переменную i и получить её с OUT.
//
// Создать одномерный массив string на 1 элемент.
// Создать методы на заполнение массива с размером i, 
// заполнение с клавиатуры, так же предусмотреть вывод его на 
// Задача 2
// Метод, изменяющий свой аргумент
class Program
{
    static void changeNum(ref int n)
    {
        n = 100;
    }
    static int test(double a, out double b, out double c)
    {
        int i = (int)a;
        b = a * a;
        c = a * a * a;
        return i;

    }
    static void Main()
    {
        {
            //REF
            int x = 0;
            Console.WriteLine("Переменная х до передачи по ссылке: {0}\n", x);
            changeNum(ref x);
            Console.WriteLine("Переменная х после передачи по ссылке: {0}\n", x);
            //OUT
            int i;
            double c, b, a = 5.5;
            i=test(a, out b, out c);
            Console.WriteLine("Оригинальная переменная: {0}\n", a);
            Console.WriteLine("Оригинальная переменная int: {0}\n", i);
            Console.WriteLine("a^2 : {0}\n",b);
            Console.WriteLine("a^3 : {0}\n",c);
        }
    }
}