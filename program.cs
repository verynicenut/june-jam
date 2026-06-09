using System;

namespace JuneJam2026
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phonetics = new List<string>{"Alpha", "Bravo", "Charlie", "Delta"};
            List<string> selectedPhonetics = phonetics.GetRange(0, 3);
            for(int i = 0; i < selectedPhonetics.Count; i++){
            Console.WriteLine(selectedPhonetics[i]);
}
        }
    }
}  