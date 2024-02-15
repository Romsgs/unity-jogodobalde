using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameOver >= 3)
        {
            return;
        }
        // transform.position += new Vector3()
        bool isPressedLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressedRight = Input.GetKey(KeyCode.RightArrow);
        float movement = speed * Time.deltaTime;

        if (isPressedLeft == isPressedRight) {
            return;
        }

        if (isPressedLeft)
        {
            transform.position -= new Vector3(movement, 0, 0);
        }
        if (isPressedRight)
        {
            transform.position += new Vector3(movement, 0, 0);
        }
  
        if (transform.position.x < -14.9)
        {
            transform.position = new Vector3(-14.9f, transform.position.y, transform.position.z);
        } else if (transform.position.x > 13.8){
            transform.position = new Vector3(13.8f, transform.position.y, transform.position.z);
        }
    }
}
