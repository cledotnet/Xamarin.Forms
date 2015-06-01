using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public interface Repository
    {
        string DefaultPath { get; }

        void SaveText(string filespec, string contents);
        string LoadText(string filespec);
        IEnumerable<string> GetFiles(string path);
    }
}
