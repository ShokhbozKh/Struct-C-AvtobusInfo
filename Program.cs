namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avtobus[] avtobus = new Avtobus[3];
            avtobus[0]=new Avtobus("DE yong",123,112423.12333m);
            avtobus[1] = new Avtobus("Mers", 321, 32324021.3231m);
            avtobus[2] = new Avtobus("volvo", 432, 434122.12323m);

            Console.WriteLine("----Avtobuslar ruyxati----");
            foreach (var item in avtobus)
            {
                Console.WriteLine($"name {item.Name} Id {item.Id} Narxi {item.Price:C2}\n");
            }
        }
    }

    struct Avtobus
    {
        public string Name;
        public int Id;
        public decimal Price;

        public Avtobus(string name,int id,decimal price)
        {
            Name = name;
            Id = id;
            Price = price;
            
        }

        public override string ToString()
        {
            return $"{Name}-name\n{Id}-Id\n{Price}-Price";
        }
    }
}