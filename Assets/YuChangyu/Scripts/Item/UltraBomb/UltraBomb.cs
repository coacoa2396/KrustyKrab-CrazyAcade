using pakjungmin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 제작 : 찬규 
/// 아이템 UltraBomb
/// </summary>
public class UltraBomb : PassiveBase
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);                       // 레이어마스크 체크

        Player = collision.gameObject.GetComponent<PlayerMediator>();

        if (Player.characterStats.MaxPower == Player.playerStats.Power)   // 스크립터블오브젝트에서 설정된 물풍선 최대갯수랑 현재 플레이어의 물풍선 갯수가 같으면
            return;                                                     // 리턴

        Player.playerStats.Power = Player.characterStats.MaxPower;

        Destroy(gameObject);
    }
}