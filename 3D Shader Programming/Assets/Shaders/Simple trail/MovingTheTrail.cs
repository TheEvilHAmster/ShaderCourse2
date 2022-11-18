using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingTheTrail : MonoBehaviour
{
    public Vector3 Rotation;

    private void Update()
    {
        transform.Rotate(Rotation * Time.deltaTime);
    }
}
