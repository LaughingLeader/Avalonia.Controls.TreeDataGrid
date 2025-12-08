using System;
using System.ComponentModel;

using Avalonia.Controls.Models.TreeDataGrid;

namespace Avalonia.Controls;

public class TreeDataGridSortedEventArgs
{
    public IColumn Column { get; }
    public ListSortDirection Direction { get; }

    public TreeDataGridSortedEventArgs(IColumn column, ListSortDirection direction)
    {
        Column = column;
        Direction = direction;
    }
}
