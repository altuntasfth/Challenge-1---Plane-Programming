using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject propellor;
    public float _speed = 15.0f;
    public float _rotationSpeed = 100f;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        x += 900* Time.deltaTime;
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.Rotate(Vector3.left * verticalInput * _rotationSpeed * Time.deltaTime);
        propellor.transform.rotation = Quaternion.Euler(0, 0, x);
    }
}
