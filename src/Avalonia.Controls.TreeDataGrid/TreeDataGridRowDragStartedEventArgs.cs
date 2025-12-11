using System.Collections.Generic;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Avalonia.Controls
{
    /// <summary>
    /// Provides data for the <see cref="TreeDataGrid.RowDragStarted"/> event.
    /// </summary>
    public class TreeDataGridRowDragStartedEventArgs : RoutedEventArgs
    {
        public TreeDataGridRowDragStartedEventArgs(IEnumerable<object> models, PointerEventArgs innerEvent)
            : base(TreeDataGrid.RowDragStartedEvent)
        {
            Models = models;
            Inner = innerEvent;
        }

        public DragDropEffects AllowedEffects { get; set; }
        public IEnumerable<object> Models { get; }
        public PointerEventArgs Inner { get; }
    }
}
