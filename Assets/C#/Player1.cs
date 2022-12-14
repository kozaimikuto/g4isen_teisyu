using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player1 : MonoBehaviour
{
    public GameObject SwordmanPrefab;
    public GameObject ArcherPrefab;
    public GameObject TankPrefab;
    public GameObject BomberPrefab;
    public float cost;
    public Text presentcost;
    private bool cooldown = true;
    private float cooltime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        presentcost.text = cost.ToString();
        cost += Time.deltaTime;
        Vector3 pos1 = new Vector3(-7.1f, 4f, 0f);
        if (cooldown == true)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                if (cost >= 1)
                {
                    Instantiate(SwordmanPrefab, pos1, Quaternion.identity);
                    cost -= 1;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.W))
            {
                if (cost >= 2)
                {
                    Instantiate(ArcherPrefab, pos1, Quaternion.identity);
                    cost -= 2;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.E))
            {
                if (cost >= 3)
                {
                    Instantiate(BomberPrefab, pos1, Quaternion.identity);
                    cost -= 3;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.E))
            {
                if (cost >= 4)
                {
                    Instantiate(TankPrefab, pos1, Quaternion.identity);
                    cost -= 4;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            Vector3 pos2 = new Vector3(-7.1f, 0, 0);
            if (Input.GetKey(KeyCode.A))
            {
                if (cost >= 1)
                {
                    Instantiate(SwordmanPrefab, pos2, Quaternion.identity);
                    cost -= 1;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (cost >= 2)
                {
                    Instantiate(ArcherPrefab, pos2, Quaternion.identity);
                    cost -= 2;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (cost >= 3)
                {
                    Instantiate(BomberPrefab, pos2, Quaternion.identity);
                    cost -= 3;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.F))
            {
                if (cost >= 4)
                {
                    Instantiate(TankPrefab, pos2, Quaternion.identity);
                    cost -= 4;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            Vector3 pos3 = new Vector3(-7.1f, -4f, 0);
            if (Input.GetKey(KeyCode.Z))
            {
                if (cost >= 1)
                {
                    Instantiate(SwordmanPrefab, pos3, Quaternion.identity);
                    cost -= 1;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.X))
            {
                if (cost >= 2)
                {
                    Instantiate(ArcherPrefab, pos3, Quaternion.identity);
                    cost -= 2;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.C))
            {
                if (cost >= 3)
                {
                    Instantiate(BomberPrefab, pos3, Quaternion.identity);
                    cost -= 3;
                    cooldown = false;
                    cooltime = 1;
                }
            }
            if (Input.GetKey(KeyCode.V))
            {
                if (cost >= 4)
                {
                    Instantiate(TankPrefab, pos3, Quaternion.identity);
                    cost -= 4;
                    cooldown = false;
                    cooltime = 1;
                }
            }
        }
        else if(cooldown == false)
        {
            cooltime -= Time.deltaTime * 3;
            if (cooltime <= 0)
            {
                cooldown = true;
            }
        }

    }
}
