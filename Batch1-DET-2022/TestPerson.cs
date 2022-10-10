using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestPerson
    {
        public static void Main()
        {
            Person t = new Person("Rutuja", "Devarakki", "rutuja@devarakki.com", new DateOnly(19, 02, 1982));
            string r = t.GetSunSign();
        }
    }
}