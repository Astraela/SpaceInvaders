//Gemaakt door: Swan
public class ClusterShot : PlayerBulletDecorator
{
    public ClusterShot(Bullet bullet) : base(bullet) { }

    public float _damage = 4.5f;
    public int _amountOfPojectiles = 15;

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n bullets go everywhere";
        return bulletType;
    }
}