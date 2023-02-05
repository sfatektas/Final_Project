namespace MSS_NewsWeb.Pages.PagesHelperMethods
{
    public static class HelperMethods
    {
        public static void RemoveFile(string mediaPath)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "src", "Files", mediaPath);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}
