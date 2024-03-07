using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingScript : MonoBehaviour
{
    public bool isSwinging;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
               // Makes the player swing the tennis racket
        if (Input.GetKeyDown(KeyCode.Space) && isSwinging == false)
        {
            transform.Rotate(0,-90,0);
            isSwinging = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.transform.Rotate(0,90,0);
            isSwinging = false;
        }
    }
}
