// FlightController.cs 
// CENG 454 – HW1: Sky-High Prototype 
// Author: Anıl Ata Çevik | Student ID: 230446031 
 
using UnityEngine; 
 
public class FlightController : MonoBehaviour 
{ 
    [SerializeField] private float pitchSpeed  = 45f;  // degrees/second 
    [SerializeField] private float yawSpeed    = 45f;  // degrees/second 
    [SerializeField] private float rollSpeed   = 45f;  // degrees/second 
    [SerializeField] private float thrustSpeed = 5f;   // units/second 
 
    private Rigidbody rb;
 
    void Start() 
    { 
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    } 
 
    void Update()
    { 
        HandleRotation(); 
        HandleThrust(); 
    } 
 
    private void HandleRotation() 
    { 
        // TODO (Task 3-C): 
        // Pitch   
        // Roll    
 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
} 