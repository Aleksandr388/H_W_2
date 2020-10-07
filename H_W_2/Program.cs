using System;

namespace Home_work_linked_list
{
    class Program
    {

        static void Main(string[] args)
        {
            var modelCars = new Model.LinkedList<int>();

            var deleteList = new Model.LinkedList<int>();

            modelCars.Add(2114);
            modelCars.Add(2113);
            modelCars.Add(2117);
            modelCars.Add(214);
            modelCars.Add(14);

            Console.WriteLine("Model: ");

            foreach (var model in modelCars)
            {
                Console.WriteLine(model);
            }
            Console.WriteLine();

            modelCars.AddToRemoveList += deleteList.Add;

            modelCars.Remove(2114);
            modelCars.Remove(214);

            Console.WriteLine("Modified list: ");

            foreach (var model in modelCars)
            {
                Console.WriteLine(model);
            }

            Console.WriteLine();
            Console.WriteLine("NEW LIST");

            foreach (var deleteModel in deleteList)
            {
                Console.WriteLine(deleteModel);
            }

            Console.ReadLine();
        }

    }
}
