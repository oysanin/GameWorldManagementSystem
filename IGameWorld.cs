public interface IGameWorld
{
    void LoadWorld();
    void UpdateEnvironment(string eventDescription);
    void ProcessEvent(string eventName);
}
