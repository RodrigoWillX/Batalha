using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Jogador
    {
        //Atributos 
        public string nome;
        public float dinheiro;
        public int forca, ataque, defesa, velocidade;

        //Metodos
        public void Atacar()
        {
            Console.WriteLine(nome + " atacou com forca " + ataque);
        }

        //Metodo defender com parametro inimigo(string)
        public void Defender(string inimigo)
        {
            Console.WriteLine(nome + " defendeu o ataque de " + inimigo);
        }
        
        public void Atacar(string inimigo)
        { 
            Console.WriteLine(nome + " atacou o ataque de " + inimigo);
            }

        //Metodo construtor
        public Jogador(string defineNome, float defineDinheiro, int defineForca, int defineAtaque, int defineDefesa, int defineVelocidade)
        {
            nome = defineNome;
            dinheiro = defineDinheiro;
            forca = defineForca;
            ataque = defineAtaque;
            defesa = defineDefesa;
            velocidade = defineVelocidade;
            Console.WriteLine(nome + " foi criado!");
        }
    }
}
