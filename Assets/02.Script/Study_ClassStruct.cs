using UnityEngine;

public class Study_Class {
    public int num;

    public Study_Class(int num) {
        this.num = num;
    }
}

public struct Study_Struct {
    public int num;

    public Study_Struct(int num) {
        this.num = num;
    }
}

public class Study_ClassStruct : MonoBehaviour
{
    private void Start() {
        Debug.Log("클래스~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1 : {c1.num} / c2 : {c2.num}");

        c1.num = 100;
        Debug.Log($"c1 : {c1.num} / c2 : {c2.num}");

        Debug.Log("클래스~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1 : {s1.num} / s2 : {s2.num}");

        s1.num = 100;
        Debug.Log($"s1 : {s1.num} / s2 : {s2.num}");
    }
}
