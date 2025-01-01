﻿using System;
using GameplayAssembly.HealthSystem;
using Scellecs.Morpeh;
using UnityEngine;

namespace Gameplay
{
    public class WorldContainer : MonoBehaviour
    {
        private void Start()
        {
            var world = World.Default;

            var systemGroup = world.CreateSystemsGroup();
            systemGroup.AddSystem(new HealthSystem());
            
            world.AddSystemsGroup(order: 0, systemGroup);
        }
    }
}