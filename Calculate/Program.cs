using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            //WEB interface

            string baseAddress = "http://localhost:9000/";
            // OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Создаем HttpClient 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            } 
            
            // Ввод данных для расчета калькулятором            

            Console.WriteLine("Введите данные для расчета, в следующем формате(a+b | a-b | a*b | a/b): ");
            string valueInput = Console.ReadLine();
            Console.WriteLine(Calculator.Сalculation(valueInput));
            Console.ReadKey();                                          
        }
    }
}
