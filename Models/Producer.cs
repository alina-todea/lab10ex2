using System;
namespace Lab10ex2.Models
{
	public class Producer
	{

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public List<Car> Cars { get; set; }

        /*
        public Producer(int id, string name, string address)

        {

            this.Id = id;
            this.Name = name;
            this.Address = address;
            
        }
        */
        public override string ToString()
        => $"{Name}";
    }
    
}

