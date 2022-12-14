using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanks : MonoBehaviour
{
    private float speed = 0.032f;
    public Transform target;
    private int THp = 3;
    // private int Atk = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    if (THp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman2"))
        {
            THp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber2"))
        {
            THp -= 3;
        }
        if (other.gameObject.CompareTag("Archer2"))
        {
            THp -= 1;
        }
        if (other.gameObject.CompareTag("Tank2"))
        {
            THp -= 3;
        }
    }
}
