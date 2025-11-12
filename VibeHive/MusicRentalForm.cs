using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VibeHive.Models;

namespace VibeHive
{
    //package added: newtonsoft.json
    public partial class MusicRentalForm : Form
    {
       //global httpclient instance used to send requests to API
        private static readonly HttpClient _httpClient = new HttpClient();
        public MusicRentalForm()
        {
            InitializeComponent();

        }

        //triggered event when the form loads: loads customers and available music albums into combo boxes 
        private async void MusicRentalForm_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync(showMessages: false); //load customers silently when form loads
            await LoadMusicAlbumsAsync();

        }

        //--- Tab 1: View Customers ----
        //add customer button click event --create a new customer record and sends it toAPI via POST
        private async void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            //create a new customer object matching the API model

            var newCustomer = new
            {
                Name = txb_CustomerName.Text,
                Email = txb_CustomerEmail.Text

            };
            //manually serialize the object to JSON --convert the object to json for transmission
            var json = JsonConvert.SerializeObject(newCustomer);
            //Create HttpContent with Json string (takes 3 things) 
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //now we can conect to API --send the POST request, takes 2 param (where to send it to and content) 
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7061/api/Customer", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Added Successfully :)", "success");
                await LoadCustomersAsync(showMessages: true); // Refresh combo box on Rentals tab so that new customer appears

            }
            else
            {
                MessageBox.Show("failed to add the Customer! :(", "Error");
            }

        }

        //Button: Get All Customers: retrieves all customers from the api and displays them in a listbox
        private async void btn_GetAllCustomers_Click(object sender, EventArgs e)
        {
            //clear the listbox 
            listBox_Customers.Items.Clear();

            //only need url where it i hosted
            HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7061/api/Customer");

            if (message.IsSuccessStatusCode)
            {
                //read the response message(content) as string
                string jsonString = await message.Content.ReadAsStringAsync();

                //deserialize the json string into the list of book objects 
                var customers = JsonConvert.DeserializeObject<List<CustomerDto>>(jsonString);

                //displays each customer's details
                foreach (CustomerDto customer in customers)
                {
                    //add to listbox 
                    listBox_Customers.Items.Add($"(ID: {customer.CustomerId}) Name: {customer.Name} Email: {customer.Email}");
                }

            }
            else
            {
                MessageBox.Show("Failed to retrieve customers", "Error");
            }

        }

        //---- Tab2: View Music Library ----
        //Button: add music album button click -- adds a new album record by sending data to the api 
        private async void btn_AddMusicAlbum_Click(object sender, EventArgs e)
        {
            //validation of numeric year input
            int year;
            if (!int.TryParse(txb_AlbumYear.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            //create an object for the music with he same name as it appears in the API 
            var newMusicAlbum = new
            {
                Title = txb_AlbumTitle.Text,
                Artist = txb_AlbumArtist.Text,
                Genre = txb_AlbumGenre.Text,
                Year = year,

            };

            //manually serialize the object to JSON 
            var json = JsonConvert.SerializeObject(newMusicAlbum);

            //Create HttpContent with Json string (takes 3 things) 
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //now we can conect to API --send the POST request, takes 2 param (where to send it to and content) 
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7061/api/Music", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Music Album Added Successfully :)", "success");
                await LoadMusicAlbumsAsync(); // Refresh combo box on Rentals tab

            }
            else
            {
                MessageBox.Show("failed to add the Music Album! :(", "Error");
            }

        }

        //Tab 2:View Music Library
        //Button: list all albums button --displays all albums retrieved from the api in the listbox
        private async void btn_ListAllAlbums_Click(object sender, EventArgs e)
        {
            // Clear existing items in the listbox
            listBox_MusicAlbums.Items.Clear();

            try
            {
                // Send GET request to your API endpoint --fetch all albums from api 
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7061/api/Music");

                // Check if response was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read response content as a string
                    string jsonString = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON into a list of MusicDto objects
                    var albums = JsonConvert.DeserializeObject<List<MusicDto>>(jsonString);

                    // Add each album to the listbox for display
                    foreach (MusicDto album in albums)
                    {
                        listBox_MusicAlbums.Items.Add($"(Album ID: {album.MusicId}) | Album Name: {album.Title} by {album.Artist} | Genre: {album.Genre} | Year: {album.Year}");
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve albums. Status code: {response.StatusCode}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to API: {ex.Message}", "Exception");
            }

        }

        //--- Tab3: View Rentals:-----
        //Button: Rent music albim --sends a post request to the rental api to rent the selcted album for the selcted customer
        private async void btn_RentMusicAlbum_Click(object sender, EventArgs e)
        {

            // Make sure both selections are made
            if (cmb_Customers.SelectedValue == null || cmb_MusicAlbums.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer and an album.");
                return;
            }

            int customerId = Convert.ToInt32(cmb_Customers.SelectedValue);
            int musicId = Convert.ToInt32(cmb_MusicAlbums.SelectedValue);


            try
            {
                
                // Build api url with query parameters of customerid and musicid
                string url = $"https://localhost:7061/api/Rental?customerId={customerId}&musicId={musicId}";
                HttpResponseMessage response = await _httpClient.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(result, "Rental Success");

                    //refresh available albums to update availability
                    await LoadMusicAlbumsAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to rent album: {error}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to API: {ex.Message}");
            }
        }

        //load available music album for user to select for renting in the combobox 
        private async Task LoadMusicAlbumsAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7061/api/Music");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var albums = JsonConvert.DeserializeObject<List<MusicDto>>(json);
                    
                    //filter out unavailable albums --those that have already been rented
                    var availableAlbums = albums.Where(a => a.IsAvailable).ToList();
                    
                    //data from music album to combo box for selection 
                    cmb_MusicAlbums.DataSource = availableAlbums
                    .Select(a => new { Display = $"{a.MusicId} - {a.Title}", Value = a.MusicId })
                    .ToList();
                    cmb_MusicAlbums.DisplayMember = "Display";
                    cmb_MusicAlbums.ValueMember = "Value";
                }
                else
                {
                    MessageBox.Show("Failed to load albums.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading albums: {ex.Message}");
            }
        }

        //load customers to combo box for user to select for rental selection 
        //showMessages flag  is false to prevent popup alert during silent loads
        private async Task LoadCustomersAsync(bool showMessages = false)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7061/api/Customer");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var customers = JsonConvert.DeserializeObject<List<CustomerDto>>(json);

                    if (customers != null && customers.Any())
                    {
                        var customerDisplayList = customers
                           .Select(c => new { Display = $"{c.CustomerId} - {c.Name}", Value = c.CustomerId })
                           .ToList();

                        cmb_Customers.DataSource = customerDisplayList;
                        cmb_Customers.DisplayMember = "Display";
                        cmb_Customers.ValueMember = "Value";
                    }
                    else if (showMessages)
                    {
                        MessageBox.Show("No customers found in API response.");
                    }
                }
                else if (showMessages)
                {
                    MessageBox.Show($"Failed to load customers: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                if (showMessages) MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        //display all active rentals in listbox by joinign rental, customer and music data 
        private async void btn_ViewActiveRentals_Click(object sender, EventArgs e)
        {
            listBox_AllActiveRentals.Items.Clear();

            try
            {
                // Get all active rentals from API
                HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7061/api/Rental");

                // Get all customers and music albums
                HttpResponseMessage customerMessage = await _httpClient.GetAsync("https://localhost:7061/api/Customer");
                HttpResponseMessage musicMessage = await _httpClient.GetAsync("https://localhost:7061/api/Music");

                if (message.IsSuccessStatusCode && customerMessage.IsSuccessStatusCode && musicMessage.IsSuccessStatusCode)
                {
                    string rentalsJson = await message.Content.ReadAsStringAsync();
                    string customersJson = await customerMessage.Content.ReadAsStringAsync();
                    string musicJson = await musicMessage.Content.ReadAsStringAsync();

                    var rentals = JsonConvert.DeserializeObject<List<RentalDto>>(rentalsJson);
                    var customers = JsonConvert.DeserializeObject<List<CustomerDto>>(customersJson);
                    var albums = JsonConvert.DeserializeObject<List<MusicDto>>(musicJson);

                    if (rentals == null || !rentals.Any())
                    {
                        MessageBox.Show("No active rentals found.");
                        return;
                    }

                    //matches each rental with its customer and album 
                    foreach (RentalDto rental in rentals)
                    {
                        var customer = customers.FirstOrDefault(c => c.CustomerId == rental.CustomerId);
                        var album = albums.FirstOrDefault(m => m.MusicId == rental.MusicId);

                        if (customer != null && album != null)
                        {
                            listBox_AllActiveRentals.Items.Add(
                                $"{rental.RentalId}: Customer: {customer.Name} Music: {album.Title} (Rental Date: {rental.RentalDate})"
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve active rentals", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception");
            }

        }

        //return music abum button --sends post request to api to makek a rental has been returned 
        private async void btn_ReturnMusicAlbum_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txb_RentalIdToReturn.Text, out int rentalId))
            {
                MessageBox.Show("Please enter a valid Rental ID.");
                return;
            }

            try
            {
                HttpResponseMessage message = await _httpClient.PostAsync($"https://localhost:7061/api/Rental/{rentalId}/return", null);

                if (message.IsSuccessStatusCode)
                {
                    MessageBox.Show("Music Rental returned successfully", "Success");
                    btn_ViewActiveRentals_Click(sender, e); // refresh active rentals list after successful return
                    await LoadMusicAlbumsAsync();            // refresh album list
                }
                else
                {
                    string error = await message.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to return rental: {error}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning rental: {ex.Message}");
            }
        }

       

        
    }

}
