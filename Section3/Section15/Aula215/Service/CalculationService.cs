namespace Section15.Aula215.Service
{
    class CalculationService
    {
        //public int Max(List<int> list)
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }
            //int max = list[0];
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                /*
                 *  list[i].CompareTo(max)
                 *  - list[i] > max CompareTo retorna 1
                 *  - list[i] = max CompareTo retorna 0
                 *  - list[i] < max CompareTo retorna -1
                */
                //if (list[i] > max)
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
