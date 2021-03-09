using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public GameObject prefab;
    public int speed = 10;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(new Vector2(0.5f, 1.0f) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
