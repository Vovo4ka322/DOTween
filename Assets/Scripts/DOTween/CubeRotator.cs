using UnityEngine;
using DG.Tweening;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_endValue, _duration).SetLoops(-1, _loopType);
    }
}
