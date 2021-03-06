﻿using System.Collections.Generic;

namespace Leopard.Domain.Models
{
    public class CompositionRequest
    {
        public IEnumerable<TaskCandidateService> TaskCandidateServices { get; set; }
        public Config Config { get; set; }
    }
}