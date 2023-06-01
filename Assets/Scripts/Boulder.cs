using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    // Components
    Rigidbody2D rb;

    // Objects

    [SerializeField] Collider2D triggerCollider;
    [Range(0.0f, 60.0f)]
    [SerializeField] float boulderForce;
    [SerializeField] string direction;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void LaunchBoulder()
    {
        // add force to boulder
        // make customizable
        if (direction == "Left")
            rb.AddForce(new Vector2(-boulderForce, 0), ForceMode2D.Impulse);
        else
            rb.AddForce(new Vector2(boulderForce, 0), ForceMode2D.Impulse);
    }
    
}
