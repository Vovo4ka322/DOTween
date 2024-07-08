using UnityEngine;

public class CapsResizing : MonoBehaviour
{
    [SerializeField] private float _speedResizing;
    [SerializeField] private Vector3 _scaleIncrease;
    [SerializeField] private Vector3 _scaleDecrease;

    private bool _enabled;

    private const float Epsilon = 0.1f;

    private void Update()
    {
        var resizing = transform.localScale;

        if (_enabled)
        {
            if (Vector3.Distance(_scaleIncrease, transform.localScale) >= Epsilon)
            {
                resizing += _speedResizing * Vector3.one;
            }
            else
            {
                _enabled = false;
            }
        }
        else
        {
            if (Vector3.Distance(_scaleDecrease, transform.localScale) >= Epsilon)
            {
                resizing -= _speedResizing * Vector3.one;
            }
            else
            {
                _enabled = true;
            }
        }

        transform.localScale = resizing;
    }
}
