using DevA;
using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj; // ť�� ���� ������Ʈ�� ������ ���� �ʹ�

    //public string changeName;
    public Mesh msh;
    public Material mat;

    private void Start() {
        //obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // CreateCube(); // �Լ� ����, ȣ��
        CreateCube("Cube");
        CreateCube("Cube");
        CreateCube("Hello World");
    }

    public void CreateCube(string name) {
        // Find Name
        //obj = GameObject.Find("Main Camera");
        //obj.name = changeName;

        // Find Tag
        //obj = GameObject.FindGameObjectWithTag("Player");
        //Debug.Log($"�̸� : {obj.name}"); // ���ӿ�����Ʈ�� �̸�
        //Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        //Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        //Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        //Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        // Get Component
        //Debug.Log($"Mesh ������ : { obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Metarial ������ : { obj.GetComponent<MeshRenderer>().material}");

        // Set Active
        //obj.GetComponent<MeshRenderer>().enabled = false;
        //obj.SetActive(false);

        // Create Object
        obj = new GameObject("Cube");
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
        obj.name = name;
        obj.SetActive(false);
    }
}
