using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CardGames;
using CardGames.ClassesAndObjectsBlackJack_GreatResource;

namespace ClassesAndObjectsBlackJack_GreatResource
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to 21 please tell me your name?");
            string playerName = Console.ReadLine();//Gets player name 
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("how much money do you want to put down");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("input only allows digits no decimals");
            }
            Console.WriteLine("Hello " + playerName);
            
            Console.WriteLine("Hello, {0} would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "okay" || answer == "ok")//Starts the game if player responds with yes
            {
                Player player = new Player(playerName, bank);//pass name and string balence to the player class constructor and makes a object called player 
                Game game = new TwentyOneGame();// creates a new game object with the class constructor of TwentyOneGame from the TwentyOneGame class 
                game += player;//adds object player to the object game
                player.isActivelyPlaying = true;// the value for is activly playing is true
                while (player.isActivelyPlaying && player.Balance > 0) //while loop that checks if the player wants to keep playing and has a bal over 0 dollars
                {
                    try
                    {
                        game.Play();//outsources the the funtions of the game to the play method 
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithEx(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occurred");
                        UpdateDbWithEx(ex);
                        Console.ReadLine();
                        return;
                    } 
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
                return;
            }
            

            
            Console.ReadLine();
        }

        private static void UpdateDbWithEx(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=21game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            string queryString = @"INSERT INTO Exception (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; 


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=21game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string querystring = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exception";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>(); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querystring, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.id = Convert.ToInt32(reader["id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
