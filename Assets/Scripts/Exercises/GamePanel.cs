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

    //LongPress关联长安功能按钮
    public LongPress longPress;
    //进度条组件 控制显示隐藏
    public GameObject imgRoot;
    public RectTransform imgBK;

    //Change daytime
    public Dropdown ddChange;
    //获取光源
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

    //音效开关
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

        //为JoyCon注册事件
        //拖动中
        EventTrigger.Entry en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(JoyDrag);
        et.triggers.Add(en);
        //拖动结束
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(EndJoyDrag);
        et.triggers.Add(en);

        //LongPress 用gamepanel去管理而不是组件
        longPress.downEvent += BtnDown;
        longPress.upEvent += BtnUp;
        imgRoot.SetActive(false);//隐藏蓄能条

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

        //sliderSound监听滑动条改变的事件
        //初始化滑动条的值
        sliderSound.value = MusicData.SoundValue;
        sliderSound.onValueChanged.AddListener((v) =>
        {
            //处理音效大小
            MusicData.SoundValue = v;
        });

        //rename
        btnChangeName.onClick.AddListener(() =>
        {
            //显示改名面板
            ChangeNamePanel.instance.gameObject.SetActive(true);
        });
    }

    //joyCon
    private void JoyDrag(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        //旧方法:加偏移量
        //imgJoy.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);
        //imgJoy.transform.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);

        //新方法 RectTransformUtility 更准确
        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imgJoy.parent as RectTransform,
            eventData.position,
            eventData.enterEventCamera,
            out nowPos
            );
        imgJoy.position = nowPos;

        //有专门参数获得相对锚点的点
        if (imgJoy.anchoredPosition.magnitude > 150)//如果出界
        {
            //Joy自动拉回来
            //获取向量长度
            //单位向量 * 长度 = 临界位置
            imgJoy.anchoredPosition = imgJoy.anchoredPosition.normalized * 150;
        }
        //move
        player.Move(imgJoy.anchoredPosition);
    }
    private void EndJoyDrag(BaseEventData data)
    {
        //回归中心点
        imgJoy.anchoredPosition = Vector2.zero;
        //停止移动
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
    private bool isDown = false;//是否按下
    private float nowTime = 0;//计时器
    public float addSpeed = 500;//增加速度
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
            //计时器
            nowTime += Time.deltaTime;
            if(nowTime >= 0.2f)
            {
                imgRoot.SetActive(true);
                //蓄能条增加
                imgBK.sizeDelta += new Vector2(addSpeed * Time.deltaTime,0);
                if(imgBK.sizeDelta.x >= 800)
                {
                    //hp条增加 条清空
                    hp += 10;
                    imgBK.sizeDelta = new Vector2(0, 50);
                    print("hp: " + hp);
                }

            }
        }
    }
}
