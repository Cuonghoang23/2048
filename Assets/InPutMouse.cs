using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPutMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0); // tra ve vi tri con tro chuot
            var post = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(post.x, post.y, 0);   

        }
    }
}
