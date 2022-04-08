using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartMove()
    {
        float x = Random.Range(-10f,10f);
        float y = Random.Range(-5f,5f);
        transform.Translate( x , y , 0);
    }
}
