using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.score += 1;
            Debug.Log(GameManager.Instance.score);
        }
    }
}
