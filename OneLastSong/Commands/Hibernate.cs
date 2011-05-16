using System.Windows.Forms;

namespace OneLastSong.Commands
{
    public class Hibernate : ICommand
    {
        private readonly bool force = true;
        private readonly bool disableWakeEvent = true;

        public void Execute()
        {
            Application.SetSuspendState(PowerState.Hibernate, force, disableWakeEvent);
        }
    }
}