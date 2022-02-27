using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Add this script as a component for player
public class ItemCollection : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private Text scoretext;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            scoretext.text = "Total Score: " + coins;
            //Debug.Log("Total Score: " + coins);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}