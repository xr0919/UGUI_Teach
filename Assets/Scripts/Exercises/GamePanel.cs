using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public Button btn;
    public PlayerObject player;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            player.Fire();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
