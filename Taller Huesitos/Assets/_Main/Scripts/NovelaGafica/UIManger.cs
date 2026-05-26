using UnityEngine;
using TMPro;

public class UIManger : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelDialogo;

    public TMP_Text _textDialogo;

    [Header("Text Buttons")]
    public TMP_Text[] _textButton;
}