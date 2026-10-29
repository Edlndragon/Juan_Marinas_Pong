using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pointP1;
    public int pointP2;
    private string countPoints;
    public TextMeshProUGUI markText;

    private void Update()
    {
        if (pointP1 >= 5)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void UpdatePointsText()
    {
        countPoints = pointP1 + "|" + pointP2;
        markText.text = countPoints;
    }
}
