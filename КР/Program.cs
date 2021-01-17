using System;
using КР.Model;

namespace КР
{
  public class Program
    {
        static void Main(string[] args)
        {
            menscheninfo _leute = new menscheninfo();
            foreach (interfacemenschen menscheninfo in _leute.arbeiter)
                Console.WriteLine(menscheninfo.nachname + menscheninfo.name + menscheninfo.vatersname + menscheninfo.arbeitplatz + menscheninfo.beruf);
            Console.ReadKey();
        }
    }
}
