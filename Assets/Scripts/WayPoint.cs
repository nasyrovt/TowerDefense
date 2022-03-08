using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject tower;

    //Property example (cleaner that get;set)
    public bool IsPlaceable { get { return isPlaceable; } }
    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(tower, transform.position, Quaternion.identity);
            isPlaceable = false;
        }

    }
}
