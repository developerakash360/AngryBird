using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Bird;
    public GameObject pattern;

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            Destroy();
            
        }
    }

    private void Destroy()
    {
        Destroy(Bird);
        Instantiate(pattern,transform.position, Quaternion.identity);
    }
}
