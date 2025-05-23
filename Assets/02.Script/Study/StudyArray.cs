using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour {
    // Collection 예제
    [SerializeField] int[] arrayNumber = { 11, 22, 33, 44, 55 };
    [SerializeField] List<int> listNumber = new List<int>();

    // [SerializeField] 예제
    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;
    [SerializeField] private int number4 = 4;
    [SerializeField] int number5 = 5;

    void Start() {
        /*
        Debug.Log($"Array의 1 번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 2 번째 값 : {arrayNumber[1]}");
        Debug.Log($"Array의 3 번째 값 : {arrayNumber[2]}");
        Debug.Log($"Array의 4 번째 값 : {arrayNumber[3]}");
        Debug.Log($"Array의 5 번째 값 : {arrayNumber[4]}");
        */

        /*
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);
        Debug.Log($"현재 List의 길이 : {listNumber.Count}");
        */
    }
}
