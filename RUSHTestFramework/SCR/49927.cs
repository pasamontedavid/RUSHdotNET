using RUSHTestFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSHTestFramework.SCR
{
    public class _49927:BaseConfig
    {
        [Test]
        public void Test_A_FieldsChecking()
        {
            LOGINActions("it00", "12345678");
            CREATEREQUESTActions("HR REQUESTS", "APPLICATION FOR LEAVE UNTIL DEPARTMENT HEAD LEVEL APPROVAL", "HR_LV_DEP_HD");

        }
        
    }
}
