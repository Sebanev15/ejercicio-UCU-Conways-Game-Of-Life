using System.IO;
using System.Text;
namespace Ucu.Poo.GameOfLife;
/*
 * Esta clase implementa el patrón Traductor para el juego de Conway, actuando
 * como un adaptador universal entre diferentes representaciones de datos del juego.
 */
public class GameTraducer
{
    /*
     * Este metodo obtiene la informacion de un archivo de 1´s y 0´s y retorna un array bidimensional de booleanos 
     */
    public static bool[,] FileToBool(string fileName)
    {
        string content = File.ReadAllText(fileName);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
        return board;
    }

    /*
     * Este metodo obtiene un array bidimensional de booleanos que representa el frame del juego y retorna un string
     * con los caracteres que se deben de mostrar en pantalla
     * 
     */
    public static string BoolToGameFrame(bool[,] gameStatus)
    {
        StringBuilder gameFrame = new StringBuilder();
        for (int y = 0; y < gameStatus.GetLength(1); y++)
        {
            for (int x = 0; x < gameStatus.GetLength(0); x++)
            {
                if (gameStatus[x, y])
                {
                    gameFrame.Append("|X|");
                }
                else
                {
                    gameFrame.Append("___");
                }
            }
            gameFrame.Append("\n");
        }
        return gameFrame.ToString();
    }
}
