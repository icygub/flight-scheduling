using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs270_uwp
{
    class CustomerBaseTest
    {
        String s = "asdf";
        String e = "asdf";

        string s1 = "asdf";
        String e1 = "asdf";

        public void Tester() {
            if (s.Equals(e)) {
                System.Diagnostics.Debug.WriteLine("equal");
            }
        }
    }
}
