using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotate : MonoBehaviour
{
    float speed = 50f;
    bool moveUpBool;
    private void Start()
    {
        moveUpBool = true;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (moveUpBool)
        {
            MoveUp();
        }
        else
        {
            MoveDown();
        }
    }
    void MoveUp (){
        MoveSun(0.01f);
        if (transform.position.y >= 0f)
        {
            moveUpBool = false;
        }
    }
    void MoveDown()
    {
        MoveSun(-0.01f);
        if (transform.position.y <= -0.5f)
        {
            moveUpBool = true;
        }
    }
    void MoveSun(float yValue)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + yValue, transform.position.z);

    }
}
