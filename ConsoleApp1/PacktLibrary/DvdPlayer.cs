

namespace PacktLibrary
{
    public class DvdPlayer : IPlayable
    {
        public void Play()
        {
            WriteLine("Playing");
        }

        public void Pause() { WriteLine("Dvd player stopped"); }

        // here this one is not implementing the stop method.
        // Because Stop() method have default implementation in IPlayable
    }
}
