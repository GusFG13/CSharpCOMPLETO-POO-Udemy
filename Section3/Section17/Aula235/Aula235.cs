namespace Section17.Aula235
{
    class Aula235
    {
        public static void Aula_235()
        {
            // specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // define the query expression

            //var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            //var result = numbers
            //    .Where(x => x % 2 == 0)
            //    .Select(x => x * 10);

            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
