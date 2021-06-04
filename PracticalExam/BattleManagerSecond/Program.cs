using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleManagerSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var playerData = new Dictionary<string, List<int>>();

            while ((input = Console.ReadLine()) != "Results")
            {
                string[] inputArray = input.Split(":")
                    .ToArray();

                string command = inputArray[0];

                if (command == "Add")
                {
                    string playerName = inputArray[1];
                    int playerHealth = int.Parse(inputArray[2]);
                    int playerEnergy = int.Parse(inputArray[3]);

                    int[] playerStats = new int[1];
                    playerStats[0] = playerHealth;
                    playerStats[1] = playerEnergy;

                    if (!playerData.ContainsKey(playerName))
                    {
                        playerData[playerName] = new List<int>();

                        for (int i = 0; i < playerStats.Length; i++)
                        {
                            playerData[playerName].Add(playerStats[i]);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
