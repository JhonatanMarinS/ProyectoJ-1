using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Personaje
    {
        //Atributos
        private String nombre;
        private char sexo;
        private double ataque;
        private double vida;
        private double resistencia;
        private int nivel;

        //Metodos

        public void golpear()
        {

        }
        public void recibirImpacto()
        {

        }
        public void moverArriba()
        {

        }
        public void moverIzquierda()
        {

        }
        public void moverAbajo()
        {

        }
        public void moverDerecha()
        {

        }
        public double calcularResistencia()
        {

        }
        public double calcularAtaque()
        {

        }

        // Setters y Getters
        
        public String getNombre()
        {
            return nombre;
        }
        public char getSexo()
        {
            return sexo;
        }
        public double getAtaque()
        {
            return ataque;
        }
        public double getVida()
        {
            return vida;
        }
        public double getResistencia()
        {
            return resistencia;
        }
        public int getNivel()
        {
            return nivel;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void setAtaque(double ataque)
        {
            this.ataque = ataque;
        }
        public void setVida(double vida)
        {
            this.vida = vida;
        }
        public void setResistencia(double resistencia)
        {
            this.resistencia = resistencia;
        }
        public void setNivel(int nivel)
        {
            this.nivel = nivel;
        }
        
    }
}
