using UnityEngine;

public class PlanetRotation : MonoBehaviour {
    public Transform targetPlanet;
    public float rotSpeed = 30f; // 자전 속도
    public float RevolutionSpeed = 30f; // 공전 속도
    public bool isRevolutuion = false;

    private void Update() {
        // 자기 자신이 회전하는 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolutuion)
            // 공전하는 기능
            // 목표 위치, 회전 축, 회전 속도 = 목표위치를 기준으로 설정한 회전축으로 회전 속도만큼 회전한다.
            transform.RotateAround(targetPlanet.position, Vector3.up, RevolutionSpeed * Time.deltaTime);
    }
}
