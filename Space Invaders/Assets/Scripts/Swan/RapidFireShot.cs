public class RapidFireShot : PlayerBulletDecorator
{
    public RapidFireShot(IBullet bullet) : base(bullet) { }

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n Gun Go BRRRRRRR";
        return bulletType;
    }
}