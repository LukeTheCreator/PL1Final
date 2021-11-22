namespace PL1Final.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses => responses;

        internal static void AddResponse(GuestResponse guestResponse)
        {
            responses.Add(guestResponse);
        }
    }
}
