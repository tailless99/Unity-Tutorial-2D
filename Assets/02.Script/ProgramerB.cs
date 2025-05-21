using DevA;
using UnityEngine;

public class ProgramerB : MonoBehaviour
{
    public ProgramerA pA;

    private void Start() {
        //pA.number1 = 10;
        //pA.number2 = 20;
        //pA.number3 = 30;
        //pA.number4 = 40;
        //pA.number5 = 50;
        Debug.Log(pA.number2);
    }
}
