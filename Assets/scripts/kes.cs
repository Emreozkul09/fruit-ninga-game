using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kes : MonoBehaviour
{
    // Start is called before the first frame update
     

    
    void Start() {
        manager = GameObject.FindObjectOfType<Manager>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Fruit") {
            Destroy(other.gameObject);
            manager.score += 1;
        }
        else if(other.gameObject.tag == "Bomb") {
            manager.restartGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
