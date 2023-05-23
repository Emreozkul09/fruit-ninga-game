using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float minX;
    public float maxX;
    public Sprite[] sprites;

    public float startime;

    private float time;
    void Start()
    {
        
        
    }
    private void spawnerobject(){
        GameObject newPrefab=Instantiate(prefab);
        newPrefab.transform.position=new Vector2(
            Random.Range(minX,maxX),
            transform.position.y
        );
        Sprite randomSprite=sprites[Random.Range(0,sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite=randomSprite;

    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0){
            spawnerobject();
            time=startime;

        }
        else{
            time-=Time.deltaTime;
        }
    
    }
}
