using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        // �ڱ� �ڽ��� 3�� �ڿ� �ı��ϴ� ���
        Destroy(this.gameObject, 3f);
    }
}
