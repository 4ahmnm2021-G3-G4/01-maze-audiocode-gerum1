using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveDoor : MonoBehaviour
{
    float t;
    bool keyEntered = true;
    [SerializeField]
    GameObject gameOverGO;
    [SerializeField]
    GameObject timerGO;
    bool moveDownB;
    float posY;
    private void Start()
    {
        posY = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 3f && keyEntered)
        {
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.Return) && keyEntered)
        {
            SceneManager.LoadScene(1);
        }
        if (transform.position.y > posY && moveDownB)
        {
            MoveDown();
        }
    }
    void MoveUp()
    {
        transform.position += new Vector3(0, Mathf.Lerp(0, 0.4f, t), 0);
        t += 0.04f * Time.deltaTime;
    }
    void MoveDown()
    {
        transform.position -= new Vector3(0, Mathf.Lerp(0, 0.4f, t), 0);
        t += 0.04f * Time.deltaTime;
        keyEntered = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            keyEntered = true;
            moveDownB = false;
            GetComponent<AudioSource>().Play();
            gameOverGO.GetComponent<Text>().text = "You Won";
            timerGO.GetComponent<TimerCountdown>().enabled = false;
        }
        if (other.tag == "Player")
        {
            moveDownB = true;
            t = 0;
        }
    }
}
