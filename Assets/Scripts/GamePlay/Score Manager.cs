using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int highestScore;
    [SerializeField] private int totalScore;

    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();

    public static ScoreManager singleton;

    private void Awake()
    {
        singleton = this;
        
    }

    private void Start()
    {
        highestScore = PlayerPrefs.GetInt("HSCORE");
        OnHighestScoreChanged.Invoke(highestScore);
    }
    public void RegisterHighScore()
    {
        if (totalScore > highestScore)
        {
            PlayerPrefs.SetInt("HSCORE", totalScore); //save score into playerPrefs
            highestScore = totalScore;
            OnHighestScoreChanged.Invoke(highestScore);
        }
      
    }
    public void IncreaseScore()
    {
        totalScore += 1;
        OnTotalScoreChanged.Invoke(totalScore);
    }
}

