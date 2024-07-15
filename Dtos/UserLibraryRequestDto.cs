
namespace PlatformUserApi.Dtos
{
    public class UserLibraryRequestDto
    {
        public Guid Id { get; set; }
        public List<string> Filters { get; set; }
    }
}