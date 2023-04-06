﻿using System.Drawing;

namespace Dumpify.Config;

public class ColorConfig
{
    public static DumpColor? DefaultTypeNameColor { get; } = new DumpColor(Color.White);
    public static DumpColor? DefaultColumnNameColor { get; } = new DumpColor("#87D7D7");
    public static DumpColor? DefaultPropertyNameColor { get; } = null;
    public static DumpColor? DefaultPropertyValueColor { get; } = new DumpColor("#D7D787");
    public static DumpColor? DefaultNullValueColor { get; } = new DumpColor("#87D7D7");
    public static DumpColor? DefaultIgnoredValueColor { get; } = null;
    public static DumpColor? DefaultMetadataInfoColor { get; } = new DumpColor("#87D7D7");
    public static DumpColor? DefaultMetadataErrorColor { get; } = new DumpColor("#D78700");

    public DumpColor? TypeNameColor { get; set; } = DefaultTypeNameColor;
    public DumpColor? ColumnNameColor { get; set; } = DefaultColumnNameColor;
    public DumpColor? PropertyValueColor { get; set; } = DefaultPropertyValueColor;
    public DumpColor? PropertyNameColor { get; set; } = DefaultPropertyNameColor;
    public DumpColor? NullValueColor { get; set; } = DefaultNullValueColor;
    public DumpColor? IgnoredValueColor { get; set; } = DefaultIgnoredValueColor;
    public DumpColor? MetadataInfoColor { get; set; } = DefaultMetadataInfoColor;
    public DumpColor? MetadataErrorColor { get; set; } = DefaultMetadataErrorColor;

    public static ColorConfig DefaultColors => new ColorConfig();
    public static ColorConfig NoColors => new ColorConfig(null);

    public ColorConfig(DumpColor? value)
    {
        TypeNameColor = value;
        ColumnNameColor = value;
        PropertyValueColor = value;
        PropertyNameColor = value;
        NullValueColor = value;
        IgnoredValueColor = value;
        MetadataInfoColor = value;
        MetadataErrorColor = value;
    }

    public ColorConfig()
    {

    }
}
