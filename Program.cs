using System;

namespace DesignPattern_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var kayboardCreator = new KayboardCreator();
            var computerCreator = new ComputerCreator();
            var mauseCreator = new MauseCreator();

            var salesman = new Salesman();

            salesman.componentsCrators.Add(kayboardCreator);
            salesman.componentsCrators.Add(computerCreator);
            salesman.componentsCrators.Add(mauseCreator);

            salesman.Appose();

            Console.WriteLine("Twój zestaw składa się z:");
            foreach(var componentsCrator in salesman.componentsCrators)
            {
                var component = componentsCrator.GetComponent();
                Console.WriteLine(component.Name);
            }
        }
    }
}

