using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4
{
    [Serializable()]
    class Alarma 
    {

        private String hora;

        public Alarma()
        {
            
        }

        public String gethora()
        {
           return this.hora; 
        }

        public void sethora(String hora)
        {
            this.hora = hora;
        }

       
    }
}
