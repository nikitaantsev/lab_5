using System;

namespace lab_4
{
    class Program : IRun, Ithinks
    {
        public float speed { get; set; }
        public float y { get; set; }

        static void Main(string[] args)
        {
            Журнал журнал = new Журнал { Vidacha = "20.01.2001", Vipysk = "4" };
            
            Izdanie[] data = { журнал };

            PrintPersons(журнал);
        }

        private static void PrintPersons(Журнал журнал)
        {
            throw new NotImplementedException();
        }

        static void PrintPersons(Izdanie[] журнал)
        {
            foreach (var person in журнал)
            {
                person.PrintFullName();
            }    
        }

        public void Read()
        {
            Console.WriteLine("people is now read ");
        }

        public void thinks()
        {
            Console.WriteLine("people is now thinks ");
        }
    }
}