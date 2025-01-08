using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int cubeHeight = 2;
    public int cubeWidth = 3;
    public Vector3 initialPosition = new Vector3(0, 0, 0);
    private Color cubeColor = Color.yellow;
    public float rotationSpeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(cubeWidth, cubeHeight, 1);
        transform.position = initialPosition;
        GetComponent<Renderer>().material.color = cubeColor;
    
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
