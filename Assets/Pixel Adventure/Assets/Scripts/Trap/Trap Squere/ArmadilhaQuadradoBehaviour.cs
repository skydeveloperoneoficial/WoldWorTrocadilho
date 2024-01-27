using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityStandardAssets._2D;
public class ArmadilhaQuadradoBehaviour : MonoBehaviour
{


    public bool enableGravity;
    public bool invertGravity;
    [SerializeField]private Rigidbody2D rd;
    // Use this for initialization
    void Start()
    {
        enableGravity = false;
        
            
        //rd = FindObjectOfType(typeof(Rigidbody2D)) as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {

        OnGravity();
        

    }

    private void OnGravity()
    {
        if (enableGravity)
            rd.gravityScale = 002;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enableGravity = true;
            
            
        }
        else
        {
            enableGravity = false;
        }





    }
   

}
