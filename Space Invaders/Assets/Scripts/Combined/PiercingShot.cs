//Gemaakt door: Swan
public class PiercingShot : PlayerBulletDecorator
{
    public PiercingShot(Bullet bullet) : base(bullet) { }

    private float _damage = 5;
    //Todo: add logic for making the bullets go through one extra enemy

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n bullets go through enemy";
        return bulletType;
    }
}