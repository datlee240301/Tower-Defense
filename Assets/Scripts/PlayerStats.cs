using UnityEngine; 

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;
    public static int Lives;
    public static int StartLives = 1;

    private void Start() {
        Money = startMoney;
        Lives = StartLives;
    }
}
