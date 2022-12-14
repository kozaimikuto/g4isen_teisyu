using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomberst : MonoBehaviour
{
    private float speed = 0.04f;
    public Transform target;
    private int BHp = 1;
    // private int Atk = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
        if(BHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman2"))
        {
            BHp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber2"))
        {
            BHp -= 3;
        }
        if (other.gameObject.CompareTag("Archer2"))
        {
            BHp -= 0;
        }
        if (other.gameObject.CompareTag("Tank2"))
        {
            BHp -= 3;
        }
    }
}
