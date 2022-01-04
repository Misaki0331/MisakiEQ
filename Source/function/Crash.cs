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
            throw new ApplicationException($"ユーザーによる強制終了の実行");
        }
    }
}

