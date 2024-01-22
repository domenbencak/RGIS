using System;

namespace RGIS_IvancicBencak
{
    public class BenchmarkScore
    {
        public int Id;
        public int CpuScore;
        public int GpuScore;

        // Constructor
        public BenchmarkScore(int id, int cpuScore, int gpuScore)
        {
            Id = id;
            CpuScore = cpuScore;
            GpuScore = gpuScore;
        }

        // Method to get a random BenchmarkScore
        public static BenchmarkScore GetBenchmarkScore()
        {
            Random random = new Random();

            int id = random.Next(1, 100);
            int cpuScore = random.Next(1, 10000);
            int gpuScore = random.Next(1, 10000);

            return new BenchmarkScore(id, cpuScore, gpuScore);
        }
    }
}
