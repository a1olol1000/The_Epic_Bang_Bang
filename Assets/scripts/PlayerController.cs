using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.Normalize();
        transform.Translate(movement * shipSpeed * Time.deltaTime);
        
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    void OnShoot(InputValue value)
    {
        if (fireRate > 1)
        {
            GameObject.Instantiate(bigBolt,transform.position,quaternion.identity);
            fireRate = 0;
        }
    }
}
