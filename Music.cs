using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Music : MonoBehaviour {

    void LateUpdate()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        DontDestroyOnLoad(gameObject);
        
        if (objs.Length > 1)
            Destroy(objs[1]);
        
    }
}
