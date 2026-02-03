using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointText;
    private int points;

    private void Start()
    {
        Locator.Instance.Player.PointEvent += HandlePoint;
    }

    public void HandlePoint()
    {
        points++;
        _pointText.text = points.ToString();
    }
}
