using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class Accelerometer : MonoBehaviour
{
    float speed = 10f;


    public void Start()
    {
    }

    void Update()
    {

        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);

    }
}
