using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Poo1
{
    internal class Telefono
    {
        public Telefono(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            //set{codigoOperador = value; if(codigoOperador == 1 || 2 || 3)
              // codigoOperador = value;
               //else codigoOperador = 0
               //} ( ME DIO ERROR) F
            set { codigoOperador = value; 
                switch (codigoOperador)
                {
                    case 1:
                    case 2:
                    case 3:
                        codigoOperador = value;
                        break;
                    default:
                        codigoOperador = 0;
                        break;
                }
            }

        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return $"Llamando a: {contacto}";
        }
        public string Llamar(int numeroCelular)
        {
            return $"Llamando al numero: {numeroCelular}";
        }
       
    }
}
