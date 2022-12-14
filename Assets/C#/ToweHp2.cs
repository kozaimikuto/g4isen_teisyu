using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ToweHp2 : MonoBehaviour
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
        if (Towerhp <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        PresentHptex.text = Towerhp.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Swordman"))
        {
            Towerhp -= 2;
        }
        if (other.gameObject.CompareTag("Bomber"))
        {
            Towerhp -= 3;
        }
        if (other.gameObject.CompareTag("Archer"))
        {
            Towerhp -= 1;
        }
        if (other.gameObject.CompareTag("Tank"))
        {
            Towerhp -= 3;
        }
        Destroy(other.gameObject);
    }
}
