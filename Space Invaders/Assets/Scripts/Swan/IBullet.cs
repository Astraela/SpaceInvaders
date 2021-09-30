public interface IBullet
{
    float damage { get; }
    float speed { get; }
    int amountOfPojectiles { get; }

    string GetBulletType();

}
