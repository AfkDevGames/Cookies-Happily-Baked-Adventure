using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var evil = collision.collider.GetComponent<BossHealth>();
        if (evil)
        {
            evil.TakeHit(1);
        }
        Destroy(gameObject);
    }
}
