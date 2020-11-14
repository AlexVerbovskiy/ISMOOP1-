using System;

namespace ClassProject7
{
    public class ClassAirplane
    {
        private string StartCity;
        private string FinishCity;
        private Date StartDate;
        private Date FinishDate;
        public ClassAirplane(string city1, string city2, Date date1, Date date2)
        {
            StartCity = city1;
            FinishCity = city2;
            StartDate = date1;
            FinishDate = date2;
        }
        public ClassAirplane(string city1, Date date1, string city2, Date date2)
        {
            StartCity = city1;
            FinishCity = city2;
            StartDate = date1;
            FinishDate = date2;
        }
        public ClassAirplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Lviv";
            StartDate = new Date(14, 11, 2020, 12, 15);
            FinishDate = new Date(14, 11, 2020, 20, 15);
        }
        public ClassAirplane(ClassAirplane clas1)
        {
          StartCity= clas1.StartCity;
          FinishCity = clas1.FinishCity;
          StartDate = clas1.StartDate;
          FinishDate = clas1.FinishDate;
    }
        public static void SetStartCity(ClassAirplane airplanes)
        {
            Console.WriteLine("Введіть місто звідки відправляєтесь:");
            string y = Console.ReadLine();
            airplanes.StartCity = y;
        }
        public static void SetFinishCity(ClassAirplane airplanes)
        {
            Console.WriteLine("Введіть місто куди відправляєтесь:");
            string y = Console.ReadLine();
            airplanes.FinishCity = y;
        }
        public static void SetStartDate(ClassAirplane airplanes)
        {
            Console.WriteLine("Введіть дату відправки:");
            string y = Console.ReadLine();
            string[] arr1 = y.Split('.');
            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(arr1[i]);
            }
            airplanes.StartDate.Year = arr2[0];
            airplanes.StartDate.Month = arr2[1];
            airplanes.StartDate.Day = arr2[2];
            airplanes.StartDate.Hours = arr2[3];
            airplanes.StartDate.Minutes = arr2[4];
        }
        public static void SetFinishDate(ClassAirplane airplanes)
        {
            Console.WriteLine("Введіть дату прибуття:");
            string y = Console.ReadLine();
            string[] arr1 = y.Split('.');
            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(arr1[i]);
            }
            airplanes.FinishDate.Year = arr2[0];
            airplanes.FinishDate.Month = arr2[1];
            airplanes.FinishDate.Day = arr2[2];
            airplanes.FinishDate.Hours = arr2[3];
            airplanes.FinishDate.Minutes = arr2[4];


        }
        public static void GetStartCity(ClassAirplane airplanes)
        {
            Console.WriteLine("Місто відправки: {0}", airplanes.StartCity);
        }
        public static void GetFinishCity(ClassAirplane airplanes)
        {
            Console.WriteLine("Місто прибуття: {0}", airplanes.FinishCity);
        }
        public static void GetStartDate(ClassAirplane airplanes)
        {
            Console.WriteLine("Дата відправки: {0}", airplanes.StartDate);
        }
        public static void GetFinishDate(ClassAirplane airplanes)
        {
            Console.WriteLine("Дата прибуття: {0}", airplanes.FinishDate);
        }

        public int GetTotalTime(ClassAirplane airplane)
        {
            int totalTime = 0;
            int y1 = airplane.StartDate.Year;
            int y2 = airplane.FinishDate.Year;
            int mon1 = airplane.StartDate.Month;
            int mon2 = airplane.FinishDate.Month;
            int d1 = airplane.StartDate.Day;
            int d2 = airplane.FinishDate.Day;
            int m1 = airplane.StartDate.Minutes;
            int m2 = airplane.FinishDate.Minutes;
            int h1 = airplane.StartDate.Hours;
            int h2 = airplane.FinishDate.Hours;
            while (y2 > y1)
            {
                mon2 += 12;
                y2--;
            }
            while (mon2 > mon1)
            {
                if (mon2 > 12&& mon2-12 >= mon1)
                {
                    d2 += 365;
                    mon2 -= 12;
                }
                else
                {
                    switch (mon2)
                    {
                        case 4:d2 += 31;break;
                        case 6: d2 += 31; break;
                        case 9: d2 += 31; break;
                        case 11: d2 += 31; break;
                        case 12: d2 += 30; break;
                        case 1: d2 += 30; break;
                        case 3: d2 += 30; break;
                        case 5: d2 += 30; break;
                        case 7: d2 += 30; break;
                        case 8: d2 += 30; break;
                        case 10: d2 += 30; break;
                        case 2: d2 += 28;break;
                    }
                    mon2--;
                }
                
            }
            while (d2 > d1)
            {
                h2 += 24;
                d2--;
            }
            while (h2 > h1)
            {
                m2 += 60;
                h2--;
            }
            totalTime = m2 - m1;
            return totalTime;
        }
        public string IsArrivingToday(ClassAirplane airplane)
        {
            string a = "false";
            if (airplane.StartDate.Year== airplane.FinishDate.Year&& airplane.StartDate.Month== airplane.FinishDate.Month&& airplane.StartDate.Day== airplane.FinishDate.Day)
            {
                a = "true";
            }
            return a;
        }
        
    }
    public class Date
    {
        internal int Year;
        internal int Month;
        internal int Day;
        internal int Hours;
        internal int Minutes;
        public Date(int y, int mon, int day, int h, int min)
        {
            Year = y;
            Month = mon;
            Day = day;
            Hours = h;
            Minutes = min;
        }
        public Date(int y, string mon, int day, int h, int min)
        {
            string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Day = day;
            for (int i = 0; i < 12; i++)
            {
                if (mon == monthes[i])
                {
                    Month = i + 1;
                }
            }
            Year = y;
            Hours = h;
            Minutes = min;
        }
        public Date()
        {
            Year = 2020;
            Month = 11;
            Day = 14;
            Hours = 12;
            Minutes = 15;
        }
        public Date(Date date1)
        {
            Year = date1.Year;
            Month = date1.Month;
            Day = date1.Day;
            Hours = date1.Hours;
            Minutes = date1.Minutes;
        }
        public static void SetYear(Date dat)
        {
            Console.WriteLine("Введіть рік:");
            int y = int.Parse(Console.ReadLine());
            dat.Year = y;
        }
        public static void SetMonth(Date dat)
        {
            Console.WriteLine("Введіть тип місяця(1-Цифровий,2-Буквенний):");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть місяць:");
            if (a == 1)
            {
                int y = int.Parse(Console.ReadLine());
                dat.Month = y;
            }
            if (a == 2)
            {
                string y = Console.ReadLine();
                string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                for (int i = 0; i < 12; i++)
                {
                    if (y == monthes[i])
                    {
                        dat.Month = i + 1;
                    }
                }
            }
            
        }
        public static void SetDay(Date dat)
        {
            Console.WriteLine("Введіть день:");
            int y = int.Parse(Console.ReadLine());
            dat.Day = y;
        }
        public static void SetHours(Date dat)
        {
            Console.WriteLine("Введіть годину:");
            int y = int.Parse(Console.ReadLine());
            dat.Hours = y;
        }
        public static void SetMinutes(Date dat)
        {
            Console.WriteLine("Введіть хвилину:");
            int y = int.Parse(Console.ReadLine());
            dat.Minutes = y;
        }
        public static void GetYear(Date dat)
        {
            Console.WriteLine("Рік {0}", dat.Year);
        }
        public static void GetMonth(Date dat)
        {
            Console.WriteLine("Місяць {0}", dat.Month);
        }
        public static void GetDay(Date dat)
        {
            Console.WriteLine("День {0}", dat.Day);
        }
        public static void GetHours(Date dat)
        {
            Console.WriteLine("Година: {0}", dat.Hours);
        }
        public static void GetMinutes(Date dat)
        {
            Console.WriteLine("Хвилина: {0}", dat.Minutes);
        }
    }
}
