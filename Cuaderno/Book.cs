using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuaderno
{
    class Book
    {
        private string _tamaño;
        private string _hojas;
        private string _color;





        public Book()
        { }

        public void settamaño(String tamaño)
        {
            _tamaño = tamaño;
        }

        public string gettamaño()
        {
            return _tamaño;
        }

        public void sethojas(String hojas)
        {
            _hojas = hojas;
        }

        public string gethojas()
        {
            return _hojas;
        }

        public void setcolor(String color)
        {
            _color = color;
        }

        public string getcolor()
        {
            return _color;
        }

        public string getTodo()
        {
            return "Tamaño: " + _tamaño + " hojas: " + _hojas + " Color: "+_color;
        }

    }




}
