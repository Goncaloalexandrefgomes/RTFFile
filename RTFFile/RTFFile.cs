using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RTFFile
{
    class RTFFile
    {
        public string _path = Application.StartupPath + "\\Resources\\poema.txt";
        public string _texto;

        public string Texto
        {
            get
            {
                _texto = "";
                _texto = File.ReadAllText(_path);
                return _texto;
            }
            set { _texto = value; }
        }

        public void Guardar()
        {
            File.WriteAllText(_path, _texto);
        }
    }
}
