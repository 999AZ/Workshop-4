using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackNForth : MonoBehaviour
{
    [SerializeField] private float moveDistance = 10f;
    [SerializeField] private float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        var distance = Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.localPosition = new Vector3(0,0,distance);
    }
}