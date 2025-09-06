namespace Ucu.Poo.GameOfLife;
/*
Esta clase implementa la logica del comportamiento de las celulas en el juego "Conway´s game of life"
*/
public class Cell
{
    public static bool[,] CellNextGeneration(bool[,] gameBoard) {
        //Éste método es el que se encarga de generar la siguiente generación del juego y
        //de toda la lógica básica que conlleva eso.
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);
        //Se obtienen las dimensiones
        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        //cloneboard va a ser la siguiente generación, es decir, lo que devuelve
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(gameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false;
                    }
                    else if (gameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false;
                    }
                    else if (!gameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = gameBoard[x,y];
                    }
                }
            }
        return cloneboard;
        //Devuelve el estado del board actualizado
    }
}
