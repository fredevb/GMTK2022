using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerDiceRoller : MonoBehaviour
{
    public GameController GameController {get {return GameController.Main;}}
    private SpriteRenderer spriteRenderer;
    private IEnumerator animationCoroutine;

    [SerializeField]
    private Dice dice;
    public Dice Dice {get{return dice;}}

    public void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Roll()
    {
        dice.Roll();
        AnimateRoll(dice.RollID);
    }

    public void AnimateRoll(int id)
    {
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
            spriteRenderer.sprite = Dice.Actions[Random.Range(0, Dice.Actions.Length)].Icon;
            yield return new WaitForSeconds(Random.Range(0.02f,0.15f));
        }
    }

    public void OnMouseDown()
    {
        GameController.SelectedDiceRoller = this;
    }
}
