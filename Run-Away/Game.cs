using System;
using System.Collections.Generic;
using System.Text;

public class Game
{ 
    bool isAlive = true;
    Point player;
    Point rabbit;
    Board board;
    string userCmd;
    Random rgen = new Random();
    public Game()
    {
        
        board = new Board();
        player = new Point(-2, rgen.Next(-2, 2));
        rabbit = new Point(0, 0);


        board.setRoom(player, "P");
        board.setRoom(rabbit, "R");

    }

    public void mainLoop()
    {
        int turns = 15;

        while (true)
        {
            turns -= 1;
            //render
            Console.WriteLine(board);
            //get user input
            Console.Write("Enter Cmd: ");
            userCmd = Console.ReadLine().ToUpper();

            
            if (userCmd == "Q")
            {
                Console.WriteLine("Bye.");
                break;
            }
            if (isAlive == false)
            {
                break;

            }
            if (turns == 0)
            {

                Console.WriteLine("You escape and vow to return with the Holy Hand Grenade!");
                Console.WriteLine("You Win! Game Over.");
                break;
            }
            //update
            update();
        }

    }

    public void update()
    {

        //Moves player based on user input
        if (userCmd == "W" && player.y != 2)
        {
            board.setRoom(player, ".");
            player.y++;
            board.setRoom(player, "P");
        }
        else if (userCmd == "A" && player.x != -2)
        {
            board.setRoom(player, ".");
            player.x -= 1;
            board.setRoom(player, "P");
        }
        else if (userCmd == "S" && player.y != -2)
        {
            board.setRoom(player, ".");
            player.y -= 1;
            board.setRoom(player, "P");
        }
        else if (userCmd == "D" && player.x != 2)
        {
            board.setRoom(player, ".");
            player.x++;
            board.setRoom(player, "P");
        }

        //Tells rabbit where to go based on player position
        if (player.y > rabbit.y && player.x == rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.y++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y > rabbit.y && player.x < rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.x-=1;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y > rabbit.y && player.x > rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.y++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y < rabbit.y && player.x == rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.y-=1;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y < rabbit.y && player.x > rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.x++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.x > rabbit.x && player.y == rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.x++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.x > rabbit.x && player.y < rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.y-=1;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.x < rabbit.x && player.y > rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.y++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.x < rabbit.x && player.y < rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.y-=1;
            board.setRoom(rabbit, "R");
           
        }
        else if (player.x < rabbit.x && player.y == rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.x-=1;
            board.setRoom(rabbit, "R");
            
        }

        //If player and rabbit are not in the same row or column rabbit has a 50% chance of moving in any direction 
        else if (player.x != rabbit.x && player.x < rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.x -= 1;
            board.setRoom(rabbit, "R");
            
        }
        
        else if (player.x != rabbit.x && player.x > rabbit.x)
        {
            board.setRoom(rabbit, "*");
            rabbit.x++;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y != rabbit.y && player.y < rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.y -= 1;
            board.setRoom(rabbit, "R");
            
        }
        else if (player.y != rabbit.y && player.y >  rabbit.y)
        {
            board.setRoom(rabbit, "*");
            rabbit.y++;
            board.setRoom(rabbit, "R");
            
        }

        //if rabbit and player are on the same point Console.WriteLine
        if (player.x == rabbit.x && player.y == rabbit.y)
        {
            Console.WriteLine("The Rabbit Ate You! You Lose!");
            Console.WriteLine("Game Over.");
            isAlive = false;
        }
        //if player survives then Console.WriteLine
        if (player.x != rabbit.x && player.y != rabbit.y && isAlive == false)
        {
            Console.WriteLine("You escape and vow to return with the Holy Hand Grenade!");
            Console.WriteLine("You Win! Game Over.");
            isAlive = false;
        }
        //if player and fire are on the same point Console.WritLine
        if (Board.Equals(player, "*"))
        {
            Console.WriteLine("You Died in the Rabbit's Flames!");
            Console.WriteLine("You Lose!Game Over.");
            isAlive = false;
        }
    }
}

