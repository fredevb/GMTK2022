using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileVisual : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    private AnimationCurve scale;

    private bool highlighted;

    void OnMouseEnter()
    {
        if (!highlighted)
        {
            highlighted = true;
            StartCoroutine(hoverAnim(0.25f, 0.05f, 1f, 50f, Color.blue));
        }
    }

    private void OnMouseExit()
    {
        if (highlighted)
        {
            StartCoroutine(hoverAnim(0.25f, 0.05f, -1f, -50f, Color.white));
            highlighted = false;
        }
    }

    IEnumerator hoverAnim(float time, float step, float posFactor, float scaleFactor, Color color)
    {
        for (float i = 0; i < time; i += step)
        {
            var v = scale.Evaluate(time * step);

            sprite.color = Color.Lerp(sprite.color, color, i/time);
            transform.localScale += new Vector3(v,v) * scaleFactor;
            transform.localPosition += new Vector3(0, v) * posFactor;
            yield return new WaitForSeconds(step);
        }

        yield return true;
    }
}
