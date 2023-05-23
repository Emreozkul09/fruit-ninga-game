using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swards : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cutprefab;
    public float cutlifetime;

    private bool drugging;
    private Vector2 swipestart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            drugging=true;
            swipestart  =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if(Input.GetMouseButtonUp(0) && drugging){
            drugging=false;
            cutspawner();
        }
    }
    private void cutspawner(){
        Vector2 swipeand=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject cutinstance=Instantiate(cutprefab,swipestart,Quaternion.identity);

        cutinstance.GetComponent<LineRenderer>().SetPosition(0,swipestart);
        cutinstance.GetComponent<LineRenderer>().SetPosition(1,swipeand);

        Vector2[] colidepoints=new Vector2[2];
        colidepoints[0]=Vector2.zero;
        colidepoints[1]=swipeand-swipestart;
        cutinstance.GetComponent<EdgeCollider2D>().points=colidepoints;
        Destroy(cutinstance,cutlifetime);

    }
}
