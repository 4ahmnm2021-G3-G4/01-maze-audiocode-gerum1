using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("in Maze" + other.name);
        if (other.tag == "Player")
        {
            transform.parent.GetComponent<PickUpsManager>().coinCounter++;
        }
    }
}
