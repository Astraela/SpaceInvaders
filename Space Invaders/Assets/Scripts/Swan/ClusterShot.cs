public class ClusterShot : PlayerBulletDecorator
{
    public ClusterShot(IBullet bullet) : base(bullet) { }

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n bullets go everywhere";
        return bulletType;
    }
}