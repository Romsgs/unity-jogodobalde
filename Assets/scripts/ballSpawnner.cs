using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ballSpawnner : MonoBehaviour
{
    //Intervalo
    public float interval = 1;
    // CoolDown
    public float cooldown = 0;
    // Lista de Bolinhas: publica
    public List<GameObject> prefabs;
    //Ponto de origem
    public Vector3 originPoint = new Vector3(0, 0, 0);
    public int MaxRangeXRight = 10;
    public int MaxRangeXLeft = -10;
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
        cooldown -= Time.deltaTime;
        if (cooldown <= 0f)
        {
            cooldown = interval;
            SpawnBall();
        }
    }
    
    private void SpawnBall()
    {
        int prefabeIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabeIndex];
        int randomX = Random.Range(MaxRangeXLeft, MaxRangeXRight);
        Vector3 position = new Vector3(randomX,originPoint.y,originPoint.z);

        Quaternion rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }

}
