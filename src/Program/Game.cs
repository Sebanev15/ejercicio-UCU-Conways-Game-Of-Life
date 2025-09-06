using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;
/*
Esta clase es la encargada de mostrar en pantalla cada generacion del juego. Comunicandose asi con cada
clase necesaria para el funcionamiento del juego. En definitiva cumple un rol de intermediario
*/
public class Game
{
    
// Metodo intermediario entre Cell y GameTraducer, obtiene el tablero a traves de 
// GameTraducer y despues evalua cada generacion de celula a traves de cell para imprimirlo
// posteriormente.
 
    public static void StartGame( string fileName)
    {
        // Se obtiene el tablero como un array bidimensional de booleanos
        // A partir del metodo "InitialConvert" de la clase "GameTraducer"
        bool[,] board =GameTraducer.FileToBool(fileName);
        
        while (true)
        {
            Console.Clear();
            Console.Write(GameTraducer.BoolToGameFrame(board));
            // Se retorna un array bidimensional de booleanos con la 
            // siguiente generacion a partir de Cell
            board = Cell.CellNextGeneration(board);
            
            Thread.Sleep(300);
            
        }
    }
}
