using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float fireRate=1f;
    float fireScene=1f;
    [SerializeField]
    GameObject bigBolt;
    [SerializeField]
    float shipSpeed=7.5f;
    Vector2 movement = Vector2.zero;
    float shoot = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.Normalize();
        transform.Translate(movement * shipSpeed * Time.deltaTime);
        fireScene += fireRate * Time.deltaTime;
        if (fireScene > 1&&shoot>0)
        {
            GameObject.Instantiate(bigBolt,transform.position,quaternion.identity);
            fireScene = 0;
        }    
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    void OnShoot(InputValue value)
    {
         shoot = value.Get<float>();
    }
}
