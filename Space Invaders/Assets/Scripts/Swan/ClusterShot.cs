public class ClusterShot : PlayerBulletDecorator
{
    public ClusterShot(IBullet bullet) : base(bullet) { }

    private float _damage = 4.5f;
    private int _amountOfPojectiles = 15;

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n bullets go everywhere";
        return bulletType;
    }
}