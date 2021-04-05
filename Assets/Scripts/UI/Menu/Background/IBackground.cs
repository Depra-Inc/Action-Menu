namespace FD.UI.Menu.Background
{
    public interface IBackground
    {
        bool IsActive { get; }

        BackgroundType Type { get; }

        void Enable();
        void Disable();
    }
}