using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidro : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioData;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        audioData.Play(0);
    }
}
