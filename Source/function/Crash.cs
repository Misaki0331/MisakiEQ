using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisakiEQ.app
{
    class Abort
    {
        public void Application_was_crashed_by_user()
        {
            throw null;
        }
    }
}
