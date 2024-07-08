using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class InstantiateBulletsShooting : MonoBehaviour
{
    [SerializeField] public float _shotDistance;
    [SerializeField] private Transform _prefab;
    [SerializeField] private float _timeWaitShooting;

    public Transform ObjectToShoot;

    private void Start()
    {
        StartCoroutine(ShootingWorker());
    }

    private IEnumerator ShootingWorker()
    {
        bool isWorking = enabled;

        while (isWorking)
        {
            var vector3direction = (ObjectToShoot.position - transform.position).normalized;
            var newBullet = Instantiate(_prefab, transform.position + vector3direction, Quaternion.identity);

            newBullet.GetComponent<Rigidbody>().transform.up = vector3direction;
            newBullet.GetComponent<Rigidbody>().velocity = vector3direction * _shotDistance;

            yield return new WaitForSeconds(_timeWaitShooting);
        }
    }
}