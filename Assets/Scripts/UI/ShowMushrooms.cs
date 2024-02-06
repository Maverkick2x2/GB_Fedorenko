using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowMuchrooms : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreMushrooms;
    [SerializeField] private TextMeshProUGUI totalScore;

    private int score;

    public void CollectMushrooms()
    {
        score += 1;
        scoreMushrooms.text = "X: " + score.ToString();
    }

    public void ShowTotalMushrooms()
    {
        totalScore.text = "Количество собранных грибов: " + score.ToString();
    }
}
