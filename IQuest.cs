public interface IQuest
{
    string Title { get; }
    string Description { get; }
    bool IsCompleted { get; }
    void Assign(ICharacter character);
    void TrackProgress();
    void Complete();
    string Reward { get; }
}
