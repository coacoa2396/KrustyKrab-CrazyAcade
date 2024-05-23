using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static RoundManager;
/// <summary>
/// 제작 : 찬규
/// 게임씬의 게임플로우를 담당
/// </summary>
public class RoundGameFlow : MonoBehaviour
{

    public void SetOutcome()
    {
        if (RoundManager.Round.PlayerList.Exists(item => item.outcome == Outcome.Win)) // 살아남은 플레이어가 없었을 경우, 즉 무승부.
        {
            foreach (PlayerRoundData playerData in RoundManager.Round.PlayerList)
            {
                playerData.outcome = Outcome.draw;
            }
            Debug.Log("Draw");
            return;
        }

        foreach (PlayerRoundData playerData in RoundManager.Round.PlayerList)
        {

            Debug.Log($"{playerData.player.name} is {playerData.outcome}");

        }
    }
}
