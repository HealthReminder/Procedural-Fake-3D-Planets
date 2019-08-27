﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehaviour : MonoBehaviour
{
    public SpriteRenderer light_appearance;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        StartCoroutine(Delay());
    }   

    IEnumerator Delay() {
        yield return new WaitForSeconds(0.1f);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = light_appearance.color;
        spriteRenderer.color += new Color(0,0,0,-0.4f);
        transform.localScale = light_appearance.transform.localScale*10;
    }
}