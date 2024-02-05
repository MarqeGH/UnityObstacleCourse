using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    private GameObject playerObj = null;

    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0.01f;
    float zValue = 0;

    int hitPoints = 3;
    bool isAlive = true;

    bool ascending = true;

    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null) 
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObj == null)
        playerObj = GameObject.Find("Player");
        
        if (playerObj != null)
            transform.Translate(xValue, yValue, zValue);
        
        if (playerObj.transform.position.y >= 20)
            {
            yValue = -0.01f;
            ascending = false;
            }       
        
        if (playerObj.transform.position.y <= 0) 
            {
            yValue = 0.01f;
            ascending = true;
            }

        else if (playerObj.transform.position.y > 0 & playerObj.transform.position.y < 20 & ascending == true) 
            yValue = 0.01f;
        
    }
}
