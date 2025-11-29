using System;
using System.Collections.Generic;
using System.Text;

using Avalonia.Controls.Models.TreeDataGrid;
using Avalonia.Input;

namespace Avalonia.Controls;

public class DragDropDataTransfer : IDataTransfer
{
    public DragInfo? Data { get; set; }

    IReadOnlyList<DataFormat> IDataTransfer.Formats => [];
    IReadOnlyList<IDataTransferItem> IDataTransfer.Items => [];
    void IDisposable.Dispose() { }
}
