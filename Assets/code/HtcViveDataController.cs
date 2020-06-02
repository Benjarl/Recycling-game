using LabData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HtcViveDataController : MonoBehaviour
{
    public Transform Head, LeftHand, RightHand;



    private void Update()
    {
        var data= new Mindfrog.HtcViveData() {

            HeadPosition = Head.position.ToPos(),
            HeadRotation = Head.rotation.ToQuaternionPos(),
            LeftHandPosition=LeftHand.position.ToPos(),
            LeftHandRotation=LeftHand.rotation.ToQuaternionPos(),
            RightHandPosition=RightHand.position.ToPos(),
            RightHandRotation=RightHand.rotation.ToQuaternionPos()

        };

        GameDataManager.LabDataManager.SendData(data);
    }
}
