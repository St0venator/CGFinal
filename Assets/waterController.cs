using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.localScale;

        temp.y = (Mathf.Sin(Time.time) * 25) + 26;

        transform.localScale = temp;

        transform.Rotate(0, Time.deltaTime, 0);
    }
}
