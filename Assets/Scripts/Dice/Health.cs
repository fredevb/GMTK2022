using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Points {get; set;}
    public int MaxPoints {get; set;}

    public delegate void OnAddPointsDelegate(int amount);
    public delegate void OnDeathDelegate();
    public delegate void OnDeathFinalDelegate();

    public event OnAddPointsDelegate OnAddPoints;
    public event OnDeathDelegate OnDeath;
    public event OnDeathFinalDelegate OnDeathFinal;

    public void AddPoints(int amount)
    {
        Points += amount;
        OnAddPoints?.Invoke(amount);
        if (Points > MaxPoints)
            Points = MaxPoints;
        if (Points <= 0){
            Kill();
        }
    }
    public void Kill(){
        Points = 0;
        OnDeath?.Invoke();
        OnDeathFinal?.Invoke();
    }
}
