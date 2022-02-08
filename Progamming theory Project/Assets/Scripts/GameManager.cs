using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Encapsulation
    public static GameManager Instance { get; private set; }

    public GameObject[] shapeList;
    public GameObject savedShape;
    public GameObject defaultShape;

    public string savedName { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


}
