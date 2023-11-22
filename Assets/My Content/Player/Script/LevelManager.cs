using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;

   
    public void Start()
    {
        _scoreData.InitScoreValue(0);
    }
}
