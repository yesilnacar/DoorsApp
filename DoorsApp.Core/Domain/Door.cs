using DoorsApp.Core.Enums;

namespace DoorsApp.Core.Domain
{
    public class Door
    {
        public Door()
        {
            DoorState = State.Closed;
        }

        public State DoorState { get; set; }
    }
}
