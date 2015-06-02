using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public interface Persistable
    {
        void Save(string path);
        void Load(string path);
        string Identifier { get; }
    }
}
