/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 */
using System.IO;

namespace GameLibrary
{

    public class GameLog
    {
        //path for log location. set in a txt file
        public string filepath = @"../../gamelog.txt";

        //method that takes in a string then appends/writes the string to an outputfile
        public void Log(string message)
        {

            StreamWriter streamWriter = File.AppendText(filepath);

             streamWriter.WriteLine(message);
                    streamWriter.Close();


        }

        //clearing the log files
        public void ClearLog(string message)
        {
            StreamWriter streamWriter = new StreamWriter(filepath);
            streamWriter.WriteLine(message);
            streamWriter.Close();


        }

        //logging stats
        public void LogRound(GameLog gameLog, int roundNumber, Player playerOne, Player playerTwo, CenterCards gameCenter)
        {
            gameLog.Log("\nROUND: " + roundNumber.ToString()
            + "\n\t" + playerOne.getHand().ToString(playerOne.getHand(), playerOne.getName())
            + "\n\n\t" + playerTwo.getHand().ToString(playerTwo.getHand(), playerTwo.getName())
            + gameCenter.ToString(gameCenter));
        }

    }
}
