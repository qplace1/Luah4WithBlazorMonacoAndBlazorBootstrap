using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IDataFile
    {
        String FileName { get; set; }   
        List<String> Content { get; set; }
    }
}
