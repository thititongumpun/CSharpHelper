using System;

namespace OOP
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if (base.Energy >= 50 && Energy <= 100) 
            {
                this.BrainstormSolution();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            throw new Exception("pg is dead");
        }

        private void BrainstormSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 10;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Brainstorming solution");
        }

        private void PickMostOptimalSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Picing Most Optimal solution");
        }

        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 30;
            base.Energy = base.Energy - 30;
            Console.WriteLine("Writting Code");
        }

        private void TestCode()
        {
            base.CreativityLevel = base.CreativityLevel - 10;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Testing Code");
        }
    }
}