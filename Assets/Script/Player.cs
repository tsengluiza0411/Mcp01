 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;

    public GameObject pfLaser ;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        velocidade = 3.0f ;
        transform.position = new Vector3(7.37,-5.78,0);
    }

    // Update is called once per frame
    void Update()
    {
        
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);

        if ( transform.position.x  > 7.37f) {
            transform.position = new Vector3(-9.85f,transform.position.y,0);
        }

        if ( transform.position.x  < -7.37f  ) {
            transform.position = new Vector3(7.37f,transform.position.y,0);
        
        }

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*velocidade*entradaVertical);

        if ( transform.position.y  > 0 ) {
            transform.position = new Vector3(transform.position.x,0,0);
        }

        if ( transform.position.y  < -3.95f  ) {
            transform.position = new Vector3(transform.position.x,-3.95f,0);
        }

        if (Input.GetKeyDown(KeyCode.Space)){

            

            }


        
   }

}