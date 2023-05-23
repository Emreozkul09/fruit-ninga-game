using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float lifetime;

    void Start()
    {
        rb.velocity=new Vector2(
            Random.RandomRange(minX,maxX),
            Random.RandomRange(minY,maxY)
        );
        Destroy(gameObject,lifetime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
