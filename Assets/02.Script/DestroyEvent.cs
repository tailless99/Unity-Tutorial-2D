using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        // 자기 자신을 3초 뒤에 파괴하는 기능
        Destroy(this.gameObject, 3f);
    }
}
