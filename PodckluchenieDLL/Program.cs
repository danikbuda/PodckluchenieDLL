using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PodckluchenieDLL
{           //При работе с готовой DLL следует добавить ее в корень проекта к exe файлу, а также добавить ссылку на эту библиотеку в самом проекте, для взаимодействия с ее функционалом,
            // в случае же когда эта библиотека вашей разработки, тогда удобнее ее открыть как проект в решении, для возможного редактирования,
            // при этом также необходимо добавить ссылку но уже не на саму библиотеку, а на проект в котором содержится требуемоя библиотека
    class Program
    {
        static void Main(string[] args)
        {

            double result = DynamicLL.Add(4, 6);//подключение сторонней DLL к проекту, тест функционала
            

            Console.WriteLine("Сложение  "+result);
             result = DynamicLL.Substract(4, 6);//подключение сторонней DLL к проекту, тест функционала


            Console.WriteLine("Вычитание  "+result);
            result = DynamicLL.Divide(4, 4);//подключение сторонней DLL к проекту, тест функционала


            Console.WriteLine("Деление  "+result);
             result = DynamicLL.Multiply(4, 4);//подключение сторонней DLL к проекту, тест функционала


            Console.WriteLine("Умножение  "+result);




            Console.ReadLine();
        }
    }
}
