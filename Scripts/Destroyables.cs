using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyables : MonoBehaviour
{
    Renderer mRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mRenderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
