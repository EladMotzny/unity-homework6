using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
        void Update()
        {
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            if (this.tag == "Enemy" &&screenPosition.y < 0)
                Destroy(this.gameObject);
            if (this.tag == "Laser" && screenPosition.y > Screen.height)
            Destroy(this.gameObject);
    }


    
}
