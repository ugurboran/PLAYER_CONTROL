using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Vector3 pos;
    float x_value = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        x_value = Mathf.Lerp(x_value, 10, Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
