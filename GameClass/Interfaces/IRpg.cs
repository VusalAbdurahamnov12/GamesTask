using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Interfaces
{
    internal interface IRpg
    {
        public int Level { get; set; }
        public int WantedLevel { get; set; }
        public int LeftLevel();
    }
}
