﻿using System;

namespace ConsoleTablesPrinter
{
    /// <summary>
    /// Represents the visual style configuration for table output in the console.
    /// </summary>
    /// <remarks>
    /// This class allows you to customize table borders, padding, characters, and alignment. 
    /// It is used when rendering tables via <c>PrintAsTable</c> methods. If no style is passed,
    /// it will default to basic settings
    /// </remarks>
    public class TableStyle
    {
        /// <summary>
        /// Specifies the style of the table border. If <c>null</c>, <see cref="BorderStyles.SingleLine"/> is used.    
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public BorderStyles? BorderStyle { get; set; }

        /// <summary>
        /// Specifies the color of the table border. If <c>null</c>, the default console color is used.    
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public ConsoleColor? BorderColor { get; set; }


        /// <summary>
        /// Specifies the background color for the entire table. If <c>null</c>, no background color is applied.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public ConsoleColor? BackgroundColor { get; set; }

        /// <summary>
        /// Number of spaces to pad inside each cell. Affects only vertical padding.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public int? CellHorizontalPadding { get; set; }


        /// <summary>
        /// Number of horizontal spaces between the table and the left edge of the console.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public int HorizontalPadding { get; set; }

        /// <summary>
        /// Number of vertical lines between the table and the top/bottom edge of the console.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public int VerticalPadding { get; set; }

        /// <summary>
        /// Default style settings applied to header cells unless overridden by a column's <see cref="TablePrintColAttribute"/>.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public CellStyle? HeaderCellStyle { get; set; }

        /// <summary>
        /// Default style settings applied to data cells unless overridden by a column's <see cref="TablePrintColAttribute"/>.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public CellStyle? DataCellStyle { get; set; }

        /// <summary>
        /// If <c>true</c>, inserts a visual row separator between each table row.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public bool UseRowSeparator { get; set; }

        /// <summary>
        /// Specifies the border style to use for row separators. Only used if <see cref="UseRowSeparator"/> is <c>true</c>.
        /// If not set, the value from <see cref="BorderStyle"/> will be used.
        /// <example>
        /// For example: It looks better to use <see cref="BorderStyles.SingleLine"/> for the row separator when the table border style is <see cref="BorderStyles.SingleToDoubleLine"/>
        /// </example>
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public BorderStyles? RowSeparatorStyle { get; set; }


        /// <summary>
        /// If <c>true</c>, table rows will be printed one at a time with a delay between each, creating an animation effect.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public bool UseAnimation { get; set; }

        /// <summary>
        /// Delay in milliseconds between each row when <see cref="UseAnimation"/> is enabled.
        /// Defaults to <c>100</c>ms. Value is clamped between <c>0</c>ms and <c>200</c>ms.
        /// </summary>
        /// <remarks>
        /// Ignored in Markdown mode.
        /// </remarks>
        public int AnimationDelay { get; set; } = 100;

        /// <summary>
        /// Specifies the print mode to use when rendering the table.
        /// Determines whether to apply full styling or output a simplified format like Markdown.
        /// </summary>
        /// <remarks>
        /// - <see cref="TablePrintModes.Normal"/>: Applies all styles, colors, and formatting attributes.
        /// - <see cref="TablePrintModes.Markdown"/>: Ignores all styles and attributes, producing a plain Markdown-compatible table.
        /// </remarks>
        public TablePrintModes PrintMode { get; set; }
       
    }
}
