using System;
using System.Collections.Generic;
using System.Text;

public class Board
{
    string[,] board;
    public Board()
    {
        board = new string[5, 5];
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                board[col, row] = ".";
            }
        }
    }
    public string getRoom(Point p)
    {
        return board[p.x + 2, 2 - p.y];
    }
    public void setRoom(Point p, string r)
    {
        board[p.x + 2, 2 - p.y] = r;
    }

     
        
public override string ToString()
{
    string s = "";
    for (int row = 0; row < 5; row++)
    {
        for (int col = 0; col < 5; col++)
        {
            s += (board[col, row] + " ");
        }
        s += "\n";
    }
    return s;
}
}
