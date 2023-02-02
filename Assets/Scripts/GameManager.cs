using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public MonoGameManager mono = GameObject.Find("Manager").GetComponent<MonoGameManager>();

    public enum CamMode
    {
        first, third, thirdFixed, stationary
    };
    public CamMode camMode;
    public Vector3 camPoint;
    public Transform camObj;
}
