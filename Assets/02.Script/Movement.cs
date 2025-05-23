using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
    }

    void Update()
    {
        // 부드럽게 증가하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 딱딱 떨어지는 값
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normaldir = dir.normalized; // 정규화
        //Debug.Log($"현재 입력 : {normaldir}");
        
        transform.position += dir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + normaldir); // 바라보는 기능
    }
}
