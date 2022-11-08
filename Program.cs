internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Lütfen bir sayı giriniz: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Girilen sayıların toplamı: ");
        Metotlar ins = new Metotlar();
        ins.EkranaYazdır(Convert.ToString(Topla(a, b)));

        Console.Write("Faktoriyeli alınacak sayıyı giriniz: ");
        int p = int.Parse(Console.ReadLine()); ;
        // displaying result by calling the function
        Console.WriteLine("Factorial is : " + factorial1(p));

        Console.WriteLine("Dizi: ");
        int[] list = { 1, 2, 3, 4, 5 };
        ins.Sum(list);

        //Method overloading
        Console.WriteLine("Method overloading");
        var s = new Sum();
        Console.WriteLine(s.GetSum());
        Console.WriteLine(s.GetSum(20));
        Console.WriteLine(s.GetSum(20, 30));

        //recursion
        Console.WriteLine("6! : "+Factorial(6));

        //this keyword
        Console.WriteLine("his keyword");
        var ts = new Test();
        ts.exec();
        
        //hiding methods
        var d = new Derived();
        d.Info();
        
    }

    //Toplama
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }

    //Factorial 
    static int factorial1(int n)
    {
        int f = 1;

        // Method to calculate the
        // factorial of a number
        for (int i = 1; i <= n; i++)
        {
            f = f * i;
        }

        return f;
    }


    //recursion
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }


    class Base
    {
        public void Info()
        {
            Console.WriteLine("This is Base class");
        }
    }

    class Derived : Base
    {
        public new void Info()
        {
            base.Info();
            Console.WriteLine("This is Derived class");
        }
}


}

class Metotlar
{
    public void EkranaYazdır(String veri)
    {
        Console.WriteLine(veri);
    }


    public void Sum(params int[] list)
    {
        Console.WriteLine($"There are {list.Length} items");

        int sum = 0;

        foreach (int i in list)
        {
            sum = sum + i;
        }

        Console.WriteLine($"Their sum is {sum}");
    }

}

class Sum
{
    public int GetSum()
    {
        return 0;
    }

    public int GetSum(int x)
    {
        return x;
    }

    public int GetSum(int x, int y)
    {
        return x + y;
    }
}

class Test
{
    int x = 1;

    public void exec()
    {
        int x = 3;

        Console.WriteLine(this.x);
        Console.WriteLine(x);
    }
}


//C# overriding methods
/*
Base[] objs = { new Base(), new Derived(), new Base(),
                        new Base(), new Base(), new Derived() };

foreach (Base obj in objs)
{
    obj.Info();
}

class Base
{
    public virtual void Info()
    {
        Console.WriteLine("This is Base class");
    }
}

class Derived : Base
{
    public override void Info()
    {
        Console.WriteLine("This is Derived class");
    }
}*/