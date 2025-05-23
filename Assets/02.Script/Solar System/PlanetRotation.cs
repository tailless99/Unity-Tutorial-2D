using UnityEngine;

public class PlanetRotation : MonoBehaviour {
    public Transform targetPlanet;
    public float rotSpeed = 30f; // ���� �ӵ�
    public float RevolutionSpeed = 30f; // ���� �ӵ�
    public bool isRevolutuion = false;

    private void Update() {
        // �ڱ� �ڽ��� ȸ���ϴ� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolutuion)
            // �����ϴ� ���
            // ��ǥ ��ġ, ȸ�� ��, ȸ�� �ӵ� = ��ǥ��ġ�� �������� ������ ȸ�������� ȸ�� �ӵ���ŭ ȸ���Ѵ�.
            transform.RotateAround(targetPlanet.position, Vector3.up, RevolutionSpeed * Time.deltaTime);
    }
}
