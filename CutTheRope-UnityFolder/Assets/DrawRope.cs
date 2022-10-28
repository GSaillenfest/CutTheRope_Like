using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRope : MonoBehaviour
{
    Transform[] ropeParts;
    [SerializeField]
    GameObject pin;
    GameObject candy;

    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        ropeParts = GetComponentsInChildren<Transform>();
        line = GetComponent<LineRenderer>();
        line.positionCount = ropeParts.Length;
        line.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < line.positionCount; i++)
        {
            line.SetPosition(i, ropeParts[i].position);
        }
    }
}
