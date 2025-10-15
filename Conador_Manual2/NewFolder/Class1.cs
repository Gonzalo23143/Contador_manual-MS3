using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conador_Manual2.NewFolder
{
    class Class1
    {
        private int _conteo;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                }
            }
    }

        public  Class1()
        {
            Conteo = 0;
        }

        public void Contar()
        {
            Conteo++;
        }
        public void Reiniciar()
        {
            Conteo = 0;
        }
}

        }