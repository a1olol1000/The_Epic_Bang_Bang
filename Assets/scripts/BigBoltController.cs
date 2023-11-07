using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoltController : MonoBehaviour
{
    [SerializeField]
    float speed =15f;
    [SerializeField]
    float timeTilDie = 1f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeTilDie);
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.up*speed*Time.deltaTime;
        transform.Translate(movement);
    }
}
