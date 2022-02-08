using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[DefaultExecutionOrder(1000)]
public class UIHandler : MonoBehaviour
{
    public Text chosenShapeText;

    private string shapeName;
    private string playerName;

    // Start is called before the first frame update
    void Awake()
    {
        if (GameManager.Instance.savedShape != null)
        {
            playerName = GameManager.Instance.savedName;
            shapeName = GameManager.Instance.savedShape.name;
        }
        else
        {
            playerName = "Bill";
            shapeName = GameManager.Instance.defaultShape.name;
        }

        chosenShapeText.text = "Hello, " + playerName + ".\nYou have chosen: " + shapeName;
    }
}
