using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexascript : MonoBehaviour
{




    public Rigidbody2D rb;
    public float shrinkspeed = 1f;


    // Start is called before the first frame update
    void Start()
    {

        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;


    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale -= Vector3.one*shrinkspeed * Time.deltaTime;
        if(transform.localScale.x<=.5f)
        
        
        {
            Destroy(gameObject);






        }    
    }
}
