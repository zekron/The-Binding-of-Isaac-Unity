﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPropFromPool : MonoBehaviour, IRandomObject
{
    public PropPoolType type;

    void Start()
    {
        Generate();
    }

    public GameObject Generate()
    {
        Prop prop = GameManager.Instance.level.pools.GetProp(type);
        Prop go = Instantiate(prop);
        go.transform.SetParent(GameManager.Instance.level.currentRoom.propContainer);
        go.transform.position = transform.position;
        Destroy(gameObject);
        return go.gameObject;
    }
}
