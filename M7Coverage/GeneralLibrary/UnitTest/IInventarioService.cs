using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary.UnitTest
{
    public interface IInventarioService
    {
        bool HayStock(string productoId);
    }
}
