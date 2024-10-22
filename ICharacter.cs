public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    void Move(string direction);
    void Interact(string obj);
    void Attack(ICharacter target);
}
