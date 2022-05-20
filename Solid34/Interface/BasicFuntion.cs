using Solid34.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid34.Interface
{
    public interface BasicFuntion
    {
        // Debido a que es solo la implementacion de la interfaz, imagine mas como la funcionalidad tanto un fax, como  una impresora y escaner pueden enviar y recibir docuembtos 
        //para cunmplir su funcionamiento
        void power(bool swtich = false);

        void send(Document document);

        void recibe(Document document);
    }
}
