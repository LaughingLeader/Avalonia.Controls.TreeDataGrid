
using System;
using System.ComponentModel;
using Avalonia.Controls.Templates;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    public class TemplateCell : ICell, IEditableObject, ITemplateCell
    {
        private ITemplateCellOptions? _options;

        private Func<Control, IDataTemplate> _getCellTemplate;
        private Func<Control, IDataTemplate>? _getCellEditingTemplate;

        public TemplateCell(
            object? value,
            Func<Control, IDataTemplate> getCellTemplate,
            Func<Control, IDataTemplate>? getCellEditingTemplate,
            ITemplateCellOptions? options)
        {
            _getCellTemplate = getCellTemplate;
            _getCellEditingTemplate = getCellEditingTemplate;
            Value = value;
            _options = options;
        }

        public IDataTemplate GetCellTemplate(Control control) => _getCellTemplate(control);
        public IDataTemplate? GetCellEditingTemplate(Control control) => _getCellEditingTemplate?.Invoke(control);

        public bool CanEdit => _getCellEditingTemplate is not null;
        public BeginEditGestures EditGestures => _options?.BeginEditGestures ?? BeginEditGestures.Default;
        
        public object? Value { get; }

        void IEditableObject.BeginEdit() => (Value as IEditableObject)?.BeginEdit();
        void IEditableObject.CancelEdit() => (Value as IEditableObject)?.CancelEdit();
        void IEditableObject.EndEdit() => (Value as IEditableObject)?.EndEdit();
    }
}
