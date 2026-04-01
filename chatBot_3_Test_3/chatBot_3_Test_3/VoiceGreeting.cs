using System;
using NAudio.Wave;

class VoiceGreeting
{
    public static void PlayGreeting()
    {
        try
        {
            using (var audioFile = new AudioFileReader("welcome.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        catch
        {
            Console.WriteLine("Audio greeting could not be played.");
        }
    }
}