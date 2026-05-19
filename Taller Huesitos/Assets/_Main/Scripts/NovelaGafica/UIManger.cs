using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelDialogo;
    [SerializeField]
    private TMP_Text _textDialogo;

    [Header("Text Buttons")]
    [SerializeField]
    private TMP_Text[] _textButton;


    private void Start()
    {
        _textDialogo.text = "Te encontraste con tu crush, que vas a hacer ?.";
        _textButton[0].text = "Golpear";
        _textButton[1].text = "Besar";
        _textButton[2].text = "Correr";
    }
  
}