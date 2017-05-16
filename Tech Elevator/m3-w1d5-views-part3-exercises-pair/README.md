# Fly By Night Bank

Using the concepts learned in today's class you will be developing a three page web application that displays
the Fly By Night Banking home page, a list of your accounts, and a detailed transaction view for a particular account.

* **You need to use a Layout Page**. All pages must have a consistent look and feel with minimal duplicate code. 
    * We've provided you the initial `index.html` page with the three column layout. **Use that to help start developing your layout page.**
   
* One view lists all of the available bank accounts with their name, balance, and account number. The url for your view is `http://loocalhost/Home/BankListin`

![Bank Account Listing](bank-account-listing.png)

* The *View* link is dynamically generated. Clicking on it, takes the user to a Bank Account Detail page for that specific bank account.
    * This view includes the transaction history for the bank account obect.
    * The url for this view is `http://localhost/Home/BankAccountDetail/{account-id}` where account-id is the id of the bank account to display 

![Bank Detail Listing](bank-detail-listing.png)

** Bonus **

Customize the layout further

# Movie Show Times

Using the concepts learned in today's class you will be developing a two page web application that displays
a listing of movies and available showtimes.

* **You need to use a Layout Page** for your application so that both pages have a consistent look and feel with
minimal duplicate layout code. You will also need to create two separate views.
    * A sample view (`index.cshtml`) file has been provided within your repository so that you and your partner can use it to extract common layout components.

* One view lists all of the available movies. The url for your view is `http://localhost/Home/MovieListing`    

![Movie Listing](movie-listing.jpg)

* Clicking on the *View Times* link takes the user to a View Detail page for that specfic movie. 
    * This view includes the cast members and showtimes for the current movie. 
    * The url for this view is `http://localhost/Home/MovieDetail/{movie-id}` where movie-id is the id of the movie to display.

![Detailed Movie Listing](detailed-movie-listing.jpg)

** Bonus **

Customize the layout of the detailed movie listing. Find movie posters online and display them on the detail page with your content. 










foreach (bankaccount account in Model) 
{
	if (bankaccount.accountnumber != storedAccountNumber)	
	{
		break;
	}
	else 
	{
		printBankInformation(storedAccountNumber);
	}
}