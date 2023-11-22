using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "New Score")]
public class ScoreDatas : ScriptableObject


{
    // Start is called before the first frame update
    public int ScoreValue;

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    public void UpdateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 999999);
        UpdateScoreUI();
    }
    public void InitScoreValue(int initValue)
    {
        UpdateScoreValue(0);
    }
    public void UpdateScoreUI()
    {
        OnUpdate?.Invoke (ScoreValue);
    }
}
