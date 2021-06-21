using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCatchPickUp : MonoBehaviour
{
    private int sunCounter;
    public Text allPickedUpText;
    public Text scoreText;
    public AudioSource audio2;
    public AudioSource audio5;
    // Start is called before the first frame update
    void Start()
    {
       
        sunCounter = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sun")
        {
            sunCounter = sunCounter + 1;
            Destroy(other.gameObject);
            scoreText.text = sunCounter.ToString() + "/3 Sonnen";
            if (sunCounter == 3)
            {
                allPickedUpText.enabled = true;
                StartCoroutine("WaitText");
            }
        }


    }
    IEnumerator WaitText()
    {
        yield return new WaitForSeconds(5);
        allPickedUpText.enabled = false;
    }
}

