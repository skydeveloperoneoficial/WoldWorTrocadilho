using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapis : MonoBehaviour
{
    [SerializeField] GameObject key;
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
            Destroy(gameObject);
        }

    }
}
