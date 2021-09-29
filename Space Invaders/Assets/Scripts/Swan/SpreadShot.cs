public class SpreadShot : PlayerBulletDecorator
{
    public SpreadShot(IBullet bullet): base(bullet) { }

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n moar bullets from the side";
        return bulletType;
    }
}
