using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, int>();
            var energy = new Dictionary<string, int>();

            string input = string.Empty;

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

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, playerHealth);
                    }
                    else
                    {
                        players[playerName] += playerHealth;
                    }
                    if (!energy.ContainsKey(playerName))
                    {
                        energy.Add(playerName, playerEnergy);
                    }
                    else
                    {
                        energy[playerName] += playerEnergy;
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = inputArray[1];
                    string defenderName = inputArray[2];
                    int damage = int.Parse(inputArray[3]);

                    if (players.ContainsKey(attackerName) && players.ContainsKey(defenderName))
                    {
                        players[defenderName] -= damage;

                        if (players[defenderName] <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            players.Remove(defenderName);
                            energy.Remove(defenderName);
                        }

                        energy[attackerName] -= 1;

                        if (energy[attackerName] <= 0)
                        {
                            Console.WriteLine($"{attackerName} was disqualified!");
                            players.Remove(attackerName);
                            energy.Remove(attackerName);
                        }
                    }
                }
                else if (command == "Delete")
                {
                    string playerName = inputArray[1];

                    if (playerName == "All")
                    {
                        players.Clear();
                        energy.Clear();
                    }
                    else if (players.ContainsKey(playerName))
                    {
                        players.Remove(playerName);
                        energy.Remove(playerName);
                    }
                }
            }

            Console.WriteLine($"People count: {players.Count}");

            List<string> names = new List<string>();
            List<string> health = new List<string>();
            List<string> energyValues = new List<string>();

            foreach (var player in players.OrderBy(x => x.Key))
            {
                names.Add(player.Key);
                health.Add(player.Value.ToString());
            }

            foreach (var player in energy.OrderBy(x => x.Key))
            {
                energyValues.Add(player.Value.ToString());
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} - {health[i]} - {energyValues[i]}");
            }
        }
    }
}
