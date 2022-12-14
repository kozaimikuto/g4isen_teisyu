using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordmanst : MonoBehaviour
{
    private float speed = 0.04f;
    public Transform target;
    private int SHp = 2;
    // private int Atk = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
        if(SHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman2"))
        {
            SHp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber2"))
        {
            SHp -= 3;
        }
        if (other.gameObject.CompareTag("Archer2"))
        {
            SHp -= 1;
        }
        if (other.gameObject.CompareTag("Tank2"))
        {
            SHp -= 3;
        }
    }
}
