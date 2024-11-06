using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Poo1
{
    internal class Television
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public bool prender { get; set; }
        public int canal { get; set; }
        //private int volumen;
        public int volumen { get; set; }

        public Television(string marca, string modelo, bool prender)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.prender = prender;
        }
        public Television()
        {

        }
        
        public string Marca
        {
            set { marca = value; }
        }
        public string Modelo
        {
            set { modelo = value; }
        }
        public string Cambiar()
        {
            return "siguiente canal";
        }
        public string Cambiar(int canal)
        {
            return $"Cambio al canal: {this.canal = canal}";
        }
        public string Encendido(bool prender)
        {
            if (prender == true) return "Encendiste la tele";
            else return "Apagaste la tele";
        }
        public int SubirVolumen(int volumen)
        {
           return this.volumen += volumen;
        }
    }
}
