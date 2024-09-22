using Avalonia.Controls.Templates;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    public interface ITemplateCell
    {
        IDataTemplate GetCellTemplate(Control control);
        IDataTemplate? GetCellEditingTemplate(Control control);
        object? Value { get; }
    }
}
