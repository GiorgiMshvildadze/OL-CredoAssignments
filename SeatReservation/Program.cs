namespace SeatReservation;

class SeatReservation
{
    public string[,] seatsArray =  new string[4, 4];
    public string emptySeat = "O ";
    public string reservedSeat = "X ";
    public int OptionInput;
    public int rowInput;
    public  int columnInput;
    public string option1 = "1) Reserve a seat ";
    public string option2 = "2) View Available Seats";
    public string option3 = "3) Exit \n";
    public string enterRowString = "Enter Row: ";
    public string enterColumnString = "Enter Column: ";
    
    public void InitializeSeats()
    {
        Console.WriteLine("Initial Seating Chart");
        for(int i = 0; i < seatsArray.GetLength(0); i++)
        {
            for(int j = 0; j < seatsArray.GetLength(1); j++)
            {
                seatsArray[i, j] = emptySeat;
            }
        }
    }
    public void DisplaySeats()
    {
        for (int i = 0;i < seatsArray.GetLength(0);i++)
        {
            for ( int j = 0;j < seatsArray.GetLength(1); j++)
            {
                Console.Write(seatsArray[i,j]);
            }
           
            Console.WriteLine("\n");
        }
        Console.WriteLine(option1);
        Console.WriteLine(option2);
        Console.WriteLine(option3);
        ChooseOption();
    }
    public void InputColumn()
    {
        Console.WriteLine(enterColumnString);
        if (!Int32.TryParse(Console.ReadLine(), out columnInput ) || columnInput >4 || columnInput <= 0)
        {
            Console.WriteLine("Error, Try Again Please:");
            InputColumn();
        }
        ReserveSeat();
    }

    public void InputRow()
    {
        Console.WriteLine(enterRowString);
        if (!Int32.TryParse(Console.ReadLine(), out rowInput) || rowInput >4 || rowInput <= 0)
        {
            Console.WriteLine("Error, Try Again Please:");
            InputRow();
        }
        InputColumn();
    }


    public void ReserveSeat()
    {
        if (seatsArray[rowInput-1,columnInput-1] != emptySeat)
        {
            Console.WriteLine("Seat is Reserved, Try again:");
            InputRow();
        }
        seatsArray[rowInput - 1, columnInput - 1] = reservedSeat;
    }
    
    public void ChooseOption()
    {
     if(!Int32.TryParse(Console.ReadLine(), out OptionInput))
        {
            Console.WriteLine("Invalid Input.");
            ChooseOption();
        }   

     if(OptionInput == 1)
        {
            InputRow();
        }
     else if(OptionInput == 2)
        {
            DisplaySeats();
        }
    

        
    }
}




class Program
{
    static void Main(string[] args)
    {
        var seatReserver = new SeatReservation();
        seatReserver.InitializeSeats();
        while (true)
        {
            seatReserver.DisplaySeats();
            if(seatReserver.OptionInput == 3)
            {
                break;
            }

        }

    }

}