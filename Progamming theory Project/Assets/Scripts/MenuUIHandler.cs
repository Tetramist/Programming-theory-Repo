using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    private Button cube;
    private Button sphere;

    public void Awake()
    {
        cube = GameObject.Find("Cube").GetComponent<Button>();
        sphere = GameObject.Find("Sphere").GetComponent<Button>();
    }

    public void SetPlayerName(string playerName)
    {
        GameManager.Instance.SavedName = playerName;
    }

    public void ChooseCube()
    {
        GameManager.Instance.savedShape = GameManager.Instance.shapeList[0];
    }

    public void ChooseSphere()
    {
        GameManager.Instance.savedShape = GameManager.Instance.shapeList[1];
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
