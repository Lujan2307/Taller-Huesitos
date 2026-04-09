using UnityEngine;

public class Contador_Huesos : MonoBehaviour
{
    public static Contador_Huesos instance;

    public int huesos = 0;

    [SerializeField] private UIManager uiManager;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarHuesos()
    {
        huesos++;
        print("huesos: " + huesos);

        // 🔥 ACTUALIZA UI
        uiManager.ActualizarHuesos(huesos);
    }
}