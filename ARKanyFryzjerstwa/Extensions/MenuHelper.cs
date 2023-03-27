namespace ARKanyFryzjerstwa.Extensions
{
    public static class MenuHelper
    {
        private const string ACTIVE_TAB_CLASS = "active";

        /// <summary> Zwraca klasę HTML, jeśli dana zakładka jest aktualnie aktwyna. </summary>
        /// <param name="currentPath"> Ścieżka do aktualnej strony. </param>
        /// <param name="tabPath"> Ścieżka do sprawdzanej strony. </param>
        /// <returns> Klasa "active", jeśli zakładka jest aktywna. W przeciwnym wypadku zwraca pusty ciąg znaków.</returns>
        public static string GetTabClassActive(string currentPath, string tabPath)
        {
            if (currentPath == null || tabPath == null)
            {
                return string.Empty;
            }
            var path = currentPath.Trim().Trim('/').ToLower();
            var tab = tabPath.Trim().Trim('/').ToLower();
            if (path == tab)
            {
                return ACTIVE_TAB_CLASS;
            }
            if (!path.StartsWith(tab))
            {
                return string.Empty;
            }
            if (path[tab.Length] == '/')
            {
                return ACTIVE_TAB_CLASS;
            }
            return string.Empty;
        }
    }
}
