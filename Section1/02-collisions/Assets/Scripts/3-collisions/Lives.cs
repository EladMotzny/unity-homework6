using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object after 3 hits")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField lives;
    [SerializeField] int hits = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag && enabled)
        {
               if (hits > 1)
             {
               hits--;
             lives.SetNumber(hits);
            Destroy(other.gameObject);

              }

              else
              {
              lives.SetNumber(hits--);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
             }

        }
    }
}

