using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{
    public GameObject cube;
    private void Awake()
    {
        cube.SetActive(true);
    }

    private void OnEnable()
    {
        Debug.Log("ON ENABLE");
    }

    private void OnDisable()
    {
        Debug.Log("ON DISABLE");

    }

    private void Start()
    {
        Debug.Log("START");

    }

    private void Update()
    {
        Debug.Log("UPDATE");

    }

    private void FixedUpdate()
    {
        Debug.Log("FIXED UPDATE");

    }

    private void LateUpdate()
    {
        Debug.Log("LATE UPDATE");

    }
}
