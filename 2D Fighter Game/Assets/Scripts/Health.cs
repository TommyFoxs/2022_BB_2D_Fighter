using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100f;
    public float health;

    private float hitTimer = 0.15f;
    public bool isHit = false;

    public Rigidbody2D myRigidbody;

    Movement moveScript;


    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<Movement>();
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float damage)
    {
        if (!isHit)
        {
            health -= damage;
            StartCoroutine(Knockback()); //tee die funktion tähän KANNATTAA KOSKA UPDATE ON KINDA BAD
        }
    }
    IEnumerator Knockback()
    {
        isHit= true;
        myRigidbody.velocity = new Vector2(moveScript.facing * -2.5f, 2.5f);
        yield return new WaitForSeconds(hitTimer);
        isHit = false;
    }

    private void Die()
    {
        //tee kuoleminen!!!!!!!! :P
    }

}
