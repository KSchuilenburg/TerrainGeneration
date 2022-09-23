using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave : MonoBehaviour
{
    public float period = 1f;
    public float amplitude = 1f;

    public GameObject sphere;
    private MeshRenderer sphereRenderer;

    private GameObject lineDrawing;
    private LineRenderer lineRender;

    private void Start()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 5f;

        lineDrawing = new GameObject();

        sphereRenderer = sphere.GetComponent<MeshRenderer>();
        sphereRenderer.material = new Material(Shader.Find("Diffuse"));

        lineRender = lineDrawing.AddComponent<LineRenderer>();

        lineRender.startWidth = 0.1f;
        lineRender.endWidth = 0.1f;

        lineRender.material = new Material(Shader.Find("Diffuse"));
    }

    private void Update()
    {
        float y = amplitude * Mathf.Cos((2 * Mathf.PI) * Time.time / period);
        sphere.transform.position = new Vector2(0f, y);

        Vector2 center = Vector2.zero;
        lineRender.SetPosition(0, center);
        lineRender.SetPosition(1, sphere.transform.position);
    }
}
