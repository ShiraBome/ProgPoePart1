using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class LocalEventsForm : Form
    {
        // Data Structures
        private SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
        private HashSet<string> uniqueCategories = new HashSet<string>();
        private Stack<string> searchHistory = new Stack<string>();
        private SortedSet<PriorityEvent> priorityEvents = new SortedSet<PriorityEvent>();
        private Queue<Event> eventQueue = new Queue<Event>();

        // New List to Store Favorite Events
        private List<Event> favoriteEvents = new List<Event>();

        public LocalEventsForm()
        {
            InitializeComponent();
            LoadEvents();
            LoadPriorityEvents();
            PopulateCategories();

            LoadEventsIntoQueue();
            DisplayEventsFromQueue();
            DisplayRecommendations();

            // Add event handlers for item activation (click event)
            listViewEvents.ItemActivate += listViewEvents_ItemActivate;
            listViewRecommendations.ItemActivate += listViewRecommendations_ItemActivate;
        }
        private void LoadEvents()
        {
            // Extended sample events with more variety in categories and dates
            List<Event> sampleEvents = new List<Event>
    {
        new Event(DateTime.Now.AddDays(10), "Holiday", "Christmas Celebration", "Join us for a festive celebration with carols, food, and games."),
        new Event(DateTime.Now.AddDays(5), "Sports", "City Marathon", "Participate in the annual marathon and challenge your endurance."),
        new Event(DateTime.Now.AddDays(15), "Concert", "Music Festival", "Enjoy live performances by local and international bands."),
        new Event(DateTime.Now.AddDays(7), "Education", "Science Fair", "Explore innovative projects and meet young scientists."),
        new Event(DateTime.Now.AddDays(20), "Community", "Food Drive", "Help support local families by donating non-perishable food items."),
        new Event(DateTime.Now.AddDays(3), "Workshop", "Art Class", "Learn advanced painting techniques in this hands-on workshop."),
        new Event(DateTime.Now.AddDays(12), "Health", "Yoga Retreat", "Relax and rejuvenate at our week-long yoga retreat in the mountains."),
        new Event(DateTime.Now.AddDays(25), "Technology", "Tech Conference", "Explore the latest in AI, machine learning, and blockchain technologies."),
        new Event(DateTime.Now.AddDays(18), "Festival", "Cultural Festival", "Celebrate diverse cultures with music, dance, and food."),
        new Event(DateTime.Now.AddDays(9), "Sports", "Football Championship", "Watch the final match of the city’s football championship."),
        new Event(DateTime.Now.AddDays(6), "Theatre", "Drama Night", "Attend an evening of gripping drama performances."),
        new Event(DateTime.Now.AddDays(2), "Holiday", "New Year's Eve Party", "Celebrate the new year with a grand party and fireworks."),
        new Event(DateTime.Now.AddDays(14), "Conference", "Business Expo", "Network with industry leaders at the annual business expo."),
        new Event(DateTime.Now.AddDays(8), "Community", "Park Clean-up", "Join volunteers to clean up and beautify the local park."),
        new Event(DateTime.Now.AddDays(22), "Workshop", "Photography Masterclass", "Learn advanced photography techniques from professionals."),
        new Event(DateTime.Now.AddDays(4), "Concert", "Jazz Night", "Enjoy an evening of smooth jazz with top artists."),
        new Event(DateTime.Now.AddDays(16), "Education", "Coding Bootcamp", "Learn coding from scratch in this intensive bootcamp."),
        new Event(DateTime.Now.AddDays(11), "Technology", "Gadget Expo", "Explore the latest gadgets and tech innovations."),
        new Event(DateTime.Now.AddDays(13), "Festival", "Food Festival", "Taste dishes from around the world at the city's largest food festival."),
        new Event(DateTime.Now.AddDays(21), "Community", "Blood Donation Camp", "Donate blood and save lives at the local donation camp."),
        new Event(DateTime.Now.AddDays(1), "Health", "Mental Health Workshop", "Participate in a workshop focused on mental health and well-being."),
        new Event(DateTime.Now.AddDays(17), "Theatre", "Comedy Show", "Laugh out loud at the city's top comedians in this comedy night."),
    };

            foreach (var evt in sampleEvents)
            {
                if (!eventsByDate.ContainsKey(evt.Date.Date))
                {
                    eventsByDate[evt.Date.Date] = new List<Event>();
                }
                eventsByDate[evt.Date.Date].Add(evt);

                uniqueCategories.Add(evt.Category);
            }
        }


        private void LoadPriorityEvents()
        {
            foreach (var evt in eventsByDate.Values.SelectMany(e => e))
            {
                priorityEvents.Add(new PriorityEvent(evt));
            }
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            cmbCategory.Items.AddRange(uniqueCategories.ToArray());
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadEventsIntoQueue()
        {
            foreach (var evt in eventsByDate.Values.SelectMany(e => e))
            {
                eventQueue.Enqueue(evt);
            }
        }

        private void DisplayEventsFromQueue()
        {
            listViewEvents.Items.Clear();
            while (eventQueue.Count > 0)
            {
                var evt = eventQueue.Dequeue();
                ListViewItem item = new ListViewItem(evt.Date.ToShortDateString());
                item.SubItems.Add(evt.Category);
                item.SubItems.Add(evt.Title);
                item.SubItems.Add(evt.Description);
                listViewEvents.Items.Add(item);
            }
        }

        // Modify the DisplayEvents method to display favorite events at the top
        private void DisplayEvents(IEnumerable<Event> eventList)
        {
            listViewEvents.Items.Clear();

            // Display favorite events first
            foreach (var evt in favoriteEvents.OrderBy(e => e.Date))
            {
                ListViewItem item = new ListViewItem(evt.Date.ToShortDateString());
                item.SubItems.Add(evt.Category);
                item.SubItems.Add(evt.Title);
                item.SubItems.Add(evt.Description);
                item.BackColor = System.Drawing.Color.LightGoldenrodYellow;  // Highlight favorite events
                listViewEvents.Items.Add(item);
            }

            // Display non-favorite events
            var nonFavoriteEvents = eventList.Where(e => !favoriteEvents.Contains(e));
            foreach (var evt in nonFavoriteEvents.OrderBy(e => e.Date))
            {
                ListViewItem item = new ListViewItem(evt.Date.ToShortDateString());
                item.SubItems.Add(evt.Category);
                item.SubItems.Add(evt.Title);
                item.SubItems.Add(evt.Description);
                listViewEvents.Items.Add(item);
            }
        }

        private void btnFavoriteEvent_Click(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewEvents.SelectedItems[0];

                // Find the event based on the selected item
                string eventTitle = selectedItem.SubItems[2].Text; // Assuming title is the 3rd column
                var selectedEvent = eventsByDate.Values
                    .SelectMany(eventListItem => eventListItem)  // Renaming 'e' to 'eventListItem' to avoid conflict
                    .FirstOrDefault(evt => evt.Title == eventTitle);

                // Add the event to the favorites list if it's not already a favorite
                if (selectedEvent != null && !favoriteEvents.Contains(selectedEvent))
                {
                    favoriteEvents.Add(selectedEvent);
                    MessageBox.Show($"Event '{selectedEvent.Title}' added to favorites!", "Favorite Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem as string;
            DateTime selectedDate = dtpEventDate.Value.Date;

            // Check if the keyword is the placeholder "Enter a keyword" and treat it as blank
            string keyword = txtKeyword.Text.Trim();
            if (keyword == "Enter a keyword")
            {
                keyword = "";  // Treat it as blank
            }

            SaveSearchPattern(selectedCategory, selectedDate, keyword);

            // Filter events based on the search
            var filteredEvents = FilterEvents(selectedCategory, selectedDate, DateTime.Now.AddMonths(1), keyword);

            // Display events, with favorites on top
            DisplayEvents(filteredEvents);

            DisplayRecommendations();
        }

        private IEnumerable<Event> FilterEvents(string category, DateTime startDate, DateTime endDate, string keyword)
        {
            IEnumerable<Event> filteredEvents = eventsByDate
                .Where(kvp => kvp.Key >= startDate && kvp.Key <= endDate)
                .SelectMany(e => e.Value);

            if (category != "All Categories")
            {
                filteredEvents = filteredEvents.Where(e => e.Category == category);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                filteredEvents = filteredEvents.Where(e =>
                    e.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    e.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return filteredEvents;
        }



        private void SaveSearchPattern(string category, DateTime date, string keyword)
        {
            string pattern = $"{category}|{date.ToShortDateString()}|{keyword}";
            searchHistory.Push(pattern);
        }

        private List<Event> GenerateRecommendations()
        {
            if (searchHistory.Count == 0)
            {
                return priorityEvents.Select(pe => pe.Event).Take(5).ToList();
            }

            string lastSearch = searchHistory.Peek();
            string[] parts = lastSearch.Split('|');
            string category = parts[0];
            DateTime date = DateTime.Parse(parts[1]);
            string keyword = parts[2];

            var recommendations = eventsByDate.Values
                .SelectMany(e => e)
                .Where(evt =>
                    (category != "All Categories" && evt.Category == category) ||
                    (date != DateTime.Now.Date && evt.Date.Date == date) ||
                    (!string.IsNullOrEmpty(keyword) &&
                     (evt.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                      evt.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)))
                .OrderBy(e => e.Date)
                .ToList();

            return recommendations;
        }

        private void DisplayRecommendations()
        {
            var recommendedEvents = GenerateRecommendations();

            listViewRecommendations.Items.Clear();

            foreach (var evt in recommendedEvents)
            {
                ListViewItem item = new ListViewItem(evt.Date.ToShortDateString());
                item.SubItems.Add(evt.Category);
                item.SubItems.Add(evt.Title);
                item.SubItems.Add(evt.Description);
                listViewRecommendations.Items.Add(item);
            }
        }

        // Event handler for listViewEvents click (item activation)
        private void listViewEvents_ItemActivate(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewEvents.SelectedItems[0];
                ShowEventDetails(selectedItem);
            }
        }

        // Event handler for listViewRecommendations click (item activation)
        private void listViewRecommendations_ItemActivate(object sender, EventArgs e)
        {
            if (listViewRecommendations.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRecommendations.SelectedItems[0];
                ShowEventDetails(selectedItem);
            }
        }

        // Method to display event details in a MessageBox
        private void ShowEventDetails(ListViewItem item)
        {
            string date = item.SubItems[0].Text;
            string category = item.SubItems[1].Text;
            string title = item.SubItems[2].Text;
            string description = item.SubItems[3].Text;

            string message = $"Event Details:\n\nDate: {date}\nCategory: {category}\nTitle: {title}\nDescription: {description}";
            MessageBox.Show(message, "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnViewAllEvents_Click(object sender, EventArgs e)
        {
            // Reset the category selection to "All Categories"
            cmbCategory.SelectedIndex = 0;

            // Reset the date to today's date
            dtpEventDate.Value = DateTime.Now;

            // Reset the keyword textbox to its placeholder
            txtKeyword.Text = "Enter a keyword";
            txtKeyword.ForeColor = System.Drawing.Color.Gray;  // Optional: Set hint color to gray

            // Flatten all events stored in the SortedDictionary and display them in listViewEvents
            var allEvents = eventsByDate.Values.SelectMany(eventList => eventList);
            DisplayEvents(allEvents);
        }

        private void txtKeyword_GotFocus(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "Enter a keyword")
            {
                txtKeyword.Text = "";  // Clear the hint text when focused
                txtKeyword.ForeColor = System.Drawing.Color.Black;  // Optional: Change text color to black
            }
        }

        private void txtKeyword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                txtKeyword.Text = "Enter a keyword";  // Restore the hint text if left empty
                txtKeyword.ForeColor = System.Drawing.Color.Gray;  // Optional: Set hint color to gray
            }
        }


        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.Show();
        }
    }
}
