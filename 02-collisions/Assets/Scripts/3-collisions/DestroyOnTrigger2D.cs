using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject target;
    [SerializeField] NumberField lives;
    [SerializeField] int hits = 3;

    private void OnTriggerEnter2D(Collider2D other) {
       
        if (other.tag == triggeringTag && enabled) {

            if (this.gameObject== target && triggeringTag== "Enemy" && hits >= 1 )
            {
                if (hits == 1)
                { 
                    Destroy(this.gameObject);   
                }
               hits--;
               lives.SetNumber(hits);
               Destroy(other.gameObject);

            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
            
        }
    }
}
