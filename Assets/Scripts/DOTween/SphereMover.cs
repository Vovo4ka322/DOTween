using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Vector3 _vector3;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_vector3, _duration).SetLoops(-1, _loopType);
    }
}
