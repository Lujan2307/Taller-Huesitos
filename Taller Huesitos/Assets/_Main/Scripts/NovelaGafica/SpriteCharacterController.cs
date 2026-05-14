using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
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


    [Header("Array SpriteRender")]
    [SerializeField]
    private SpriteRenderer[] _spriteRenderers;

    [Header("Sprite")]
    [SerializeField]
    private Sprite _tearSprite;
    [SerializeField]
    private Sprite _hairSprite;
    [SerializeField]
    private Sprite _whiteSprites;

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
    private Sprite[] _pupilSprites;
    [SerializeField]
    private Sprite[] _eyebrowsSprites;
    [SerializeField]
    private Sprite[] _cheekSprites;

    private void Start()
    {



    }
    private void Update()
    {
        _spriteRenderers[6].sprite = _pupilSprites[_pupilSpriteIndex];
        _spriteRenderers[3].sprite = _mouthSprites[_mouthSpriteIndex];
        _spriteRenderers[8].sprite = _eyebrowsSprites[_eyebrowsSpriteIndex];
        _spriteRenderers[9].sprite = _cheekSprites[_cheekSpriteIndex];
        _spriteRenderers[5].sprite = _eyelibsSprites[_eyelibsSpriteIndex];
        _spriteRenderers[2].sprite = _tearSprites[_tearSpriteIndex];
        _spriteRenderers[4].sprite = _graphicSprites[_graphicSpriteIndex];
    }


}
