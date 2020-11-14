using System;

namespace Class2
{
    public class Product
    {
        private string NameT;
        private int Price;
        private Currency Cost;
        private int Quantity;
        private string Producer;
        private int Weight;

        public Product()
        {
            Name="товар";
            Price=10;
            Cost = new Currency("Valut", 28.28);
            Quantity =10;
            Producer="Фірма";
            Weight=10;

        }
        public Product(string name, int price, Currency cost,int q, string firm, int weight)
        {
            NameT = name;
            Price = price;
            Cost = cost;
            Quantity = q;
            Producer = firm;
            Weight = weight;
        }
        public Product(int price, string name, Currency cost, int q, string firm, int weight)
        {
            NameT = name;
            Price = price;
            Cost = cost;
            Quantity = q;
            Producer = firm;
            Weight = weight;
        }
        public Product(Product p1)
        {
            NameT = p1.NameT;
            Price = p1.Price;
            Cost = p1.Cost;
            Quantity = p1.Quantity;
            Producer = p1.Producer;
            Weight = p1.Weight;
        }
        public static void SetNameT(Product p1)
        {
            Console.WriteLine("Введіть назву товару:");
            string y = Console.ReadLine();
            p1.NameT = y;
        }
        public static void SetPrice(Product p1)
        {
            Console.WriteLine("Введіть ціну товару:");
            int y = int.Parse(Console.ReadLine());
            p1.Price = y;
        }
        public static void SetCost(Product p1)
        {
            Console.WriteLine("Валюту та її курс:");
            string y = Console.ReadLine();
            string[] arr1 = y.Split(' ');
            int[] arr2 = new int[2];
            arr2[1] = int.Parse(arr1[1]);
            p1.Cost.Name = arr1[0];
            p1.Cost.ExRate = arr2[1];
        }
        public static void SetQuantity(Product p1)
        {
            Console.WriteLine("Введіть кількість товару:");
            int y = int.Parse(Console.ReadLine());
            p1.Quantity = y;
        }
        public static void SetProducer(Product p1)
        {
            Console.WriteLine("Введіть назву фірми:");
            string y = Console.ReadLine();
            p1.Producer = y;
        }
        public static void SetWeight(Product p1)
        {
            Console.WriteLine("Введіть вагу одиниці товару:");
            int y = int.Parse(Console.ReadLine());
            p1.Weight = y;
        }

        public static void GetNameT(Product p1)
        {
            Console.WriteLine("Назва товару: {0}", p1.NameT);
        }
        public static void GetPrice(Product p1)
        {
            Console.WriteLine("Ціну товару: {0}", p1.Price);
        }
        public static void GetCost(Product p1)
        {
            Console.WriteLine("Валюту: {0}", p1.Cost.Name);
            Console.WriteLine("Курс: {0}", p1.Cost.ExRate);
        }
        public static void GetQuantity(Product p1)
        {
            Console.WriteLine("Кількість товару: {0}", p1.Quantity);
        }
        public static void GetProducer(Product p1)
        {
            Console.WriteLine("Назва фірми: {0}", p1.Producer);
        }
        public static void GetWeight(Product p1)
        {
            Console.WriteLine("Введіть вагу одиниці товару: {0}", p1.Weight);
        }

        public void GetPriceInUAH(Product p1)
        {
            double res = p1.Price  * p1.Cost.ExRate;
            Console.WriteLine("Ціна товару в гривнях {0}", res);
        }
        public void GetTotalPriceInUAH(Product p1)
        {
            double res = p1.Price * p1.Quantity;
            Console.WriteLine("Ціна товару всього {0}", res);
        }
        public void GetTotalWeight(Product p1)
        {
            double res = p1.Weight * p1.Quantity;
            Console.WriteLine("Вага товару всього {0}", res);

        }
    }
    public class Currency
    {
       internal string Name;
        internal double ExRate;
        public Currency()
        {
            Name = "Valut";
            ExRate = 28.28;
        }
        public Currency(string val, double c)
        {
            Name = val;
            ExRate = c;
        }
        public Currency(double c, string val)
        {
            Name = val;
            ExRate = c;
        }
        public Currency(Currency curr1)
        {
            Name = curr1.Name;
            ExRate = curr1.ExRate;
        }
        public static void SetName(Currency p1)
        {
            Console.WriteLine("Введіть назву валюти:");
            string y = Console.ReadLine();
            p1.Name = y;
        }
        public static void SetPrice(Currency p1)
        {
            Console.WriteLine("Введіть курс:");
            double y = double.Parse(Console.ReadLine());
            p1.ExRate = y;
        }
        public static void GetName(Currency p1)
        {
            Console.WriteLine("Назва валюти: {0}", p1.Name);
        }
        public static void GetPrice(Currency p1)
        {
            Console.WriteLine("Курс: {0} грн", p1.ExRate);
        }
    }
}
