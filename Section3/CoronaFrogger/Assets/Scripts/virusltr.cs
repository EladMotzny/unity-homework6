using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusltr : MonoBehaviour
{
    public Rigidbody2D rb;
    [Tooltip("The lower end of the possible speed for the enemy")] [SerializeField] public float lowspeed = 4f;
    [Tooltip("The higher end of the possible speed for the enemy")] [SerializeField] public float highspeed = 12f;
    [Tooltip("The actual enemy speed")] [SerializeField] public float speed = 1f;

    private void Start()
    {
        speed = Random.Range(lowspeed,highspeed);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.right*Time.fixedDeltaTime*speed);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (this.tag == "covid" && screenPosition.y < 0)
            Destroy(this.gameObject);
    }
}
