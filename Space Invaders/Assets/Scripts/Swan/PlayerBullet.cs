public class PlayerBullet : IBullet
{
    private float _damage = 10;
    private float _speed = 5;
    private int _amountOfPojectiles = 1;
    float IBullet.damage { get => _damage; }
    float IBullet.speed { get => _speed; }
    int IBullet.amountOfPojectiles { get => _amountOfPojectiles; }


    public string GetBulletType()
    {
        return "Normal bullet";
    }


}
