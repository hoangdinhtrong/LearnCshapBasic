namespace ExceptionHandling.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test(@"C:\Test.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        private static void Test(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("File name should be not null or empty");
            }
            try
            {
                if(!File.Exists(fileName))
                {
                    var ex = new CustomException("Error occured");
                    ex.Data.Add("Key", "Value");
                    throw ex;
                }
                File.OpenRead(fileName);
                Console.WriteLine("Hello world");
            }
            catch (CustomException ex) when (ex.Data.Contains("Key"))
            {
                Console.WriteLine($"Error: {ex}, Count: {ex.Count}");
                throw;
            }
            finally
            {

            }
        }
    }
}