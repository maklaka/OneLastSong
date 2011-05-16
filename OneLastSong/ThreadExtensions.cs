using System;

namespace OneLastSong
{
    public static class ThreadExtensions
    {
        /// <summary>
        /// Events may not have any handlers wired up, or another thread may kill them before you can invoke them.
        /// This method copies the event locally (implicitly, as a method param) and checks the state. Basically, 
        /// ignoring other threads mutating the public event.
        /// </summary>
        public static void SafeInvoke(this Action action)
        {
            if(action == null)
                return;

            action();
        }
    }
}