using System;
using System.Collections.Generic;

namespace E1_6_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsArray = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(songsArray);

            string cmd;
            while (songs.Count > 0)
            {
                cmd = Console.ReadLine();

                if (cmd.ToLower().Contains("play"))
                {
                    songs.Dequeue();
                }
                else if (cmd.ToLower().Contains("add"))
                {
                    cmd = cmd.Replace("Add ", "");

                    if (songs.Contains(cmd))
                    {
                        Console.WriteLine($"{cmd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(cmd);
                    }
                }
                else if (cmd.ToLower().Contains("show"))
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
