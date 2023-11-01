using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public static GamePanel instance;

    //Change daytime
    public Dropdown ddChange;
    //��ȡ��Դ
    public Light light;

    //btnBag
    public Button btnBag;

    //sliderSound
    public Slider sliderSound;

    //rename
    public Text txtName;
    public Button btnChangeName;

    public Button btn;
    public PlayerObject player;

    //��Ч����
    public Toggle togOn;
    public Toggle togOff;
    public ToggleGroup tg;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        btn.onClick.AddListener(() =>
        {
            player.Fire();
        });

        togOn.onValueChanged.AddListener(TogChangeValue);
        togOff.onValueChanged.AddListener(TogChangeValue);

        //change daytime
        ddChange.onValueChanged.AddListener((index) =>
        {
            switch (index) {
                case 0:
                    light.intensity = 1;
                    break; 
                case 1:
                    light.intensity = 0.2f;
                    break;
            }
        });

        //Bag
        btnBag.onClick.AddListener(() =>
        {
            BagPanel.instance.gameObject.SetActive(true);
        });

        //sliderSound�����������ı���¼�
        //��ʼ����������ֵ
        sliderSound.value = MusicData.SoundValue;
        sliderSound.onValueChanged.AddListener((v) =>
        {
            //������Ч��С
            MusicData.SoundValue = v;
        });

        //rename
        btnChangeName.onClick.AddListener(() =>
        {
            //��ʾ�������
            ChangeNamePanel.instance.gameObject.SetActive(true);
        });
    }


    public void TogChangeValue(bool v)
    {
        foreach (Toggle item in tg.ActiveToggles())
        {
            if (item == togOn)
            {
                MusicData.SoundIsOpen = true;
            }
            if (item == togOff)
            {
                MusicData.SoundIsOpen = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
