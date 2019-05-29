using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed = 600f;
    public float mouvement  = 0f;

    // Update is called once per frame
    void Update()
    {
        mouvement  = Input.GetAxisRaw("Horizontal");
    


    }


    private  void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, mouvement* Time.fixedDeltaTime * -movespeed);
    }



    private void OnTriggerEnter2D(Collider2D collision)

    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    
    }
}
