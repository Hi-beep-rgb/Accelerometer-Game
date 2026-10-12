using UnityEngine;

public class Magnetometer : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,  -Input.compass.magneticHeading, 0 );
        print(Input.compass.magneticHeading);
    }
}
