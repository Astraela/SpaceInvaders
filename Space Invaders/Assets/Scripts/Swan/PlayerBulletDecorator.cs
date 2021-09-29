public class PlayerBulletDecorator : IBullet
{
    private IBullet _bullet;

    public PlayerBulletDecorator(IBullet bullet)
    {
        _bullet = bullet;
    }

    public virtual string GetBulletType()
    {
        return _bullet.GetBulletType();
    }
}
