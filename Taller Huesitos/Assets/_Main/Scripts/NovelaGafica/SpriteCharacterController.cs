using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
    [Header("Array SpriteRenderer")]
    [SerializeField]
    private SpriteRenderer[] _spriteRenderers;
    [SerializeField]
    private int _pupilsSpriteIndex;

    [Header("Sprite")]
    [SerializeField]
    private Sprite _mainSprite;
    [SerializeField]
    private Sprite _hairSprite;
    [SerializeField]
    private Sprite _whiteSprite;

    [Header("Array Sprite")]
    [SerializeField]
    private Sprite[] _tearSprites;
    [SerializeField]
    private Sprite[] _mouthSprites;
    [SerializeField]
    private Sprite[] _graphicSprites;
    [SerializeField]
    private Sprite[] _eyelibsSprites;
    [SerializeField]
    private Sprite[] _pupilsSprites;
    [SerializeField]
    private Sprite[] _eyebrowsSprites;
    [SerializeField]
    private Sprite[] _cheeksSprites;

    private void Update()
    {
        _spriteRenderers[6].sprite = _pupilsSprites[_pupilsSpriteIndex];
    }

}
