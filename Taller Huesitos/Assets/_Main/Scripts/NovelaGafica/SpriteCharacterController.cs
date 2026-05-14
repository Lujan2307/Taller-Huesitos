using UnityEngine;

public class SpriteCharacterController : MonoBehaviour
{
    [SerializeField]
    private int _mouthSpriteIndex;

    [SerializeField]
    private int _pupilSpriteIndex;

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

    }


}
