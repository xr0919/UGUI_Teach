using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown dd = GetComponent<Dropdown>();
        print(dd.value);

        print(dd.options[dd.value].text);

        dd.options.Add(new Dropdown.OptionData("123333"));

        //2.´úÂëÌí¼Ó
        dd.onValueChanged.AddListener((v) =>
        {
            print(v);
        });
    }

    //1.ÍÏ½Å±¾
    public void ChangeValue(int value)
    {
        print(value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
