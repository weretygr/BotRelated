﻿using System;

namespace Bot.Builder.Community.WebChatStyling
{
    [Flags]
    public enum StylingAttributeCategory
    {
        Value = 1,
        Name = 2,
        Option = 4
    }
}

/*
if (current.MappedValues != undefined) {
    current.Value = current.MappedValues[current.Value];
}

if (current.Join != undefined) {
    current.Value = current.Value.join(current.Join)
}

if (current.Border != undefined) {
    current.Value = current.Value.CSSText;
}

if (current.Percentage != undefined) {
    current.Value = "'" + current.Value.toString() + "%'";
}
if (current.LengthUnit != undefined) {
    current.Value = "'" + current.Value.UnitString + "'";
}

if (current.ReplaceName != undefined) {
    propertyName = current.ReplaceName(current.Name, current.ReplaceNameParams);
}
if (current.Suffix != undefined) {
    propertyName += current.Suffix;
}
    */
