using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lapis : MonoBehaviour
{
    [SerializeField] GameObject key;
    public TextMeshProUGUI resposta;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (key == null)
        {

            resposta.enabled = true;
            Destroy(gameObject);
        }
        else if (other.transform.gameObject.CompareTag("Player"))
        {
                gc.SwitchState(stateMachine.DEAD);

                other.GetComponent<CharacterMoviment>();
                //Debug.Log("Player Dead");//
        }
        
    }
}
