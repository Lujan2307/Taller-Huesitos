using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("❤️ Corazones")]
    [SerializeField] private Image[] corazones;

    [Header("🦴 Texto huesos")]
    [SerializeField] private TMP_Text Text_Score;

    // ❤️ VIDA
    public void ActualizarVida(int vida)
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < vida)
            {
                corazones[i].enabled = true;
            }
            else
            {
                corazones[i].enabled = false;
            }
        }
    }

    // 🦴 HUESOS
    public void ActualizarHuesos(int cantidad)
    {
        if (Text_Score != null)
        {
            Text_Score.text = "Huesos: " + cantidad;
        }
    }
}