using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ti : MonoBehaviour
{
    // Start is called before the first frame update
    static float timedur = 0f;
    public static bool running = false;
    
    void Update()
    {
        if (running)
        {
            timedur += Time.deltaTime;
        }
        if (timedur > 100)
        {
            running = false;
            timedur = 0;
        }
        
    }
}
