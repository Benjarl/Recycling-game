using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TestGameFrame
{
    public class recyclelisttext : MonoBehaviour
    {
        public static Text recyclething;
        public Text recycledaytext;
        public Image Day;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void recycleday(int day)
        {
            //recyclething = GameObject.Find("RecycleThingText").GetComponent<Text>();
            //recycledaytext = GameObject.Find("DayText").GetComponent<Text>();
            Day = GameObject.Find("DayImage").GetComponent<Image>();
            switch (day)
            {
                case 1:
                    recycledaytext.text = "星期一";
                    Day.color = new Color32(0, 255, 0, 225);
                    break;
                case 2:
                    recycledaytext.text = "星期二";
                    Day.color = new Color32(0, 0, 255, 225);
                    break;
                case 3:
                    recycledaytext.text = "星期三";
                    Day.color = new Color32(255, 0, 0, 225);
                    break;
                case 4:
                    recycledaytext.text = "星期四";
                    Day.color = new Color32(0, 0, 255, 225);
                    break;
                case 5:
                    recycledaytext.text = "星期五";
                    Day.color = new Color32(0, 255, 0, 225);
                    break;
                case 6:
                    recycledaytext.text = "星期六";
                    Day.color = new Color32(0, 0, 255, 225);
                    break;
                case 7:
                    recycledaytext.text = "星期天";
                    Day.color = new Color32(255, 0, 0, 225);
                    break;
            }
            if (GameDataManager.TaskData.Mode > 1)
            {
                Day.color = new Color32(255, 0, 0, 0);
            }
        }

        public void recycletext(int number)
        {
            recyclething = GameObject.Find("RecycleThingText").GetComponent<Text>();
            recycledaytext = GameObject.Find("DayText").GetComponent<Text>();
            switch (number)
            {
                case 1:
                    recyclething.text = "報紙";
                    break;
                case 2:
                    recyclething.text = "紙箱";
                    break;
                case 3:
                    recyclething.text = "電腦報表紙";
                    break;
                case 4:
                    recyclething.text = "電話簿";
                    break;
                case 5:
                    recyclething.text = "牛皮紙袋";
                    break;
                case 6:
                    recyclething.text = "雜誌";
                    break;
                case 7:
                    recyclething.text = "書籍";
                    break;
                case 8:
                    recyclething.text = "考卷";
                    break;
                case 9:
                    recyclething.text = "瓦楞紙";
                    break;
                case 10:
                    recyclething.text = "紙盒包";
                    break;
                case 11:
                    recyclething.text = "鋁箔包";
                    break;
                case 12:
                    recyclething.text = "紙餐具";
                    break;
                case 13:
                    recyclething.text = "寶特瓶";
                    break;
                case 14:
                    recyclething.text = "塑膠牛奶瓶";
                    break;
                case 15:
                    recyclething.text = "塑膠桌椅";
                    break;
                case 16:
                    recyclething.text = "保鮮盒";
                    break;
                case 17:
                    recyclething.text = "塑膠臉盆";
                    break;
                case 18:
                    recyclething.text = "塑膠管";
                    break;
                case 19:
                    recyclething.text = "壓克力";
                    break;
                case 20:
                    recyclething.text = "錄影帶";
                    break;
                case 21:
                    recyclething.text = "酒瓶";
                    break;
                case 22:
                    recyclething.text = "牛乳瓶";
                    break;
                case 23:
                    recyclething.text = "化妝品瓶";
                    break;
                case 24:
                    recyclething.text = "清潔劑瓶";
                    break;
                case 25:
                    recyclething.text = "玻璃杯";
                    break;
                case 26:
                    recyclething.text = "玻璃碗";
                    break;
                case 27:
                    recyclething.text = "玻璃盤";
                    break;
                case 28:
                    recyclething.text = "點滴瓶";
                    break;
                case 29:
                    recyclething.text = "鐵罐";
                    break;
                case 30:
                    recyclething.text = "鋁罐";
                    break;
                case 31:
                    recyclething.text = "鳳梨罐頭";
                    break;
                case 32:
                    recyclething.text = "靖魚罐頭";
                    break;
                case 33:
                    recyclething.text = "肉鬆罐頭";
                    break;
                case 34:
                    recyclething.text = "鹼性電池";
                    break;
                case 35:
                    recyclething.text = "鋰電池";
                    break;
                case 36:
                    recyclething.text = "鎳氫電池";
                    break;
                case 37:
                    recyclething.text = "鎳鎘電池";
                    break;
                case 38:
                    recyclething.text = "水銀電池";
                    break;
                case 39:
                    recyclething.text = "手機電池";
                    break;
                case 40:
                    recyclething.text = "行動電源";
                    break;
                case 41:
                    recyclething.text = "充電電池";
                    break;
                case 42:
                    recyclething.text = "一般保麗龍";
                    break;
                case 43:
                    recyclething.text = "工業用保麗龍";
                    break;
                case 44:
                    recyclething.text = "電視機";
                    break;
                case 45:
                    recyclething.text = "電冰箱";
                    break;
                case 46:
                    recyclething.text = "洗衣機";
                    break;
                case 47:
                    recyclething.text = "冷氣機";
                    break;
                case 48:
                    recyclething.text = "手機";
                    break;
                case 49:
                    recyclething.text = "電磁爐";
                    break;
                case 50:
                    recyclething.text = "除濕機";
                    break;
                case 51:
                    recyclething.text = "電話";
                    break;
                case 52:
                    recyclething.text = "相機";
                    break;
                case 53:
                    recyclething.text = "鬧鐘";
                    break;
                case 54:
                    recyclething.text = "計算機";
                    break;
                case 55:
                    recyclething.text = "直管日光燈";
                    break;
                case 56:
                    recyclething.text = "環管日光燈";
                    break;
                case 57:
                    recyclething.text = "白熾燈泡";
                    break;
                case 58:
                    recyclething.text = "冷陰極燈";
                    break;
                case 59:
                    recyclething.text = "含汞燈";
                    break;
                case 60:
                    recyclething.text = "複寫紙";
                    break;
                case 61:
                    recyclething.text = "護貝紙";
                    break;
                case 62:
                    recyclething.text = "衛生紙";
                    break;
                case 63:
                    recyclething.text = "紙尿布";
                    break;
                case 64:
                    recyclething.text = "磁碟片";
                    break;
                case 65:
                    recyclething.text = "保鮮膜";
                    break;
                case 66:
                    recyclething.text = "塑膠繩";
                    break;
                case 67:
                    recyclething.text = "塑膠布";
                    break;
                case 68:
                    recyclething.text = "膠帶";
                    break;
                case 69:
                    recyclething.text = "樹脂";
                    break;
                case 70:
                    recyclething.text = "泡棉";
                    break;
                case 71:
                    recyclething.text = "塑膠地板";
                    break;
                case 72:
                    recyclething.text = "雨衣";
                    break;
                case 73:
                    recyclething.text = "橡膠";
                    break;
                case 74:
                    recyclething.text = "平面玻璃";
                    break;
                case 75:
                    recyclething.text = "安全玻璃";
                    break;
                case 76:
                    recyclething.text = "鏡子";
                    break;
                case 77:
                    recyclething.text = "魚缸";
                    break;
                case 78:
                    recyclething.text = "玻璃窗";
                    break;
                case 79:
                    recyclething.text = "陶瓷";
                    break;
                case 80:
                    recyclething.text = "毛巾";
                    break;
                case 81:
                    recyclething.text = "襪子";
                    break;
                case 82:
                    recyclething.text = "窗簾";
                    break;
                case 83:
                    recyclething.text = "棉被";
                    break;
                case 84:
                    recyclething.text = "有油汙的保麗龍";
                    break;
                case 85:
                    recyclething.text = "木製音箱";
                    break;
            }
            GameEventCenter.DispatchEvent("timecosttext");
            if (GameDataManager.TaskData.Mode < 2)
            {
                recyclething.text = '.' + recyclething.text;
                recyclething.text = number + recyclething.text;
            }
        }
    }
}
