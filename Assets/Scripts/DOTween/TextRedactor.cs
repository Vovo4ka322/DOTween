using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextRedactor : MonoBehaviour
{
    [SerializeField] private Text _textPointOne;
    [SerializeField] private Text _textPointTwo;
    [SerializeField] private Text _textPointThree;
    [SerializeField] private float _duration;

    private void Start()
    {
        string textPointOne = "Крокодилдо";
        string textPointTwo = "\nКаламбургер";
        string textPointThree= "ЧикенМакНагец";

        _textPointOne.DOText(textPointOne, _duration);
        _textPointTwo.DOText(textPointTwo, _duration).SetRelative();
        _textPointThree.DOText(textPointThree, _duration, true, ScrambleMode.All);
    }
}
