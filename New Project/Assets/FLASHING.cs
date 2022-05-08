using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLASHING : MonoBehaviour
{
    public Light Lightens;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Lightens.intensity = Mathf.Lerp(0f, 10f, 0.1f);
   
    }
}
