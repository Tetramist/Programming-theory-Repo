using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(1001)]
public class ObjectSpawner : MonoBehaviour
{
    GameObject shape;

    // Start is called before the first frame update
    private void Awake()
    {

        if (GameManager.Instance.savedShape != null)
        {
            shape = GameManager.Instance.savedShape; 
        }
        else
        {
            shape = GameManager.Instance.defaultShape;
        }
        Instantiate(shape, shape.transform.position, shape.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
