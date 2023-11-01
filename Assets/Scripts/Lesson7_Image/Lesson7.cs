using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image img = this.GetComponent<Image>();
        img.sprite = Resources.Load<Sprite>("ui_TY_fanhui_01");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
