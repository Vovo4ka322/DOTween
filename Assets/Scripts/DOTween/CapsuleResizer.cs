using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleResizer : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(-1, _loopType);
    }

}
