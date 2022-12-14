using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TowerHp : MonoBehaviour
{
    // Start is called before the first frame update
    public int Towerhp;
    public Text PresentHptex; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Towerhp <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        PresentHptex.text = Towerhp.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman2"))
        {
            Towerhp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber2"))
        {
            Towerhp -= 3;
        }
        if (other.gameObject.CompareTag("Archer2"))
        {
            Towerhp -= 1;
        }
        if (other.gameObject.CompareTag("Tank2"))
        {
            Towerhp -= 3;
        }
        Destroy(other.gameObject);
    }
}
