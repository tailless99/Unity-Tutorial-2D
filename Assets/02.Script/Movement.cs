using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
    }

    void Update()
    {
        // �ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // ���� �������� ��
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normaldir = dir.normalized; // ����ȭ
        //Debug.Log($"���� �Է� : {normaldir}");
        
        transform.position += dir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + normaldir); // �ٶ󺸴� ���
    }
}
