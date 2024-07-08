using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CoroutineResizing : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _secondScale;

    private void Start()
    {
        StartCoroutine(ChangeScale());
    }

    private IEnumerator ChangeScale()
    {
        Vector3 startScale = transform.localScale;
        Vector3 target = _secondScale;

        bool isWorking = true;

        while (isWorking)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, target, _speed * Time.deltaTime);

            if (transform.localScale == target)
            {
                if (target == startScale)
                {
                    target = _secondScale;
                }
                else
                {
                    target = startScale;
                }
            }

            yield return null;
        }
    }
}
