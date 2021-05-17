using System.Collections;
using Module_2_Task_4_Vasylchenko.Models;

namespace Module_2_Task_4_Vasylchenko.Helpers.Comparers
{
    public class AnimalsComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Animal;
            var y = second as Animal;

            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
