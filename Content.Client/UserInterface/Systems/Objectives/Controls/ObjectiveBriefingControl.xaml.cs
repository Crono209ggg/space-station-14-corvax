﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.UserInterface.Systems.Objectives.Controls;

[GenerateTypedNameReferences]
public sealed partial class ObjectiveBriefingControl : BoxContainer
{
    public ObjectiveBriefingControl()
    {
        RobustXamlLoader.Load(this);
    }
}