using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMaker : MonoBehaviour
{
    public GameObject SwordmanPrefab;
    public GameObject ArcherPrefab;
    public GameObject TankPrefab;
    public GameObject BomberPrefab;
    private float cost;
    private int Rand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0f, 0f, 0f);
        Rand = Random.Range(0, 100);
        if (Rand % 3 == 0)
        {
            pos = new Vector3(7.3f, -4f, 0f);
        }
        else if (Rand % 3 == 1)
        {
            pos = new Vector3(7.3f, 0f, 0f);
        }
        else if (Rand % 3 == 2)
        {
            pos = new Vector3(7.3f, 4f, 0f);
        }
        cost += Time.deltaTime;
        if (cost >= 5)
        {
            cost -= 5;
            Rand = Random.Range(1, 4);
            if (Rand == 1)
            {
                Instantiate(SwordmanPrefab, pos, Quaternion.identity);
            }
            if (Rand == 2)
            {
                Instantiate(ArcherPrefab, pos, Quaternion.identity);
            }
            if (Rand == 3)
            {
                Instantiate(BomberPrefab, pos, Quaternion.identity);
            }
            if (Rand == 4)
            {
                Instantiate(TankPrefab, pos, Quaternion.identity);
            }
        }
    }
}
