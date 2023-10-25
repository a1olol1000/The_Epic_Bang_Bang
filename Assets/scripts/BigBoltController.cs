using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoltController : MonoBehaviour
{
    [SerializeField]
    float speed =15f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.up*speed*Time.deltaTime;
        transform.Translate(movement);
    }
}
