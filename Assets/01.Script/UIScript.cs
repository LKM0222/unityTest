using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Slider HP;
    // Start is called before the first frame update
    void Start()
    {
        HP.maxValue = 100f;
        HP.value = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
