using UnityEngine;

public class PlacesMover : MonoBehaviour
{
    [SerializeField] private Transform _placesWay;

    private Transform[] _places;
    private int _placeIndex;
    private float _targetSpeed;

    private void Start()
    {
        _places = new Transform[_placesWay.childCount];

        for (int i = 0; i < _places.Length; i++)
            _places[i] = _placesWay.GetChild(i);
    }

    private void Update()
    {
        var arrayIndex = _places[_placeIndex];
        transform.position = Vector3.MoveTowards(transform.position, arrayIndex.position, _targetSpeed * Time.deltaTime);

        if (transform.position == arrayIndex.position)
            NextPlace();
    }

    private void NextPlace()
    {
        if (_placeIndex == _places.Length)
            _placeIndex = (_placeIndex + 1) % _places.Length;

        var thisPointVector = _places[_placeIndex].transform.position;
        transform.forward = thisPointVector - transform.position;
    }
}