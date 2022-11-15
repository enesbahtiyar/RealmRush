using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float speed = 1f;

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            Vector3 startposition = transform.position;
            Vector3 endposition = waypoint.transform.position;
            float travelpercent = 0f;

            transform.LookAt(endposition);

            while (travelpercent < 1f)
            {
                travelpercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startposition, endposition, travelpercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
