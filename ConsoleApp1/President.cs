using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace President
{

    class President
    {
        public string name = "Arcturus Mengsk";
        private int environmentPriority;
        private int defensePriority;
        private int healthcarePriority;
        private int corruption;
        private int money;

        Random gen = new Random();

        public President(string n)
        {
            environmentPriority = gen.Next(0, 100);
            defensePriority = gen.Next(0, 100);
            healthcarePriority = gen.Next(0, 100);
        }

        public void Present()
        {
            Console.WriteLine("President: " + name);
            Console.WriteLine("The current Environment priority is: " + environmentPriority);
            Console.WriteLine("The current Defense priority is: " + defensePriority);
            Console.WriteLine("The current Health priority is: " + healthcarePriority);
        }

        public bool PassLegislation(int e, int d, int h, int bribe)
        {
            environmentPriority = environmentPriority + bribe;
            defensePriority = defensePriority + bribe;
            healthcarePriority = healthcarePriority + bribe;
            if(environmentPriority > e && defensePriority > d && healthcarePriority > h)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
