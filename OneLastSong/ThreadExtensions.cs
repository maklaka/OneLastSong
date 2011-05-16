using System;

namespace OneLastSong
{
    public static class ThreadExtensions
    {
        public static void SafeInvoke(this Action action)
        {
            if(action == null)
                return;

            action();
        }
    }
}