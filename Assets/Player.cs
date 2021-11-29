using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerPrefab;

    public float velocity;
    private float entrada;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, new Vector2(-5, -1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        /*entrada = Input.GetAxis("Horizontal");
        transform.position += (Vector3) new Vector2(entrada * velocity * Time.deltaTime, 0);*/

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0.15f, 0, 0);
        }
    }
}
