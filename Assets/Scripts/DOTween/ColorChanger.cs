using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration).SetLoops(-1, _loopType);
    }
}
