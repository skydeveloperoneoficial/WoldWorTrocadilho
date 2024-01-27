using UnityEngine;
using System.Collections;

public class QuandradoUpBehaviour : MonoBehaviour
{
    public bool invertGravity,enableGravity;
    private Rigidbody2D rd;
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        rd =  GetComponent<Rigidbody2D>();
        invertGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        InvertGravity();
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            invertGravity = true;
            
           


        }
        if (collision.gameObject.CompareTag("Player")) 
        {
            gameController.SwitchState(stateMachine.DEAD);
        }
    }

    void InvertGravity()
    {
        
        if (invertGravity)
            rd.gravityScale = -1;
        
    }
   
}
