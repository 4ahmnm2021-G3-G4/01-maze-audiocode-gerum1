using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotate : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y >= -1f)
        {
            transform.position = new Vector3(transform.position.x, 1,22 * transform.position.y + 1 * speed * Time.deltaTime, transform.position.z);
        }
        else if (transform.position.y <= 0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1 * speed * Time.deltaTime, transform.position.z);
        }
    }
}
