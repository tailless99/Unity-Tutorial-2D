using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj; // ť�� ���� ������Ʈ�� ������ ���� �ʹ�

    public string changeName;

    private void Start() {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
