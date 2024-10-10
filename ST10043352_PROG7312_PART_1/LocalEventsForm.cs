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

        public LocalEventsForm()
        {
            InitializeComponent();
            LoadEvents();
            LoadPriorityEvents();
            PopulateCategories();
            DisplayEvents(eventsByDate.Values.SelectMany(e => e));
            DisplayRecommendations();
        }

        private void LoadEvents()
        {
            // Sample events (you can replace this with data from a database or file)
            List<Event> sampleEvents = new List<Event>
            {
                new Event(DateTime.Now.AddDays(10), "Holiday", "Christmas Celebration", "Join us for a festive celebration."),
                new Event(DateTime.Now.AddDays(5), "Sports", "City Marathon", "Participate in the annual marathon."),
                new Event(DateTime.Now.AddDays(15), "Concert", "Music Festival", "Enjoy live performances."),
                new Event(DateTime.Now.AddDays(7), "Education", "Science Fair", "Explore innovative projects."),
                new Event(DateTime.Now.AddDays(20), "Community", "Food Drive", "Help support local families."),
                new Event(DateTime.Now.AddDays(3), "Workshop", "Art Class", "Learn painting techniques.")
                // Add more events as needed
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

        private void DisplayEvents(IEnumerable<Event> events)
        {
            listViewEvents.Items.Clear();

            foreach (var evt in events.OrderBy(e => e.Date))
            {
                ListViewItem item = new ListViewItem(evt.Date.ToShortDateString());
                item.SubItems.Add(evt.Category);
                item.SubItems.Add(evt.Title);
                item.SubItems.Add(evt.Description);
                listViewEvents.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem as string;
            DateTime selectedDate = dtpEventDate.Value.Date;
            string keyword = txtKeyword.Text.Trim();

            // Save search patterns for recommendations
            SaveSearchPattern(selectedCategory, selectedDate, keyword);

            var filteredEvents = FilterEvents(selectedCategory, selectedDate, keyword);
            DisplayEvents(filteredEvents);

            DisplayRecommendations();
        }

        private IEnumerable<Event> FilterEvents(string category, DateTime date, string keyword)
        {
            IEnumerable<Event> filteredEvents = eventsByDate.Values.SelectMany(e => e);

            if (category != "All Categories")
            {
                filteredEvents = filteredEvents.Where(e => e.Category == category);
            }

            if (date != DateTime.Now.Date)
            {
                filteredEvents = filteredEvents.Where(e => e.Date.Date == date);
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
                // Return top priority events if no search history
                return priorityEvents.Select(pe => pe.Event).Take(5).ToList();
            }

            string lastSearch = searchHistory.Peek();
            string[] parts = lastSearch.Split('|');
            string category = parts[0];
            DateTime date = DateTime.Parse(parts[1]);
            string keyword = parts[2];

            var recommendations = eventsByDate.Values.SelectMany(e => e).Where(evt =>
                (category != "All Categories" && evt.Category == category) ||
                (date != DateTime.Now.Date && evt.Date.Date == date) ||
                (!string.IsNullOrEmpty(keyword) && (evt.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                evt.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
            ).ToList();

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

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.Show();
        }
    }
}
