using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viking : MonoBehaviour
{
    public GameObject vikingPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(vikingPrefab, new Vector2(4, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
