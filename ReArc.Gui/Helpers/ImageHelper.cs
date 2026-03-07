using ReArc.Shared;

namespace ReArc.Gui.Helpers
{
    public static class ImageHelper
    {
        public static readonly DirectoryInfo ImagesFolder = Directory.CreateTempSubdirectory();
        public static async Task<CommandResult<string>> DownloadImageToTemp(string url)
        {
            var path = Path.Join(ImagesFolder.FullName, Guid.NewGuid().ToString());
            var client = new HttpClient();

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var stream = await response.Content.ReadAsStreamAsync();
                var fileStream = new FileStream(path, FileMode.Create);
                await stream.CopyToAsync(fileStream);

                return CommandResult<string>.Ok(path);
            }
            catch (Exception e)
            {
                return CommandResult<string>.Error(e.Message);
            }
        }
    }
}
