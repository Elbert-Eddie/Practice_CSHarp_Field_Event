using UnityEngine;

public class chicken : MonoBehaviour
{
    private void Start()
    {
        print("遊戲開始!!!");
    }

    private void Update()
    {
        print("咕咕咕~~~");
    }

    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 200;

    [Header("移動速度"), Range(1, 100)]
    public int move = 10;

    [Header("是否取得雞蛋")]
    public bool egg;

    [Header("說話內容")]
    public string talk = "咕咕咕~~~";
}
