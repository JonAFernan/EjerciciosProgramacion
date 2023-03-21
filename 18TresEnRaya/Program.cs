namespace _18TresEnRaya;

/*
 * Crea una función que analice una matriz 3x3 compuesta por "X" y "O"
 * y retorne lo siguiente:
 * - "X" si han ganado las "X"
 * - "O" si han ganado los "O"
 * - "Empate" si ha habido un empate
 * - "Nulo" si la proporción de "X", de "O", o de la matriz no es correcta.
 *   O si han ganado los 2.
 * Nota: La matriz puede no estar totalmente cubierta.
 * Se podría representar con un vacío "", por ejemplo.
 */
class Program
{
    static void Main(string[] args)
    {
        /*char [,] ticTacToe =  
        { 
        {'X','X','X'} , 
        {'O','O','O'} ,  // Both win. Null
        {'_','_','O'} 
        };*/

        /*char [,] ticTacToe =  
        { 
        {'X','_','O'} , 
        {'_','X','_'} ,  // Proportion of 'X' and 'O' is not correct.Null
        {'_','_','X'} 
        };*/

        char [,] ticTacToe =  
        { 
        {'X','_','O'} , 
        {'O','X','_'} , // 'X' Win. "X"
        {'O','_','X'} 
        };

        /*char [,] ticTacToe =  
        { 
        {'O','_','_'} , 
        {'O','X','_'} , // 'O' Win. "O"
        {'O','_','X'} 
        };*/

        /*char [,] ticTacToe =  
        { 
        {'O','X','O'} , 
        {'X','X','O'} , // Tie. "Tie"
        {'X','O','X'} 
        };*/
        
        Console.WriteLine(TicTacToeCheker(ticTacToe));   
    }

    static string TicTacToeCheker(char [,] gameResume)
    {
        int xCounter = 0;
        int oCounter = 0;
        int differenceBetweenCounters;
        string winner = string.Empty;

        foreach (var item in gameResume)
        {
            if(item == 'X') xCounter ++;
            if(item == 'O') oCounter++;
        }

        differenceBetweenCounters = xCounter - oCounter;
        if(differenceBetweenCounters < 0) differenceBetweenCounters *= -1; 
        if(differenceBetweenCounters > 1) return "Null";


        if(gameResume[0,0] == gameResume[0,1] && gameResume[0,1] == gameResume[0,2])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[0,0].ToString();
        } 
        if(gameResume[1,0] == gameResume[1,1] && gameResume[1,1] == gameResume[1,2])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[1,0].ToString();
        } 
        if(gameResume[2,0] == gameResume[2,1] && gameResume[2,1] == gameResume[2,2])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[2,0].ToString();

        }  
        if(gameResume[0,0] == gameResume[1,0] && gameResume[1,0] == gameResume[2,0])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[0,0].ToString();
        }  
        if(gameResume[0,1] == gameResume[1,1] && gameResume[1,1] == gameResume[2,1])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[0,1].ToString();
        }  
        if(gameResume[0,2] == gameResume[1,2] && gameResume[1,2] == gameResume[2,2])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[0,2].ToString();
        } 

        if(gameResume[0,0] == gameResume[1,1] && gameResume[1,1] == gameResume[2,2]) 
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[0,0].ToString();
        } 
        if(gameResume[2,0] == gameResume[1,1] && gameResume[1,1] == gameResume[0,2])
        {
            if(winner != string.Empty) return "Null";
            winner = gameResume[2,0].ToString();
        } 

        if(winner != string.Empty) return winner;
        return "Tie";
    }
        
}
