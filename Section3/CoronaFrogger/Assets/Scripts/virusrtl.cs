using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusrtl : MonoBehaviour
{
    public Rigidbody2D rb;
    [Tooltip("The lower end of the possible speed for the enemy")] [SerializeField] public float lowspeed = 4f;
    [Tooltip("The higher end of the possible speed for the enemy")] [SerializeField] public float highspeed = 12f;
    [Tooltip("The actual enemy speed")] [SerializeField] public float speed = 1f;

    Renderer onScreen;

    private void Start()
    {
        speed = Random.Range(lowspeed,highspeed);
        onScreen = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.left*Time.fixedDeltaTime*speed);
        if (!onScreen.isVisible)
        {
            Destroy(this.gameObject);
        }
    }
}
