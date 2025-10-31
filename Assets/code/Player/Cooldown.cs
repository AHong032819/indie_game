using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Cooldown : MonoBehaviour
{
    [SerializeField] private float CooldownTime;
    private float JumpCoolTime;
    public bool IsCoolingDown => Time.time < JumpCoolTime;
    public void StartCoolDown() => JumpCoolTime = Time.time + CooldownTime;

}

