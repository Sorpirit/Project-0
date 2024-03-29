﻿using UnityEngine;

public class AsteroidControll : MonoBehaviour
{
    GameObject Mat;
    GameObject Sup;

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
        Sup = GameObject.FindGameObjectWithTag("SuppliesManager");

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
}
