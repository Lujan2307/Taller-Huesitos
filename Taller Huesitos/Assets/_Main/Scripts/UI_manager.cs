using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Slider barraVida;
    public TMP_Text textoHuesos;

    void Update()
    {
        barraVida.value = Game_Manager.instance.vida;
        textoHuesos.text = "Huesos: " + Game_Manager.instance.huesos;
    }
}
