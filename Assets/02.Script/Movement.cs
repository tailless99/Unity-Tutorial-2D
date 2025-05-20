using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { // ������ ���� ���
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) { // �������� ���� ���
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) { // ���������� ���� ���
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) { // �ڷ� ���� ���
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
    }
}
