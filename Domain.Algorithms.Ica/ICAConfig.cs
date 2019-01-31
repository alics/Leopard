﻿using WebServiceComposition.Domain.Models;

namespace WebServiceComposition.Algorithms.Ica
{
    public class IcaConfig:Config
    {
        public int InitialEmpiresCount { get; set; } = 10;
        public double Zeta { get; set; } = 0.1;
        public double RevolutionRate { get; set; } = 0.8;
    }
}
