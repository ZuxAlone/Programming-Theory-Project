using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pointsText;
    [SerializeField] Player player;

    public void UpdatePoints()
    {
        pointsText.text = "Points: " + player.Points;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
