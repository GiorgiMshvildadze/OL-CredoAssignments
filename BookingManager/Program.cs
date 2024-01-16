public class BookingManager
{
    public void CreateBooking(string userId, int roomId, DateTime startDate, DateTime endDate, bool includeBreakfast,
        bool useLoyaltyPoints)
    {
        User user = GetUserById(userId);
        Room room = GetRoomById(roomId);

        if (user != null)
        {
            if (room != null)
            {
                if (endDate > startDate)
                {
                    List<DateTime> bookedDates = GetBookedDatesForRoom(roomId);
                    foreach (var date in bookedDates)
                    {
                        if ((date >= startDate) && (date <= endDate))
                        {
                            throw new Exception("Room is not available for the selected dates");
                        }
                    }

                    Booking newBooking = new Booking()
                    {
                        UserId = userId,
                        RoomId = roomId,
                        StartDate = startDate,
                        EndDate = endDate,
                        IncludeBreakfast = includeBreakfast
                    };

                    if (useLoyaltyPoints)
                    {
                        if (user.LoyaltyPoints >= 100)
                        {
                            newBooking.Price =
                                CalculatePrice(roomId, startDate, endDate) - 10; // Discount for loyalty points
                            user.LoyaltyPoints -= 100;
                        }
                        else
                        {
                            throw new Exception("Not enough loyalty points");
                        }
                    }
                    else
                    {
                        newBooking.Price = CalculatePrice(roomId, startDate, endDate);
                    }

                    SaveBooking(newBooking); // Assume this saves the booking to the database
                }
                else
                {
                    throw new Exception("End date must be after start date");
                }
            }
            else
            {
                throw new Exception("Room not found");
            }
        }
        else
        {
            throw new Exception("User not found");
        }
    }

    private User GetUserById(string userId)
    {
        return new User();
    }

    private Room GetRoomById(int roomId)
    {
        return new Room();
    }

    private List<DateTime> GetBookedDatesForRoom(int roomId)
    {
        return new List<DateTime>();
    }

    private decimal CalculatePrice(int roomId, DateTime startDate, DateTime endDate)
    {
        return 0;
    }

    private void SaveBooking(Booking booking)
    {

    }
}

public class User
{
    public string Id { get; set; }
    public int LoyaltyPoints { get; set; }
}

public class Room
{
    public int Id { get; set; }
}

public class Booking
{
    public string UserId { get; set; }
    public int RoomId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IncludeBreakfast { get; set; }

    public decimal Price { get; set; }
}