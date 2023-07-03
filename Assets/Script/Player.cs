 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;

   
     public GameObject pfLaser;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        velocidade = 6.0f ;
        transform.position = new Vector3(0f,-2.2f,0);
    }

    // Update is called once per frame
    void Update()
    {
         
       if (Input.GetKeyDown(KeyCode.Space)){
               Instantiate (pfLaser, transform.position + new Vector3(0,1.1f,0), Quaternion.identity);
       }                  

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);

        if ( transform.position.x  > 7.37f) {
            transform.position = new Vector3(-9.85f,transform.position.y,0);
        }

        if ( transform.position.x  < -7.37f  ) {
            transform.position = new Vector3(7.37f,transform.position.y,0);
        
        }
          
   }

}