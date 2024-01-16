using RefactoringForSRP;

public class BookStore
{
    private IBookRepository _bookRepository;
    private IInvoiceGenerator _invoiceGenerator1;
    private IEmailSender _emailSender;
    private IUserRepository _userRepository;
    public BookStore(IBookRepository bookRepository, IInvoiceGenerator invoiceGenerator, IEmailSender emailSender, IUserRepository userRepository)
    {
        _bookRepository = bookRepository;
        _invoiceGenerator1 = invoiceGenerator;
        _emailSender = emailSender;
        _userRepository = userRepository;

    }
    public void ProcessSale(int userId, int bookId)
    {
        var book = _bookRepository.GetBookById(bookId);
        if (book.IsAvailable())
        {
            _bookRepository.UpdateInventory(book);
            var invoice = _invoiceGenerator1.GenerateInvoice(book);

            var user = _userRepository.GetUserById(userId);
            _emailSender.SendInvoiceEmail(invoice, user.Email);
        }
    }

}



