# Starlight Cinema Booking System

A desktop cinema booking application written in C# (WinForms, .NET Framework 4.7.2) and backed by a Microsoft Access database. I built it as my A-level Computer Science NEA (2024–25), from requirements gathering with an end user through design, implementation and user testing.

## What it does

- **Accounts:** users register and log in. Passwords are hashed with SHA-256 before they are stored, and registration checks email format and password strength (8–20 characters, upper and lower case, a digit and a symbol).
- **Browse and choose:** pick a film, then a showtime.
- **Seat selection:** an interactive seat map is generated from the database. Seats are colour-coded by type (with different prices) and by availability, and booked seats can't be selected.
- **Payment:** card details are validated on the form. This is a simulated payment: no card data is stored, and only the payment record (amount, date, method) is saved.
- **Booking confirmation:** a summary of the booking after payment.

## Technical overview

| Area | Details |
|---|---|
| Language / UI | C#, Windows Forms |
| Database | MS Access (`.mdb`) accessed through OleDb. The database file and all tables are created on first run using ADOX and hand-written SQL DDL. |
| Data access | Parameterised SQL queries throughout, to prevent SQL injection |
| Security | SHA-256 password hashing, regex input validation |

### Database schema (10 tables)

`Users`, `Movies`, `Showtimes`, `Screens`, `MovieScreenings`, `Seats`, `ScreeningSeats`, `Bookings`, `BookingSeats`, `Payments`

- `MovieScreenings` links a movie, a showtime and a screen on a given date.
- `ScreeningSeats` tracks the status of every seat for each screening, so the same physical seat can be booked independently for different screenings.
- `BookingSeats` is a link table (composite primary key) between bookings and seats.
- Foreign keys are declared in the DDL to enforce referential integrity.

The DDL is in [`DatabaseUtils.cs`](Cinema%20Booking%20System/DatabaseUtils.cs).

## Development process

The project followed a full software development life cycle:

1. **Analysis:** interview with an end user, plus IPSO charts and data flow diagrams
2. **Design:** entity-relationship diagrams and normalised table design, plus UI wireframes
3. **Implementation:** iterative development, form by form
4. **Testing:** a user-testing session with written feedback, and recorded video demonstrations of each feature
5. **Evaluation:** documented limitations and future improvements (below)

## Known limitations

I'd tackle these first if I rebuilt it today:

- **Single user, offline:** the Access database is a local file, so two people can't book at the same time. A real system needs a client-server design with a proper database server.
- **No concurrency control on seat booking:** a queue- or lock-based booking step would stop two users taking the same seat.
- **Unsalted hashes:** passwords are hashed with plain SHA-256. A production system should use a salted, deliberately slow algorithm such as bcrypt or PBKDF2.
- **No automated tests:** testing was manual and recorded on video. I'd now add unit tests for the validation and booking logic.
- **Only one payment method**, and it is simulated.

## Running it

Requirements: Windows, Visual Studio 2022 (".NET desktop development" workload) and the Microsoft Access Database Engine / Jet OLE DB provider.

1. Open `Cinema Booking System.sln` in Visual Studio.
2. Restore NuGet packages (right-click the solution, then choose **Restore NuGet Packages**).
3. Build and run. On first launch the app creates `CinemaDatabase2.mdb` next to the executable.
