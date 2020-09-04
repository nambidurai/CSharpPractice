using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();  
        void stop()
        {
            WriteLine("default implementation of stop");
        }     
    }
}