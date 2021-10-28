using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Clue
    {
        public Clue(string Clue1, string Clue2, string Clue3, string Clue4, string Clue5)
        {
            this.Clue1 = Clue1;
            this.Clue2 = Clue2;
            this.Clue3 = Clue3;
            this.Clue4 = Clue4;
            this.Clue5 = Clue5;
        }
        public string Clue1 { get; set; } = "I am hot.";
        public string Clue2 { get; set; } = "I live in the sky.";
        public string Clue3 { get; set; } = "I live in the sky.";
        public string Clue4 { get; set; } = "I am bright.";
        public string Clue5 { get; set; } = "Don't look straight at me.";
        public string Answer { get; set; } = "Sun!!!!!!!";
    }
}
