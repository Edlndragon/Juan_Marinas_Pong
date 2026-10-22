using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pointP1;
    public int pointP2;
    private string countPoints;
    public TextMeshProUGUI markText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(countPoints);
    }

    // Update is called once per frame
    void Update()
    {
        //UpdatePointsText();
    }

    public void UpdatePointsText()
    {
        countPoints = pointP1 + "|" + pointP2;
        markText.text = countPoints;
    }
}
