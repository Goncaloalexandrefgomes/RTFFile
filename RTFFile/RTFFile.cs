using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFFile
{
    class RTFFile
    {
        public string _path
        public string _texto;

        public string Texto
        {
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
            set { _texto = value; }
        }
    }
}
