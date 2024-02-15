using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float gameWidth = 20;
    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public int gameOver = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null && Instance != this) {
        Destroy(this);
        } else
        {
            Instance = this;
        }
        

    }
}
