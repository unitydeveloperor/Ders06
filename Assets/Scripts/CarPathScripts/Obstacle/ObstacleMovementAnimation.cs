using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovementAnimation : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveZ(100, 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
