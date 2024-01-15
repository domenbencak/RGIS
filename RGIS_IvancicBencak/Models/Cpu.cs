using System;
namespace RGIS_IvancicBencak
{
    public class Cpu : Component
    {
        private double clockspeed;
        private int cores;
        private int threads;

        public Cpu GetCpu()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public override string ToString()
        {
            return clockspeed.ToString() + "GHz, " + cores.ToString() + " jeder, " + threads.ToString() + "niti.";
        }
    }
}

