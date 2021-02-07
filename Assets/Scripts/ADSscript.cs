using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ADSscript : MonoBehaviour
{  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.localPosition = new Vector3(0f, -0.28f, 1.58f);
        }
        else
        {
            transform.localPosition = new Vector3(0.74f, -0.47f, 1.367f);
        }
    }
}
