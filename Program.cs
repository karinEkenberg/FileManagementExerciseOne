namespace FileManagementExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"MyText.txt";
    
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                Console.WriteLine("Creating a file that contains text:");
                Console.WriteLine("-----------------------------------");

                using(StreamWriter fileStr = File.CreateText(filePath))
                {
                    fileStr.WriteLine("Here is the content:");
                    fileStr.WriteLine("Just some random words");
                    fileStr.WriteLine("Since this is a exercise the content \n" +
                    "is not that important");
                    fileStr.WriteLine("The text file will be named MyText.txt");
                }

                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file MyText.txt: ");
                    while ((s = sr.ReadLine()) != null ) 
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
