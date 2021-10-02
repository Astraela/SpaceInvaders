//Gemaakt door: Swan
public class PlayerBulletDecorator : Bullet
{
    private Bullet _bullet;

    private float _damage = 10;
    private float _speed = 5;
    private int _amountOfPojectiles = 1;

    public PlayerBulletDecorator(Bullet bullet)
    {
        _bullet = bullet;
    }

    public override string GetBulletType()
    {
        return _bullet.GetBulletType();
    }
}
