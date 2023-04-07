using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Comum.Utils
{
    public static class ObjectUtil
    {
        public static bool IsNotNull(this object? objeto)
        {
            return objeto != null;
        }

        public static bool IsNull(this object? objeto)
        {
            return objeto == null;
        }
    }
}
