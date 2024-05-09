using Microsoft.AspNetCore.Components.Forms;

namespace TangyWeb_Server.Service.IService
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string filePath)
        {
            if(File.Exists(_webHostEnvironment.WebRootPath + filePath))
            {
                File.Delete(_webHostEnvironment.WebRootPath + filePath);
                return true;
            }
            return false;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            FileInfo fileInfo = new FileInfo(file.Name);
            var fileName = Guid.NewGuid().ToString()+fileInfo.Extension;
            var folderDirectiory = $"{_webHostEnvironment.WebRootPath}\\images\\product";
            if(!Directory.Exists(folderDirectiory))
            {
                Directory.CreateDirectory(folderDirectiory);
            }
            var filePath = Path.Combine(folderDirectiory, fileName);
            await using FileStream fs = new FileStream(filePath, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(fs);
            var fullPath = $"/images/product/{fileName}";
            return fullPath;
        }
    }
}
