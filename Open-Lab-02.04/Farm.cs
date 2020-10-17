using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            return 2 * chickens + 4 * (cows + pigs);
        }
    }
}
