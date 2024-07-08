using UnityEngine;

public class SphereMoving : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction);
    }
}
