using System;

namespace RGIS_IvancicBencak
{
    public class Cpu : Component
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public int? Popularity { get; set; }
        public double Clockspeed { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }


        public Cpu(int Id, string Name, string Brand, double Clockspeed, int Cores, int Threads)
        {
            this.Id = Id;
            this.Name = Name;
            this.Brand = Brand;
            this.Clockspeed = Clockspeed;
            this.Cores = Cores;
            this.Threads = Threads;
        }

        public Cpu(double Clockspeed, int Cores, int Threads)
        {
            this.Clockspeed = Clockspeed;
            this.Cores = Cores;
            this.Threads = Threads; 
        }

        public Cpu()
        {

        }

        public Cpu GetCpu()
        {
            return new Cpu
            {
                Clockspeed = 3.0,
                Cores = 4,
                Threads = 8
            };
        }

        public override string ToString()
        {
            return $"{Clockspeed} GHz, {Cores} cores, {Threads} threads.";
        }
    }
}
