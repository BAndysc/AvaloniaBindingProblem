using Avalonia;

namespace AvaloniaBindingProblem
{
    public class Custom
    {
        public static readonly AttachedProperty<string> CustomPropertyProperty = AvaloniaProperty.RegisterAttached<IAvaloniaObject, string>("CustomProperty", typeof(Custom), "default value");

        public static string GetCustomProperty(IAvaloniaObject obj)
        {
            return obj.GetValue(CustomPropertyProperty);
        }

        public static void SetCustomProperty(IAvaloniaObject obj, string value)
        {
            obj.SetValue(CustomPropertyProperty, value);
        }
    }
}