using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 제작 : 찬규 
/// 타이틀의 사운드 관련
/// </summary>
public class Sound_Title : MonoBehaviour
{
    private void Start()
    {
        Manager.Sound.PlayBGM("Title");
    }

    private void OnDestroy()
    {
        Manager.Sound.StopBGM();
    }
}
