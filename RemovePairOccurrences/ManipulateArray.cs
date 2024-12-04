namespace RemovePairOccurrences
{
    public class ManipulateArray
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enterez une liste des entiers avec espaces ");

        
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split(' ');

            
            int[] input = Array.ConvertAll(inputArray, int.Parse);

           
            int[] result = RemoveOccurrences(input);

           
            Console.WriteLine("List apres manipulation:");
           
        }
        public static int[] RemoveOccurrences(int[] input)
        {
            try
            {
                // Count occurrences of elements 
                var occCount = new Dictionary<int, int>();

                foreach (var num in input)
                {
                    if (occCount.ContainsKey(num))
                    {
                        occCount[num]++;
                    }
                    else
                    {
                        occCount[num] = 1;
                    }
                }


                var result = new List<int>();
                foreach (var num in input)
                {
                    if (occCount[num] % 2 != 0)
                    {
                        result.Add(num);
                    }
                }

                return result.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
