using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem swerveInputSystem;
    [SerializeField] private float swerveSpeed = 0.5f;

    private void Awake()
    {
        swerveInputSystem = GetComponent<SwerveInputSystem>();


    }
    private void Update()
    {
        float swerveAmount = Time.deltaTime * swerveSpeed * swerveInputSystem.MoveFactorX;
        transform.Translate(swerveAmount, 0, 0);
    }
}