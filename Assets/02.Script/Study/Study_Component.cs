using DevA;
using UnityEngine;

public class Study_Component : MonoBehaviour
{
    private GameObject obj; // 큐브 게임 오브젝트를 가지고 오고 싶다

    //public string changeName;
    public Mesh msh;
    public Material mat;

    private void Start() {
        //obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // CreateCube(); // 함수 실행, 호출
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
        //Debug.Log($"이름 : {obj.name}"); // 게임오브젝트의 이름
        //Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        //Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        //Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        //Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

        // Get Component
        //Debug.Log($"Mesh 데이터 : { obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Metarial 데이터 : { obj.GetComponent<MeshRenderer>().material}");

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
