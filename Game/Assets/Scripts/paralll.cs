using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralll : MonoBehaviour
{
    [SerializeField]
    private float moveSpd = 1f;

    [SerializeField]
    private float offset;

    private Vector2 startPos;
    private float newXPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newXPos = Mathf.Repeat(Time.time * -moveSpd, offset);

        transform.position = startPos + Vector2.right * newXPos;
    }
}
