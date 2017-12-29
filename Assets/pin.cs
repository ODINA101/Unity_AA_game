using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour {

    // Use this for initialization
    public bool isPinned = false;
    public float speed = 20f;

    public Rigidbody2D rb;

    private void Update()
    {
        if(!isPinned) { 
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D (Collider2D col)
    { 
        if(col.tag == "rotator")
        {
            transform.SetParent(col.transform);
            col.GetComponent<rotator>().speed *= -1; // same col.GetComponent<rotator>().speed = col.GetComponent<rotator>().speed * -1 :)
            isPinned = true;
        }else if (col.tag == "Pin")
        {

            FindObjectOfType<gameManager>().EndGame();
            //End game

        }
    }
  
}
