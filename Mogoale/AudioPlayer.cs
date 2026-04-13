using System;
using System.IO;
using System.Media;

namespace Mogoale
{
    class AudioPlayer
    {
        public void PlayMusic(string fileName)//method to play music
        {
            try
            {
                // Build correct path to assets folder
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", fileName);

                if (File.Exists(fullPath))
                {
                    SoundPlayer player = new SoundPlayer(fullPath);
                    player.Load();        
                    player.PlaySync();    
                }
                else
                {
                    Console.WriteLine("Audio file not found: " + fullPath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error playing audio.");
            }
        }
    }
}