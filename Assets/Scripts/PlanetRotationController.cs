using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotationController : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("angular speed, R per sec.")]
    [SerializeField] float degreesPerSeconds;

    void Update()
    {
        RotatePlanets();
    }

    void RotatePlanets()
    {
        transform.rotation *= Quaternion.AngleAxis(degreesPerSeconds * Time.deltaTime, Vector3.up);
    }
}
