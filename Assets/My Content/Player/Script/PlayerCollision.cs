using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        ICollectibles iCollect = other.GetComponent<ICollectibles>();
        if(iCollect != null)
        {
           iCollect.Collect();
        }
    }
}
