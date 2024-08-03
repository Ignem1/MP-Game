using Agora.Rtc;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AgoraUnityVideo : MonoBehaviour
{
    private IRtcEngine RtcEngine = null;
    private string appID = "9f9c3aa340e64a3fa67524d5bcf6d223";
    [SerializeField] private PhotonView photonView;
    private void Start()
    {
        if (!photonView.IsMine)
        {
            return;
        }

        RtcEngine = Agora.Rtc.RtcEngine.CreateAgoraRtcEngine();
        RtcEngineContext context = new RtcEngineContext();
        context.appId = appID;

    }
}
