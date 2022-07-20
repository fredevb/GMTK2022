using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceAnimator : MonoBehaviour
{
    [SerializeField]
    private Dice dice;

    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private IEnumerator animationCoroutine;

    // Start is called before the first frame update
    void Awake()
    {
        dice.OnRoll += AnimateRoll;
    }

    public void AnimateRoll()
    {
        int id = dice.RollID;
        if (animationCoroutine != null)
            StopCoroutine(animationCoroutine);
        animationCoroutine = RollAnimationEnumerable(id);
        StartCoroutine(animationCoroutine);
    }
    private IEnumerator RollAnimationEnumerable(int id)
    {
        var times = Random.Range(5, 20);
        for(int i = 0; i < times; i++)
        {
            spriteRenderer.sprite = dice.Actions[Random.Range(0, dice.Actions.Length)].Icon;
            yield return new WaitForSeconds(Random.Range(0.02f,0.15f));
        }
    }
}
