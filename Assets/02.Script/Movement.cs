using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { // 앞으로 가는 기능
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) { // 왼쪽으로 가는 기능
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) { // 오른쪽으로 가는 기능
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) { // 뒤로 가는 기능
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
    }
}
