using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_CHAMBA
{
    class Operaciones
    {
        //atributos y metodos
        double numero1, resultado=0;

        public Operaciones(double numero1, double resultado)
        {
            this.numero1 = numero1;
            this.resultado = resultado;
        }
        public void Sumar()
        {
            resultado = numero1 + resultado;
        }
        public void Restar()
        {
            resultado = resultado - numero1;
        }
        public void Multiplicar()
        {
            resultado = resultado * numero1;
        }
        public void Dividir()
        {
            resultado = resultado / numero1;
        }
    }
}