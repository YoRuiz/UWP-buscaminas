using buscaminas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminas.Models
{
    public class casilla : clsVMBase
    {
        private int _valor;
        private Uri _imagen;

        public casilla()
        {

        }
        public casilla(int valor, Uri imagen)
        {
            this._valor = valor;
            this._imagen = imagen;
        }

        public int valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }
        public Uri imagen
        {
            get{
                return _imagen;
            }
            set{
                _imagen = value;
                NotifyPropertyChanged("imagen");
            }
        }

    }
}
