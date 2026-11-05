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
    public int pointsToWin = 5;

    public TextMeshProUGUI markText;
    public AudioClip pointScoreSound;
    public AudioClip winSound;
    public AudioSource _audioSource;

    public GameObject winPanel;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    private void Update()
    {
        if (pointP1 >= pointsToWin || pointP2 >= pointsToWin)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    public void UpdatePointsText()
    {
        countPoints = pointP1 + "|" + pointP2;
        markText.text = countPoints;
        if (pointP1 >= pointsToWin || pointP2 >= pointsToWin)
        {
            _audioSource.clip = winSound;
        }
        else 
        {
            _audioSource.clip = pointScoreSound;
        }
        _audioSource.Play();
    }
}
