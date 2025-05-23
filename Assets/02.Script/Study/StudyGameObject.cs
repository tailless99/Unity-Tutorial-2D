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
    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>
    public void CreateAmongus() {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        //Debug.Log($"ĳ������ �ڽ� ������Ʈ �� : {count}");
        //Debug.Log($"ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
        //Debug.Log($"������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(objTf.childCount-1).name}");
    }
}
