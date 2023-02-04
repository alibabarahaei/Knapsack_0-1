using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Project.DTO
{
    public class item
    {
        public long value;
        public long weight;
        public long id;
        public item(long value = 0, long weight = 0, long id = 0)
        {
            this.value = value;
            this.weight = weight;
            this.id = id;
        }
    }
}
