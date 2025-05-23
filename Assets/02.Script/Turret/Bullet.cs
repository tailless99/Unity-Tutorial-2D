using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    private void Update() {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;

        Destroy(this.gameObject, .5f);
    }
}
