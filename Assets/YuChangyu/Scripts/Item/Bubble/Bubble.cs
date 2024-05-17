using pakjungmin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 제작 : 찬규 
/// 아이템 : 물풍선 
/// 플레이어가 한번에 놓을 수 있는 물풍선의 갯수가 1 증가한다
/// </summary>
public class Bubble : Item, IAcquirable
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CheckWater(collision.gameObject))
        {
            if (WaterProof <= 0)
            {
                Destroy(gameObject);
                return;
            }
            WaterProof--;
        }

        if (!CheckPlayer(collision.gameObject))
            return;

        Player = collision.gameObject.GetComponent<PlayerMediator>();

        Player.playerStats.OwnBomb++; // 박정민 추가 : Bomb에서 OwnBomb으로 명칭 변경.
        Player.playerInventory.Inven.Add(ItemManager.ItemData.itemDir["Bubble"]);
        gameObject.SetActive(false);
    }
}
