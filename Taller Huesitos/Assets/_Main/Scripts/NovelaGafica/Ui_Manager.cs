using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [Header("Nodo de historia")]
    [SerializeField]
    private VisualNovelNodeSO _currentNode;

    [Header("Panel de diálogo")]
    [SerializeField]
    private GameObject _panelDialogo;

    [SerializeField]
    private TMP_Text _textDialogo;

    [Header("Botones")]
    [SerializeField]
    private Button[] _buttons;

    [Header("Textos de los botones")]
    [SerializeField]
    private TMP_Text[] _textButton;

    private void Start()
    {
        _textDialogo.text = _currentNode.sceneText;
    }

}
