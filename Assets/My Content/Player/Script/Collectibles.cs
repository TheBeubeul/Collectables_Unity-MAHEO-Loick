using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, ICollectibles
{
    [SerializeField] int _value;
    [SerializeField] ScoreDatas _scoreData;
    // Start is called before the first frame update
    public void Collect()
    {
        _scoreData.UpdateScoreValue(_value);
        Destroy(gameObject);
    }
}
