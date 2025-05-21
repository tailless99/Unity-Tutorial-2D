using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj; // 큐브 게임 오브젝트를 가지고 오고 싶다

    public string changeName;

    private void Start() {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
