﻿using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Client
{
    [UsedImplicitly, CreateAssetMenu(fileName = "Nameplate Settings", menuName = "Game Data/Interface/Nameplate Settings", order = 2)]
    public class NameplateSettings : ScriptableObject
    {
        [Serializable]
        public class HostilitySettings
        {
            [SerializeField, UsedImplicitly] private bool showName;
            [SerializeField, UsedImplicitly] private bool showCast;
            [SerializeField, UsedImplicitly] private bool showHealth;
            [SerializeField, UsedImplicitly] private Color healthColor;
            [SerializeField, UsedImplicitly] private Color nameWithoutPlateColor;
            [SerializeField, UsedImplicitly] private Color nameWithPlateColor;
            [SerializeField, UsedImplicitly] private float selectedGeneralAlpha;
            [SerializeField, UsedImplicitly] private float deselectedGeneralAlpha;
            [SerializeField, UsedImplicitly] private bool applyScaling;

            public bool ShowName => showName;
            public bool ShowCast => showCast;
            public bool ShowHealth => showHealth;
            public Color HealthColor => healthColor;
            public Color NameWithoutPlateColor => nameWithoutPlateColor;
            public Color NameWithPlateColor => nameWithPlateColor;
            public float SelectedGeneralAlpha => selectedGeneralAlpha;
            public float DeselectedGeneralAlpha => deselectedGeneralAlpha;
            public bool ApplyScaling => applyScaling;
        }

        [SerializeField, UsedImplicitly] private HostilitySettings self;
        [SerializeField, UsedImplicitly] private HostilitySettings friendly;
        [SerializeField, UsedImplicitly] private HostilitySettings neutral;
        [SerializeField, UsedImplicitly] private HostilitySettings enemy;
        [SerializeField, UsedImplicitly] private AnimationCurve scaleOverDistance;

        public HostilitySettings Self => self;
        public HostilitySettings Friendly => friendly;
        public HostilitySettings Neutral => neutral;
        public HostilitySettings Enemy => enemy;
        public AnimationCurve ScaleOverDistance => scaleOverDistance;
    }
}
