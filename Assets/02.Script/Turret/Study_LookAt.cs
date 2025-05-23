using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos;       // �߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start() // 1�� ���� -> ���𰡸� �����ϴ� ���
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() // �����ΰ��� �ٶ󺸴� ���
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if(timer >= cooldownTime) {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
