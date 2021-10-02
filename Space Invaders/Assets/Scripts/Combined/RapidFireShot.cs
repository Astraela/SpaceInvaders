//Gemaakt door: Swan
public class RapidFireShot : PlayerBulletDecorator
{
    public RapidFireShot(Bullet bullet) : base(bullet) { }

    private float _damage = 10;
    private float _speed = 5;

    //Todo: add logic for firing more bullets 

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n Gun Go BRRRRRRR";
        return bulletType;
    }
}