using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Game
{
    
// Metodo intermediario entre Cell y GameTraducer, obtiene el tablero a traves de 
// GameTraducer y despues evalua cada generacion de celula a traves de cell para imprimirlo
// posteriormente.
 
    public static void StartGame( string fileName)
    {
        // Se obtiene el tablero como un array bidimensional de booleanos
        // A partir de la clase GameTraducer
        bool[,] board =GameTraducer.InitialConvert(fileName);
        
        
        while (true)
        {
            Cell.CellNextGeneration();
            // Se retorna un array bidimensional de booleanos con la 
            // siguiente generacion a partir de Cell


            GameTraducer.BoolToGameFrame();
            
            //=================================================
            Thread.Sleep(300);
        }
     
        



    }


   
}