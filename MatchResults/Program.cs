using System;
using System.Collections.Generic;

namespace MatchResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string matchData = System.IO.File.ReadAllText(@"C:\Users\KAHJ\Downloads\Sidste runde i hver kamp\get5_backup_matchmajorkamp1_map0_round29.txt");
            
            string[] matchArray = matchData.Split("\"");
            List<string> players = new List<string>();
            string[] playerString;
            string[] playerData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

            // Make a list of all players
            int i1 = 0;
            foreach (var p in matchArray)
            {
                if (p == "players")
                {
                    players.Add(matchArray[i1 + 4]);
                    players.Add(matchArray[i1 + 8]);
                    players.Add(matchArray[i1 + 12]);
                    players.Add(matchArray[i1 + 16]);
                    players.Add(matchArray[i1 + 20]);
                }
                
                i1++;
            }

            for (int x = 0; x < 3; x++)
            {
                players.RemoveAt(12);
            }
            // End of player list

            playerString = players.ToArray();

            int i2 = 0;
            foreach (var player in playerString)
            {
                bool rounds = false;
                bool kills = false;
                bool hsKills = false;
                bool deaths = false;
                bool assists = false;
                bool score = false;
                bool damage = false;
                bool mvp = false;
                bool oneKill = false;
                bool twoKill = false;
                bool threeKill = false;
                bool fourKill = false;
                bool fiveKill = false;

                int i3 = 0;
                foreach (var p in matchArray)
                {
                    if (p == player)
                    {
                        for (int c4 = i3-6; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "roundsplayed" && rounds == false)
                            {

                                playerData[0] = matchArray[c4 + 2];
                                rounds = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3+50; c4++)
                        {
                            if (matchArray[c4] == "kills" && kills == false)
                            {
                                playerData[1] = matchArray[c4 + 2];
                                kills = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "headshot_kills" && hsKills == false)
                            {
                                playerData[2] = matchArray[c4 + 2];
                                hsKills = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "deaths" && deaths == false)
                            {
                                playerData[3] = matchArray[c4 + 2];
                                deaths = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "assists" && assists == false)
                            {
                                playerData[4] = matchArray[c4 + 2];
                                assists = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "contribution_score" && score == false)
                            {
                                playerData[5] = matchArray[c4 + 2];
                                score = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 50; c4++)
                        {
                            if (matchArray[c4] == "damage" && damage == false)
                            {
                                playerData[6] = matchArray[c4 + 2];
                                damage = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 75; c4++)
                        {
                            if (matchArray[c4] == "mvp" && mvp == false)
                            {
                                playerData[7] = matchArray[c4 + 2];
                                mvp = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 75; c4++)
                        {
                            if (matchArray[c4] == "1kill_rounds" && oneKill == false)
                            {
                                playerData[8] = matchArray[c4 + 2];
                                oneKill = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 75; c4++)
                        {
                            if (matchArray[c4] == "2kill_rounds" && twoKill == false)
                            {
                                playerData[9] = matchArray[c4 + 2];
                                twoKill = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 75; c4++)
                        {
                            if (matchArray[c4] == "3kill_rounds" && threeKill == false)
                            {
                                playerData[10] = matchArray[c4 + 2];
                                threeKill = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 75; c4++)
                        {
                            if (matchArray[c4] == "4kill_rounds" && fourKill == false)
                            {
                                playerData[11] = matchArray[c4 + 2];
                                fourKill = true;
                            }
                        }

                        for (int c4 = i3; c4 < i3 + 100; c4++)
                        {
                            if (matchArray[c4] == "5kill_rounds" && fiveKill == false)
                            {
                                playerData[12] = matchArray[c4 + 2];
                                fiveKill = true;
                            }
                        }

                        if (playerData[0] != "")
                        {
                            Console.WriteLine(p + "," + 
                                                playerData[0] + "," + 
                                                playerData[1] + "," + 
                                                playerData[2] + "," + 
                                                playerData[3] + "," + 
                                                playerData[4] + "," +
                                                playerData[5] + "," +
                                                playerData[6] + "," +
                                                playerData[7] + "," +
                                                playerData[8] + "," +
                                                playerData[9] + "," +
                                                playerData[10] + "," +
                                                playerData[11] + "," +
                                                playerData[12]);
                        }
                        


                    }


                    i3++;
                }
                playerData[0] = "";
                playerData[1] = "";
                playerData[2] = "";
                playerData[3] = "";
                playerData[4] = "";
                playerData[5] = "";
                playerData[6] = "";
                playerData[7] = "";
                playerData[8] = "";
                playerData[9] = "";
                playerData[10] = "";
                playerData[11] = "";
                playerData[12] = "";

                i2++;
            }
        }
    }
}
