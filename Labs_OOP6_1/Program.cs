//Для каждого варианта необходимо создать три массива a, b и с размерами
//соответственно n1, n2 и n3 (n1≠n2≠n3). В массив а занести значения функции f(x)
//согласно варианту (при возникновении исключения заносить нули).
//Массив b заполнить случайными числами (среди них должны быть и отрицательные числа и нули).
//Массив с формируется согласно варианту. Предусмотреть и обработать возникающие при этом
//исключительные ситуации (деление на ноль, корень из отрицательного числа,
//арифметическое переполнение, выход за пределы диапазона индексов массива и т.п.).

class Program
{
    static double foo_a(double x)
    {
        double p = 1 - x * x * x;
        if (p < 0)
        {
            return 0;
        }
        double d = 1.0 / 3.0;
        double r = Math.Pow(p, d);
        return r;
    }

    static double foo_c(double a, double b)
    {
        if (a + b < 1)
        {
            return 0;
        }
        return Math.Log(a + b);
    }
    static void printArray(double[] arr)
    {
        string s = "";
        foreach (double x in arr)
        {
            s+= x.ToString() + " ";  
        }
        Console.WriteLine(s);
    }
    static void Main(string[] args)
    {
        int n1 = (int)((Math.Abs(-2) + Math.Abs(2)) / 0.2+1);
        double[] a = new double[n1];
        for (double x = -2, i = 0; x <= 2; x += 0.2, i++)
        {
            a[(int)i] = Math.Round(foo_a(x),2);
        }
        int n2 = 25;
        int n3 = n1 - 1;
        double[] b =new double[n2];
        Random rand = new Random();
        for (int i = 0; i < n2; i++)
        {
            b[i] = Math.Round(rand.NextDouble() * 100,2);
            if (rand.Next(0, 2) == 0)
            {
                b[i] = -b[i];
            }
        }
        double[] c = new double[n3];
        for (int i = 1; i < n3; i++)
        {
            c[i] = Math.Round(foo_c(a[i - 1], b[i + 1]),2);
        }
        printArray(a);
        printArray(b);
        printArray(c);
    }
}
