using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject Balista;
    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(Balista, transform.position, Quaternion.identity);
            isPlaceable = false;
        }
            
    }
}
