using System;
using System.Globalization;

namespace Developer.DateTimeNS
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2020, 10, 19);
            DateTime d2 = new DateTime(2020, 10, 19, 19, 05, 59);
            DateTime d3 = new DateTime(2020, 10, 19, 19, 05, 59, 500);
            Console.WriteLine($"Data informada = {d1}");
            Console.WriteLine($"Data e hora informada = {d2}");
            Console.WriteLine($"Data e hora informada = {d3}");

            /* Datas utilizando builders */
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine($"Data agora = {d4}");
            Console.WriteLine($"Data do dia = {d5}");
            Console.WriteLine($"Data de agora horario universal = {d6}");

            /* Parse string para Date */
            DateTime d7 = DateTime.Parse("1981-10-19");
            DateTime d8 = DateTime.Parse("1981-10-19 13:05:58");
            DateTime d9 = DateTime.Parse("19/10/1981");
            DateTime d10 = DateTime.Parse("19/10/1981 13:05:58");

            Console.WriteLine($"Data string = {d7}");
            Console.WriteLine($"Data hora string = {d8}");
            Console.WriteLine($"Data PtBR string = {d9}");
            Console.WriteLine($"Data hora PtBR string = {d10}");

            /* Parse string Exact para Date */
            DateTime d11 = DateTime.ParseExact("1981-10-19", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("19/10/1981", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("19/10/1981 20:27:35", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine($"Data string ParseExact = {d11}");
            Console.WriteLine($"Data string ParseExact = {d12}");
            Console.WriteLine($"Data string ParseExact = {d13}");


            /** TIMESPAN 
             * define o tempo relacionado ao um intervalo de tempo em ticks 
             * cada ticks = 100 nanosegundos
             */
            Console.WriteLine("\n=================");
            Console.WriteLine("TIMESPAN");

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0, 1, 30); // 00:01:30
            TimeSpan t3 = new TimeSpan(900000000); // 00:01:30
            TimeSpan t4 = new TimeSpan(1, 2, 15, 22); // 1.2:15:22 (d,HH,mm,s)
            TimeSpan t5 = new TimeSpan(1, 2, 15, 22, 300); // 1.2:15:22 (d,HH,mm,s,mm)

            Console.WriteLine($"new timespan = {t1}");
            Console.WriteLine($"timespan h,m,s = {t2}");
            Console.WriteLine($"timespan h,m,s formato ticks = {t2.Ticks}");
            Console.WriteLine($"timespan ticks formato  h,m,s= {t3}");
            Console.WriteLine($"timespan d,h,m,s = {t4}");
            Console.WriteLine($"timespan d,h,m,s.mm = {t5}");

            Console.WriteLine("\nTIMESPAN FROM");

            TimeSpan tf1 = TimeSpan.FromDays(1.5);
            TimeSpan tf2 = TimeSpan.FromHours(1.5);
            TimeSpan tf3 = TimeSpan.FromMinutes(1.5);
            TimeSpan tf4 = TimeSpan.FromSeconds(1.5);
            TimeSpan tf5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan tf6 = TimeSpan.FromTicks(900000000L);


            Console.WriteLine($"new 1d e meio {tf1}");
            Console.WriteLine($"new 1h e meia {tf2}");
            Console.WriteLine($"new 1m e meio {tf3}");
            Console.WriteLine($"new 30seg e meio {tf4}");
            Console.WriteLine($"new 30mm e meio {tf5}");
            Console.WriteLine($"new Tickes 1m e meio {tf6}");

            /** 
            * Propriedades e Operações Datetime (92)  
            */
            Console.WriteLine("\nPROPRIEDADES E OPERAÇÕES DATETIME\n");
            DateTime date2 = new DateTime(1981, 10, 19, 05, 30, 58, 275);

            Console.WriteLine(date2); // 19/10/1981 05:30:58
            Console.WriteLine("1) Date: {0}", date2.Date);      // 19/10/1981 00:00:00
            Console.WriteLine("2) Day: {0}", date2.Day);        // 19
            Console.WriteLine("3) Month: {0}", date2.Month);    // 10
            Console.WriteLine("4) Year: {0}", date2.Year);      // 1981
            Console.WriteLine("5) DayOfWeek: {0}", date2.DayOfWeek);    // Monday
            Console.WriteLine("6) DayOfYear: {0}", date2.DayOfYear);    // 292
            Console.WriteLine("7) Kind: {0}", date2.Kind);  // Unspecified - por padrão pega local e não univeral
            Console.WriteLine("8) Hour: {0}", date2.Hour);  // 5
            Console.WriteLine("9) Millisecond: {0}", date2.Millisecond);  // 275
            Console.WriteLine("10) Minute: {0}", date2.Minute); // 30
            Console.WriteLine("11) Second: {0}", date2.Second); // 58
            Console.WriteLine("12) Ticks: {0}", date2.Ticks);   // 625079142582750000
            Console.WriteLine("13) TimeOfDay: {0}", date2.TimeOfDay);  // 05:30:58.2750000

            /** 
            * Formatação Datetime (92)  
            */
            Console.WriteLine("\nFORMATAÇÂO DATETIME\n");
            string s1 = date2.ToLongDateString();
            string s2 = date2.ToLongTimeString();
            string s3 = date2.ToShortDateString();
            string s4 = date2.ToShortTimeString();
            string s5 = date2.ToString();
            string s6 = date2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = date2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine("ToLongDateString: {0}", s1);     // segunda-feira, 19 de outubro de 1981
            Console.WriteLine("ToLongTimeString: {0}", s2);     // 05:30:58
            Console.WriteLine("ToShortDateString: {0}", s3);    // 19/10/1981
            Console.WriteLine("ToShortTimeString: {0}", s4);    // 05:30
            Console.WriteLine("ToString(): {0}", s5);           // 19/10/1981 05:30:58
            Console.WriteLine("ToString(yyyy-MM-dd HH:mm:ss): {0}", s6);              // 1981-10-19 05:30:58
            Console.WriteLine("ToShortTimeString(yyyy-MM-dd HH:mm:ss.fff): {0}", s7); // 1981-10-19 05:30:58.275

            /** 
            * Operadores Datetime (92)  
            */
            Console.WriteLine("\nOPERAÇÃO DATETIME\n");
            DateTime dateOp = DateTime.Now;

            DateTime dateOp2 = dateOp.AddHours(2);
            DateTime dateOp3 = dateOp.AddDays(7);

            Console.WriteLine("Data atual: {0}", dateOp);               // 14/04/2020 08:59:04
            Console.WriteLine("Data atual + 2 horas: {0}", dateOp2);    // 14/04/2020 10:59:04
            Console.WriteLine("Data atual + 7 dias: {0}", dateOp3);     // 21/04/2020 08:59:04

            //SUBTRAÇÃ0 (92)
            Console.WriteLine("\nOPERAÇÃO SUBTRAÇÃO DATETIME\n");
            DateTime dts1 = new DateTime(2020, 04, 10);
            DateTime dts2 = new DateTime(2020, 04, 14);

            TimeSpan sub = dts2.Subtract(dts1);

            Console.WriteLine("Date anterior: {0}", dts1);  // 10/04/2020 00:00:00
            Console.WriteLine("Date posterior: {0}", dts2); // 14/04/2020 00:00:00
            Console.WriteLine("Date diferença: {0}", sub);  // 4.00:00:00
        }
    }
}
