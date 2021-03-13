﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise.Comparator
{
    public class TravailleurComparator
    {
        public class SortByAsc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                if (x.Age > y.Age)
                {
                    return 1;
                }

                if (x.Age < y.Age)
                {
                    return -1;
                }

                return 0;
            }
        }

        public class SortByDesc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                if (x.Age < y.Age)
                {
                    return 1;
                }

                if (x.Age > y.Age)
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}
