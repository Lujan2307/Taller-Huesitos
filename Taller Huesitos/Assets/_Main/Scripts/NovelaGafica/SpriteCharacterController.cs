using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
    [Header("Array SpriteRenderer")]
    [SerializeField]
    private SpriteRenderer[] _spriteRenderers;
    [SerializeField]
    private int _pupilsSpriteIndex;
    [SerializeField]
    private int _mouthSpriteIndex;
    [SerializeField]
    private int _pupilSpriteIndex;
    [SerializeField]
    private int _eyebrowsSpriteIndex;
    [SerializeField]
    private int _cheekSpriteIndex;
    [SerializeField]
    private int _eyelibsSpriteIndex;
    [SerializeField]
    private int _tearSpriteIndex;
    [SerializeField]
    private int _graphicSpriteIndex;
    [SerializeField]
    private int _whiteSpriteIndex;
    [SerializeField]
    private int _hairSpriteIndex;

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
        _spriteRenderers[2].sprite = _pupilsSprites[_pupilSpriteIndex];
        _spriteRenderers[2].sprite = _mouthSprites[_mouthSpriteIndex];
        _spriteRenderers[2].sprite = _eyebrowsSprites[_eyebrowsSpriteIndex];
        _spriteRenderers[2].sprite = _cheeksSprites[_cheekSpriteIndex];
        _spriteRenderers[2].sprite = _eyelibsSprites[_eyelibsSpriteIndex];
        _spriteRenderers[2].sprite = _tearSprites[_tearSpriteIndex];
        _spriteRenderers[2].sprite = _graphicSprites[_graphicSpriteIndex];
        
    }

}
