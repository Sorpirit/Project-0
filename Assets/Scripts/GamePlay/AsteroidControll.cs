using UnityEngine;

public class AsteroidControll : MonoBehaviour
{
    GameObject Mat;

    [SerializeField] private float maxHp;
    private float hp;
    [SerializeField] private float healPoints;
    [SerializeField] private ParticleSystem hitAnim;
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private GameObject asteroid;

    private SpriteRenderer sprite;

    private Color initialColor;
    private bool isHited;

    private void Start()
    {
        Mat = GameObject.FindGameObjectWithTag("MaterialManager");

        hp = maxHp;

        sprite = GetComponent<SpriteRenderer>();
        initialColor = sprite.color;
    }
    private void LateUpdate()
    {
        if (!isHited) Heal();
        isHited = false;
    }

    public void Hit(float damage)
    {
        hp -= damage;
        hitAnim.Play();

        if (hp <= 0)
        {
            hitAnim.Stop();
            Instantiate(explosion, transform.position, Quaternion.identity).Play();
            crateSmallerAsteroid();
            Destroy(gameObject);
        }

        setAsteroidColor();
        isHited = true;
    }

    private void Heal()
    {
        hp += healPoints;

        if (hp > maxHp) hp = maxHp;

        setAsteroidColor();
    }

    private void setAsteroidColor()
    {
        float chengVal = hp / maxHp;
        Color nColor = new Color(initialColor.r, initialColor.g * chengVal, initialColor.b * chengVal);
        sprite.color = nColor;
    }

    private void crateSmallerAsteroid()
    {
        Mat.GetComponent<Materials>().AddMaterial0();

        GameObject aster = Instantiate(asteroid, transform.position,Quaternion.identity);

        float xScale = Random.Range( transform.localScale.x * 0.1f, transform.localScale.x);
        float yScale = Random.Range( transform.localScale.y * 0.1f, transform.localScale.y);

        aster.transform.localScale = new Vector3(xScale,yScale,1);

        Rigidbody2D asterRb = aster.GetComponent<Rigidbody2D>();
        if(asterRb != null)
        {
            
            asterRb.AddForce(new Vector2(xScale,yScale).normalized, ForceMode2D.Impulse);
        }
    }
}
