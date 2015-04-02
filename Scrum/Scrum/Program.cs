using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum {
    class Program {
        public static string Name { get; set; }

        static void Main(string[] args) {
            Console.WriteLine("hej");
            Console.WriteLine(Name);
            for (var i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
