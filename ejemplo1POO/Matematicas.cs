﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1POO
{
   public class Matematicas
    {
        private double numero1;
        private double numero2;
        //se crean los metodos setter y getter

     public void setNumero1(double valor)
        {

            this.numero1 = valor;
        }
      

        public double getNumero1()
        {
            return this.numero1;
        }

        public void setNumero2(double valor)
        {

            this.numero2 = valor;
        }


        public double getNumero2()
        {
            return this.numero2;
        }



        public double sumar()
        {
            return (this.getNumero1()  +  this.getNumero2());
        }

        public double restar()
        {
            return (this.getNumero1() - this.getNumero2());
        }

        public double multiplicar()
        {
            return (this.getNumero1() * this.getNumero2());
        }

        public double dividir()
        {
            return (this.getNumero1() / this.getNumero2());
        }
    }

}
