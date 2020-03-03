using System.Collections.Generic;

namespace ThinkQuestion
{
    class SortByChar : IComparer <string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.CompareTo(y);
        }
    }
}