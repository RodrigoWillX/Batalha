using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria objeto Jogador
            Jogador diego = new Jogador("Diego", 500, 300, 300, 200, 190);
            Jogador miguel = new Jogador("Miguel", 500, 300, 300, 200, 190);
            Jogador giovanni = new Jogador("Giovanni", 500, 300, 300, 200, 190);

            float mediaForcejog = (diego.forca + miguel.forca + giovanni.forca) / 3;
            float mediaAtaquejog = (diego.ataque + miguel.ataque + giovanni.ataque) / 3;
            float mediaVelocidadejog = (diego.velocidade + miguel.velocidade + giovanni.velocidade) / 3;

            Console.WriteLine("A media da forca dos inimigos rebeldes eh: " +  mediaForcejog);
            Console.WriteLine("A media do ataque dos inimigos rebeldes eh: " + mediaAtaquejog);
            Console.WriteLine("A media da velocidade dos inimigos rebeldes eh: " + mediaVelocidadejog);
            
            float TotalDinheiro = (diego.dinheiro + miguel.dinheiro + giovanni.dinheiro) / 3;
            Console.WriteLine("A media do dinheiro dos inimigos rebeldes eh: " + TotalDinheiro);


            //Cria objeto Inimigo
            Inimigo roberta = new Inimigo("Roberta", 900, 320, 400, 300, 200);
        Inimigo mia = new Inimigo("Mia", 900, 350, 400, 250, 210);
        Inimigo lupita = new Inimigo("Lupita", 100, 150, 120, 160, 150);

        float mediaForceini = (roberta.forca + mia.forca + lupita.forca) / 3;
        float mediaAtaqueini = (roberta.ataque + mia.ataque + lupita.ataque) / 3;
        float mediaVelocidadeini = (roberta.velocidade + mia.velocidade + lupita.velocidade) / 3;

            Console.WriteLine("A media da forca das inimigas rebeldes eh: " + mediaForceini);
            Console.WriteLine("A media do ataque das inimigas rebeldes eh: " + mediaAtaqueini);
            Console.WriteLine("A media da velocidade das inimigas rebeldes eh: " + mediaVelocidadeini);

            float TotalDinheiroInimigo = (roberta.dinheiro + mia.dinheiro + lupita.dinheiro) / 3;
            Console.WriteLine("A media do dinheiro das inimigas rebeldes eh: " + TotalDinheiroInimigo);
            Console.ReadLine();
        }

    }
    
}


