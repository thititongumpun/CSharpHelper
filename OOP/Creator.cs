using System;

namespace OOP
{
    public abstract class Creator
    {
        private int _creativityLevel = 100;
        private int _energy = 100;

        public int CreativityLevel
        {
            get
            {
                return _creativityLevel;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _creativityLevel = value;
                }
                else
                {
                    throw new Exception("CreativityLevel can only be value between 0 and 100");
                }
            }
        }

        public int Energy
        {
            get
            {
                return _creativityLevel;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    throw new Exception("Energy can only be value between 0 and 100");
                }
            }
        }
        public abstract void Create();
    }
}