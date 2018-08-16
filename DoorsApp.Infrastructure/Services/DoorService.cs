using DoorsApp.Core.Domain;
using DoorsApp.Core.Enums;
using DoorsApp.Core.Helpers;
using DoorsApp.Core.Interfaces;

namespace DoorsApp.Infrastructure.Services
{
    public class DoorService : IDoorService
    {
        public string ToggleDoorState(Door door)
        {
            switch (door.DoorState)
            {
                case State.Open:
                    door.DoorState = State.Closed;
                    break;
                case State.Hold:
                    door.DoorState = State.Closed;
                    break;
                case State.Closed:
                    door.DoorState = State.Open;
                    break;
            }

            return door.DoorState.GetDescription();
        }
    }
}
