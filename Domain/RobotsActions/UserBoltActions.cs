﻿using Regresser.Domain.RobotsActions;

namespace Regresser
{
    public class UserBoltActions : Actions
    {
        public string type { get; set; }

        public int timeout { get; set; }


        public override string ToString()
        {
            return $"Timeout - { timeout }";
        }
    }
}