//Gemaakt door: Swan
public class SpreadShot : PlayerBulletDecorator
{
    public SpreadShot(Bullet bullet): base(bullet) { }

    public float _damage = 5;
    public int _amountOfPojectiles = 3;

    //Todo: add logic for firing to more bullets at 45deg from spawnPosition

    public override string GetBulletType()
    {
        string bulletType = base.GetBulletType();
        bulletType += "\r\n moar bullets from the side";
        return bulletType;
    }
}
