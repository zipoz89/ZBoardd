using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBoard
{
    class Profile
    {
        private string ProfileName { get; set; }
        private string[] imgpaths { get; set; } = new string[17];
        private string[] wavpaths { get; set; } = new string[17];
        private string[] names { get; set; } = new string[17];
        private uint[] volumes { get; set; } = new uint[17];

    }
}
