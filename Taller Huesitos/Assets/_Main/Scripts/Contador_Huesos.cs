using UnityEngine;

public class Contador_Huesos : MonoBehaviour
{

   public static Contador_Huesos instance;
    public int huesos = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SumarHuesos()
    {
        huesos ++;
        print("huesos: " + huesos);;

    }


}