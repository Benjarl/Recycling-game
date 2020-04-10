using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestGameFrame
{

    public class TrashTask : TaskBase
    {
        public MainScnRes MainScneRes { get; set; }

        public GameObject Trash1 { get; set; }
        public GameObject Trash2 { get; set; }
        public GameObject Trash3 { get; set; }
        public GameObject Trash4 { get; set; }
        public GameObject Trash5 { get; set; }
        public GameObject Trash6 { get; set; }
        public GameObject Trash7 { get; set; }
        public GameObject Trash8 { get; set; }
        public GameObject Trash9 { get; set; }
        public GameObject Trash10 { get; set; }
        public GameObject Trash11 { get; set; }
        public GameObject Trash12 { get; set; }
        public GameObject Trash13 { get; set; }
        public GameObject Trash14 { get; set; }
        public GameObject Trash15 { get; set; }
        public GameObject Trash16 { get; set; }
        public GameObject Trash17 { get; set; }
        public GameObject Trash18 { get; set; }
        public GameObject Trash19 { get; set; }
        public GameObject Trash20 { get; set; }
        public GameObject Trash21 { get; set; }
        public GameObject Trash22 { get; set; }
        public GameObject Trash23 { get; set; }
        public GameObject Trash24 { get; set; }
        public GameObject Trash25 { get; set; }
        public GameObject Trash26 { get; set; }
        public GameObject Trash27 { get; set; }
        public GameObject Trash28 { get; set; }
        public GameObject Trash29 { get; set; }
        public GameObject Trash30 { get; set; }
        public GameObject Trash31 { get; set; }
        public GameObject Trash32 { get; set; }
        public GameObject Trash33 { get; set; }
        public GameObject Trash34 { get; set; }
        public GameObject Trash35 { get; set; }
        public GameObject Trash36 { get; set; }
        public GameObject Trash37 { get; set; }
        public GameObject Trash38 { get; set; }
        public GameObject Trash39 { get; set; }
        public GameObject Trash40 { get; set; }
        public GameObject Trash41 { get; set; }
        public GameObject Trash42 { get; set; }
        public GameObject Trash43 { get; set; }
        public GameObject Trash44 { get; set; }
        public GameObject Trash45 { get; set; }
        public GameObject Trash46 { get; set; }
        public GameObject Trash47 { get; set; }
        public GameObject Trash48 { get; set; }
        public GameObject Trash49 { get; set; }
        public GameObject Trash50 { get; set; }
        public GameObject Trash51 { get; set; }
        public GameObject Trash52 { get; set; }
        public GameObject Trash53 { get; set; }
        public GameObject Trash54 { get; set; }
        public GameObject Trash55 { get; set; }
        public GameObject Trash56 { get; set; }
        public GameObject Trash57 { get; set; }
        public GameObject Trash58 { get; set; }
        public GameObject Trash59 { get; set; }
        public GameObject Trash60 { get; set; }
        public GameObject Trash61 { get; set; }
        public GameObject Trash62 { get; set; }
        public GameObject Trash63 { get; set; }
        public GameObject Trash64 { get; set; }
        public GameObject Trash65 { get; set; }
        public GameObject Trash66 { get; set; }
        public GameObject Trash67 { get; set; }
        public GameObject Trash68 { get; set; }
        public GameObject Trash69 { get; set; }
        public GameObject Trash70 { get; set; }
        public GameObject Trash71 { get; set; }
        public GameObject Trash72 { get; set; }
        public GameObject Trash73 { get; set; }
        public GameObject Trash74 { get; set; }
        public GameObject Trash75 { get; set; }
        public GameObject Trash76 { get; set; }
        public GameObject Trash77 { get; set; }
        public GameObject Trash78 { get; set; }
        public GameObject Trash79 { get; set; }
        public GameObject Trash80 { get; set; }
        public GameObject Trash81 { get; set; }
        public GameObject Trash82 { get; set; }
        public GameObject Trash83 { get; set; }
        public GameObject Trash84 { get; set; }
        public GameObject Trash85 { get; set; }

        public override IEnumerator TaskInit()
        {
            MainScneRes = GameEntityManager.Instance.GetCurrentSceneRes<MainScnRes>();
            yield return null;
        }

        public override IEnumerator TaskStart()
        {
            Trash1 = GameObject.Instantiate(MainScneRes.Trash1.gameObject);
            Trash2 = GameObject.Instantiate(MainScneRes.Trash2.gameObject);
            Trash3 = GameObject.Instantiate(MainScneRes.Trash3.gameObject);
            Trash4 = GameObject.Instantiate(MainScneRes.Trash4.gameObject);
            Trash5 = GameObject.Instantiate(MainScneRes.Trash5.gameObject);
            Trash6 = GameObject.Instantiate(MainScneRes.Trash6.gameObject);
            Trash7 = GameObject.Instantiate(MainScneRes.Trash7.gameObject);
            Trash8 = GameObject.Instantiate(MainScneRes.Trash8.gameObject);
            Trash9 = GameObject.Instantiate(MainScneRes.Trash9.gameObject);
            Trash10 = GameObject.Instantiate(MainScneRes.Trash10.gameObject);
            Trash11 = GameObject.Instantiate(MainScneRes.Trash11.gameObject);
            Trash12 = GameObject.Instantiate(MainScneRes.Trash12.gameObject);
            Trash13 = GameObject.Instantiate(MainScneRes.Trash13.gameObject);
            Trash14 = GameObject.Instantiate(MainScneRes.Trash14.gameObject);
            Trash15 = GameObject.Instantiate(MainScneRes.Trash15.gameObject);
            Trash16 = GameObject.Instantiate(MainScneRes.Trash16.gameObject);
            Trash17 = GameObject.Instantiate(MainScneRes.Trash17.gameObject);
            Trash18 = GameObject.Instantiate(MainScneRes.Trash18.gameObject);
            Trash19 = GameObject.Instantiate(MainScneRes.Trash19.gameObject);
            Trash20 = GameObject.Instantiate(MainScneRes.Trash20.gameObject);
            Trash21 = GameObject.Instantiate(MainScneRes.Trash21.gameObject);
            Trash22 = GameObject.Instantiate(MainScneRes.Trash22.gameObject);
            Trash23 = GameObject.Instantiate(MainScneRes.Trash23.gameObject);
            Trash24 = GameObject.Instantiate(MainScneRes.Trash24.gameObject);
            Trash25 = GameObject.Instantiate(MainScneRes.Trash25.gameObject);
            Trash26 = GameObject.Instantiate(MainScneRes.Trash26.gameObject);
            Trash27 = GameObject.Instantiate(MainScneRes.Trash27.gameObject);
            Trash28 = GameObject.Instantiate(MainScneRes.Trash28.gameObject);
            Trash29 = GameObject.Instantiate(MainScneRes.Trash29.gameObject);
            Trash30 = GameObject.Instantiate(MainScneRes.Trash30.gameObject);
            Trash31 = GameObject.Instantiate(MainScneRes.Trash31.gameObject);
            Trash32 = GameObject.Instantiate(MainScneRes.Trash32.gameObject);
            Trash33 = GameObject.Instantiate(MainScneRes.Trash33.gameObject);
            Trash34 = GameObject.Instantiate(MainScneRes.Trash34.gameObject);
            Trash35 = GameObject.Instantiate(MainScneRes.Trash35.gameObject);
            Trash36 = GameObject.Instantiate(MainScneRes.Trash36.gameObject);
            Trash37 = GameObject.Instantiate(MainScneRes.Trash37.gameObject);
            Trash38 = GameObject.Instantiate(MainScneRes.Trash38.gameObject);
            Trash39 = GameObject.Instantiate(MainScneRes.Trash39.gameObject);
            Trash40 = GameObject.Instantiate(MainScneRes.Trash40.gameObject);
            Trash41 = GameObject.Instantiate(MainScneRes.Trash41.gameObject);
            Trash42 = GameObject.Instantiate(MainScneRes.Trash42.gameObject);
            Trash43 = GameObject.Instantiate(MainScneRes.Trash43.gameObject);
            Trash44 = GameObject.Instantiate(MainScneRes.Trash44.gameObject);
            Trash45 = GameObject.Instantiate(MainScneRes.Trash45.gameObject);
            Trash46 = GameObject.Instantiate(MainScneRes.Trash46.gameObject);
            Trash47 = GameObject.Instantiate(MainScneRes.Trash47.gameObject);
            Trash48 = GameObject.Instantiate(MainScneRes.Trash48.gameObject);
            Trash49 = GameObject.Instantiate(MainScneRes.Trash49.gameObject);
            Trash50 = GameObject.Instantiate(MainScneRes.Trash50.gameObject);
            Trash51 = GameObject.Instantiate(MainScneRes.Trash51.gameObject);
            Trash52 = GameObject.Instantiate(MainScneRes.Trash52.gameObject);
            Trash53 = GameObject.Instantiate(MainScneRes.Trash53.gameObject);
            Trash54 = GameObject.Instantiate(MainScneRes.Trash54.gameObject);
            Trash55 = GameObject.Instantiate(MainScneRes.Trash55.gameObject);
            Trash56 = GameObject.Instantiate(MainScneRes.Trash56.gameObject);
            Trash57 = GameObject.Instantiate(MainScneRes.Trash57.gameObject);
            Trash58 = GameObject.Instantiate(MainScneRes.Trash58.gameObject);
            Trash59 = GameObject.Instantiate(MainScneRes.Trash59.gameObject);
            Trash60 = GameObject.Instantiate(MainScneRes.Trash60.gameObject);
            Trash61 = GameObject.Instantiate(MainScneRes.Trash61.gameObject);
            Trash62 = GameObject.Instantiate(MainScneRes.Trash62.gameObject);
            Trash63 = GameObject.Instantiate(MainScneRes.Trash63.gameObject);
            Trash64 = GameObject.Instantiate(MainScneRes.Trash64.gameObject);
            Trash65 = GameObject.Instantiate(MainScneRes.Trash65.gameObject);
            Trash66 = GameObject.Instantiate(MainScneRes.Trash66.gameObject);
            Trash67 = GameObject.Instantiate(MainScneRes.Trash67.gameObject);
            Trash68 = GameObject.Instantiate(MainScneRes.Trash68.gameObject);
            Trash69 = GameObject.Instantiate(MainScneRes.Trash69.gameObject);
            Trash70 = GameObject.Instantiate(MainScneRes.Trash70.gameObject);
            Trash71 = GameObject.Instantiate(MainScneRes.Trash71.gameObject);
            Trash72 = GameObject.Instantiate(MainScneRes.Trash72.gameObject);
            Trash73 = GameObject.Instantiate(MainScneRes.Trash73.gameObject);
            Trash74 = GameObject.Instantiate(MainScneRes.Trash74.gameObject);
            Trash75 = GameObject.Instantiate(MainScneRes.Trash75.gameObject);
            Trash76 = GameObject.Instantiate(MainScneRes.Trash76.gameObject);
            Trash77 = GameObject.Instantiate(MainScneRes.Trash77.gameObject);
            Trash78 = GameObject.Instantiate(MainScneRes.Trash78.gameObject);
            Trash79 = GameObject.Instantiate(MainScneRes.Trash79.gameObject);
            Trash80 = GameObject.Instantiate(MainScneRes.Trash80.gameObject);
            Trash81 = GameObject.Instantiate(MainScneRes.Trash81.gameObject);
            Trash82 = GameObject.Instantiate(MainScneRes.Trash82.gameObject);
            Trash83 = GameObject.Instantiate(MainScneRes.Trash83.gameObject);
            Trash84 = GameObject.Instantiate(MainScneRes.Trash84.gameObject);
            Trash85 = GameObject.Instantiate(MainScneRes.Trash85.gameObject);

            yield return null;
        }

        public override IEnumerator TaskStop()
        {
            yield return null;
        }
    }
}
