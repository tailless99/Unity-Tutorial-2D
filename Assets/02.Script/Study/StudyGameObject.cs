using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    private void Awake() {
        CreateAmongus();
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>
    public void CreateAmongus() {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        //Debug.Log($"캐릭터의 자식 오브젝트 수 : {count}");
        //Debug.Log($"첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        //Debug.Log($"마지막 자식 오브젝트의 이름 : {objTf.GetChild(objTf.childCount-1).name}");
    }
}
