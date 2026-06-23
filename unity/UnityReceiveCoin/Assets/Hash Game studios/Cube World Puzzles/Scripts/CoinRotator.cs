using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Inspector 창에서 회전 속도와 방향을 쉽게 조절할 수 있도록 public으로 선언합니다.
    // X, Y, Z 축에 대한 회전 속도를 의미합니다.
    public Vector3 rotationSpeed = new Vector3(0f, 100f, 0f);

    // Update 함수는 게임이 실행되는 동안 매 프레임마다 호출됩니다.
    void Update()
    {
        // transform.Rotate를 사용하여 오브젝트를 회전시킵니다.
        // Time.deltaTime을 곱해주는 것이 핵심입니다! 이를 통해 컴퓨터 성능(프레임)에 상관없이 일정한 속도로 부드럽게 회전합니다.
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}