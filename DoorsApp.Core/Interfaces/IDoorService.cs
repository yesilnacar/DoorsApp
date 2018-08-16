using DoorsApp.Core.Domain;

namespace DoorsApp.Core.Interfaces
{
    public interface IDoorService
    {
        string ToggleDoorState(Door door);
    }
}
