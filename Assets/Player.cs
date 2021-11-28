using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, new Vector2(-5, -1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
