using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinCollector : MonoBehaviour
{
    // 점수를 관리하는 스크립트가 있다면 여기에 참조를 추가할 수 있습니다.
    // 예: public ScoreManager scoreManager;

    // 코인 수집 시 재생할 사운드가 있다면 추가합니다.
    // public AudioClip collectSound;

    // 다른 콜라이더(예: 플레이어)가 이 코인의 트리거 콜라이더에 들어갔을 때 호출되는 함수입니다.
    private void OnTriggerEnter(Collider other)
    {
        // 부딪힌 오브젝트의 태그가 "Player"인지 확인합니다.
        if (other.CompareTag("Player"))
        {
                // --- 수집 이벤트 로직 시작 ---

                // 예시: 점수를 추가합니다.
                // if (scoreManager != null) scoreManager.AddScore(10);

                // 예시: 코인 수집 사운드를 재생합니다.
                // AudioSource.PlayClipAtPoint(collectSound, transform.position);

                // 예시: 코인 수집 파티클 효과를 생성합니다.
                // Instantiate(collectEffect, transform.position, Quaternion.identity);

                // --- 수집 이벤트 로직 끝 ---

                // 코인을 파괴합니다. (화면에서 사라짐)
                Destroy(gameObject);

        }
    }
}