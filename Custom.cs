using System.Windows;

namespace TestBindings
{
    class Custom
    {
        public static readonly DependencyProperty CustomPropertyProperty = DependencyProperty.RegisterAttached(
          "CustomProperty",
          typeof(string),
          typeof(Custom)
        );
        public static void SetCustomProperty(UIElement element, string value)
        {
            element.SetValue(CustomPropertyProperty, value);
        }
        public static string GetCustomProperty(UIElement element)
        {
            return (string)element.GetValue(CustomPropertyProperty);
        }
    }
}
