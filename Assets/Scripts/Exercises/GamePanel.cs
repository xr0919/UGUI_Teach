using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public static GamePanel instance;

    //JoyCon
    public RectTransform imgJoy;
    public EventTrigger et;

    //LongPress�����������ܰ�ť
    public LongPress longPress;
    //��������� ������ʾ����
    public GameObject imgRoot;
    public RectTransform imgBK;

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

        //ΪJoyConע���¼�
        //�϶���
        EventTrigger.Entry en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(JoyDrag);
        et.triggers.Add(en);
        //�϶�����
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(EndJoyDrag);
        et.triggers.Add(en);

        //LongPress ��gamepanelȥ������������
        longPress.downEvent += BtnDown;
        longPress.upEvent += BtnUp;
        imgRoot.SetActive(false);//����������

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

    //joyCon
    private void JoyDrag(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        //�ɷ���:��ƫ����
        //imgJoy.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);
        //imgJoy.transform.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);

        //�·��� RectTransformUtility ��׼ȷ
        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imgJoy.parent as RectTransform,
            eventData.position,
            eventData.enterEventCamera,
            out nowPos
            );
        imgJoy.position = nowPos;

        //��ר�Ų���������ê��ĵ�
        if (imgJoy.anchoredPosition.magnitude > 150)//�������
        {
            //Joy�Զ�������
            //��ȡ��������
            //��λ���� * ���� = �ٽ�λ��
            imgJoy.anchoredPosition = imgJoy.anchoredPosition.normalized * 150;
        }
        //move
        player.Move(imgJoy.anchoredPosition);
    }
    private void EndJoyDrag(BaseEventData data)
    {
        //�ع����ĵ�
        imgJoy.anchoredPosition = Vector2.zero;
        //ֹͣ�ƶ�
        player.Move(Vector2.zero);
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

    //LongPress
    private bool isDown = false;//�Ƿ���
    private float nowTime = 0;//��ʱ��
    public float addSpeed = 500;//�����ٶ�
    private int hp = 10;
    private void BtnDown()
    {
        isDown = true;
        nowTime = 0;

        imgBK.sizeDelta = new Vector2(0, 50);
    }
    private void BtnUp()
    {
        isDown = false;
        imgRoot.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            //��ʱ��
            nowTime += Time.deltaTime;
            if(nowTime >= 0.2f)
            {
                imgRoot.SetActive(true);
                //����������
                imgBK.sizeDelta += new Vector2(addSpeed * Time.deltaTime,0);
                if(imgBK.sizeDelta.x >= 800)
                {
                    //hp������ �����
                    hp += 10;
                    imgBK.sizeDelta = new Vector2(0, 50);
                    print("hp: " + hp);
                }

            }
        }
    }
}
