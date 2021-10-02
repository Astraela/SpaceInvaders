//Gemaakt door: Swan
public class PlayerBullet : Bullet
{
    private float _damage = 10;
    private float _speed = 5;
    private int _amountOfPojectiles = 1;


    public override string GetBulletType()
    {
        return "Normal bullet";
    }


}
