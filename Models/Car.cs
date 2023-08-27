using System;
using System.Collections.Generic;

namespace Lab10ex2.Models
{
	public class Car
	{
		
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerieSasiu { get; set; }
        public int Year { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

/*
        public Car(int id, string name, string serieSasiu, int year, int producerId)

        {

            this.Id = id;
            this.Name = name;
            this.SerieSasiu = serieSasiu;
            this.Year = year;
            this.ProducerId = producerId;

        }
        */
        public override string ToString()
        => $"{Name}|{SerieSasiu}|{Year}";
    }
}


