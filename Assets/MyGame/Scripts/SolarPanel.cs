using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarPanel : MonoBehaviour
{
    int sunCounter;
    [SerializeField]
    PickUpsManager pickUpsManagerO;
    [SerializeField]
    GameObject keyGO;
    [SerializeField]
    GameObject textWarningGO;

    private void OnTriggerEnter(Collider other)
    {
        sunCounter = pickUpsManagerO.coinCounter;
        Debug.Log(sunCounter);
        if (sunCounter == 3)
        {
            GetComponent<AudioSource>().Play();
            keyGO.SetActive(true);
            textWarningGO.GetComponent<Text>().text = "Nehme den Schlüssel und sperr' die Tür auf!";
        }
        else if (sunCounter < 3)
        {
            textWarningGO.GetComponent<Text>().text = "Du musst alle drei Sonnen einsammeln";
        }
    }
    private void OnTriggerExit(Collider other)
    {
        textWarningGO.GetComponent<Text>().text = "";
    }
}
