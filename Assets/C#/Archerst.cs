using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archerst : MonoBehaviour
{
    private float speed = 0.08f;
    public Transform target;
    private int AHp = 1;
    // private int Atk = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
        if (AHp <= 0)
        {
            Destroy(this.gameObject);
        }
    } 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman2"))
        {
            AHp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber2"))
        {
            AHp -= 3;
        }
        if (other.gameObject.CompareTag("Archer2"))
        {
            AHp -= 1;
        }
        if (other.gameObject.CompareTag("Tank2"))
        {
            AHp -= 3;
        }
    }
}
