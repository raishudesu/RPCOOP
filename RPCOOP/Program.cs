using System;
using System.Collections;
public class RPCOOP
{
    static void Main(string[] args)
    {
        string[] RPC = { "Rock", "Paper", "Scissor" };
        string[] WDS = { "Win", "Draw", "Lose" };
        string player_ans, comp_ans;
        string player;
        int x;
        Random rand = new Random();
        do 
        { 

            Console.WriteLine("WELCOME TO THE ROCK PAPER SCISSOR GAME!\n" +
                "[R] - ROCK\n" +
                "[P] - PAPER\n" +
                "[S] - SCISSOR");

            Console.WriteLine("Select your weapon!: ");

            player = Convert.ToString(Console.ReadLine());
            if (player == "R" | player == "P" | player == "S")
            {

                switch (player)
                {
                    case "R":
                        {
                            x = rand.Next(0, 2);
                            player_ans = RPC[0];
                            comp_ans = RPC[x];
                            if (player_ans == comp_ans)
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[1]);
                            }
                            else if (comp_ans == RPC[1])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[2]);
                            }
                            else if (comp_ans == RPC[2])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[1]);
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                            Console.WriteLine("Do you wanna try again?\n" +
                                    "If yes, type yes, if no, press any key");
                            break;
                        }
                    case "P":
                        {
                            x = rand.Next(0, 2);
                            player_ans = RPC[1];
                            comp_ans = RPC[x];
                            if (player_ans == comp_ans)
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[1]);
                            }
                            else if (comp_ans == RPC[0])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[0]);
                            }
                            else if (comp_ans == RPC[2])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[2]);
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                            Console.WriteLine("Do you wanna try again?\n" +
                                    "If yes, type yes, if no, press any key");
                            break;
                        }
                    case "S":
                        {
                            x = rand.Next(0, 2);
                            player_ans = RPC[2];
                            comp_ans = RPC[x];
                            if (player_ans == comp_ans)
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[1]);
                            }
                            else if (comp_ans == RPC[0])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[2]);
                            }
                            else if (comp_ans == RPC[1])
                            {
                                Console.WriteLine("Your answer is: " + player_ans);
                                Console.WriteLine("Computer's answer is: " + comp_ans);
                                Console.WriteLine(WDS[0]);
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                            Console.WriteLine("Do you wanna try again?\n" +
                                    "If yes, type yes, if no, press any key");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
            }
            else if (player.Length < 1)
            {
                Console.WriteLine("Error\n" +
                    "Do you wanna try again?\n" +
                    "If yes, type yes, if no, press any key");
            }
            else
            {
                Console.WriteLine("Error\n" +
                    "Do you wanna try again?\n" +
                    "If yes, type yes, if no, press any key");
            }

        } while (Console.ReadLine() == "yes");
    }
}