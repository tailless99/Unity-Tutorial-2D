using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour {
    // Collection ����
    [SerializeField] int[] arrayNumber = { 11, 22, 33, 44, 55 };
    [SerializeField] List<int> listNumber = new List<int>();

    // [SerializeField] ����
    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;
    [SerializeField] private int number4 = 4;
    [SerializeField] int number5 = 5;

    void Start() {
        /*
        Debug.Log($"Array�� 1 ��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� 2 ��° �� : {arrayNumber[1]}");
        Debug.Log($"Array�� 3 ��° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� 4 ��° �� : {arrayNumber[3]}");
        Debug.Log($"Array�� 5 ��° �� : {arrayNumber[4]}");
        */

        /*
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);
        Debug.Log($"���� List�� ���� : {listNumber.Count}");
        */
    }
}
