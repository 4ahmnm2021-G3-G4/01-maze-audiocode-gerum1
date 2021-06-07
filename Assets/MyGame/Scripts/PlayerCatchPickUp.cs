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
        audio5.Play();
        sunCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sun")
        {
            sunCounter = sunCounter + 1;
            Destroy(other.gameObject);
            audio2.Play ();
            audio5.Stop ();
            scoreText.text = sunCounter.ToString() + "/3 Sonnen";
            Debug.Log("Sonne dawischt");
        }
        if (sunCounter == 3)
            allPickedUpText.enabled = true;
    }
}

