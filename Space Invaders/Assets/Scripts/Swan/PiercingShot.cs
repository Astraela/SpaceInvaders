public class PiercingShot : PlayerBulletDecorator
{
    public PiercingShot(IBullet bullet) : base(bullet) { }

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n bullets go through enemy";
        return bulletType;
    }
}