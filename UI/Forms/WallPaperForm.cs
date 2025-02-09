using System.Data;
using System.Timers;
using Newtonsoft.Json;
using Timer = System.Timers.Timer;

namespace UI.Controls
{   
    public partial class WallPaperForm : Form
    {
        #region Fields
        ShareFile sf = new ShareFile();
        private Timer wallpaperTimer;
        private List<string> selectedWallpapers = new List<string>();
        #endregion

        #region Constructor
        public WallPaperForm()
        {
            InitializeComponent();
            SetComboBoxes();
            SetTimer();
        }
        #endregion

        #region UI Setup Methods
        private void SetComboBoxes()
        {
            string[] imageFiles = GetImageFiles(folderPath());
            foreach (string file in imageFiles)
            {
                string wallpaperName = Path.GetFileName(file);
                foreach (var state in GetSavedWallpaperStates())
                {
                    if (state.IsSelected && state.WallpaperName == wallpaperName)
                    {
                        startselection.Items.Add(wallpaperName);
                    }
                }
            }
            if (startselection.Items.Count > 0)
            {
                startselection.SelectedIndex = 0;
            }
            changeselection.Items.Add("1min");
            changeselection.Items.Add("5min");
            changeselection.Items.Add("30min");
            changeselection.Items.Add("60min");
            changeselection.SelectedItem = "1min";
        }
        private void displayImages()
        {
            imageContainer.Controls.Clear();
            int imageCount = GetImageCount(folderPath());
            string[] imageFiles = GetImageFiles(folderPath());
            for (int i = 0; i < imageCount; i++)
            {
                WallPaperDisplay paperD = new WallPaperDisplay();
                paperD.SetWallpaperName(Path.GetFileName(imageFiles[i]));
                paperD.SetWallpaperImage(imageFiles[i]);
                imageContainer.Controls.Add(paperD);
            }
        }
        #endregion

        #region Timer Methods
        private void SetTimer()
        {
            wallpaperTimer = new Timer();
            wallpaperTimer.Elapsed += OnWallpaperTimerElapsed;
        }
        private void OnWallpaperTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (selectedWallpapers.Count > 0)
            {
                string nextWallpaper = selectedWallpapers[0];
                selectedWallpapers.RemoveAt(0);
                selectedWallpapers.Add(nextWallpaper);
                WallpaperChanged?.Invoke(nextWallpaper);
            }
        }
        private void SetWallpaperChangeTimer()
        {
            if (wallpaperTimer == null)
            {
                SetTimer();
            }
            wallpaperTimer.Stop();
            int intervalInMinutes = changeselection.SelectedItem?.ToString() switch
            {
                "1min" => 1,
                "5min" => 5,
                "30min" => 30,
                "60min" => 60,
                _ => 0
            };
            if (intervalInMinutes > 0)
            {
                wallpaperTimer.Interval = intervalInMinutes * 60 * 1000;
                wallpaperTimer.Start();
            }
        }
        #endregion

        #region Event Handlers
        private void WallPaperForm_Load(object sender, EventArgs e)
        {
            displayImages();
            LoadWallpaperStates();
        }
        private void startselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWallpaperPath = GetSelectedWallpaperPath();
            WallpaperChanged?.Invoke(selectedWallpaperPath);
        }
        private void changeselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWallpaperChangeTimer();
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            SaveWallpaperStates();
            this.Close();
        }
        #endregion

        #region Wallpaper State Management
        private void SaveWallpaperStates()
        {
            var states = new List<WallpaperState>();
            foreach (WallPaperDisplay paperD in imageContainer.Controls)
            {
                states.Add(new WallpaperState
                {
                    WallpaperName = paperD.CheckBox.Text,
                    IsSelected = paperD.CheckBox.Checked
                });
            }
            string timeInterval = changeselection.SelectedItem?.ToString() ?? "1min";
            var settings = new
            {
                WallpaperStates = states,
                TimeInterval = timeInterval,
                SelectedWallpaperName = startselection.SelectedItem?.ToString()
            };
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(filePath(), json);
        }
        private void LoadWallpaperStates()
        {
            if (File.Exists(filePath()))
            {
                string json = File.ReadAllText(filePath());
                var settings = JsonConvert.DeserializeObject<dynamic>(json);
                var states = settings?.WallpaperStates.ToObject<List<WallpaperState>>();
                string timeInterval = settings?.TimeInterval?.ToString() ?? "1min";
                string selectedWallpaperName = settings?.SelectedWallpaperName?.ToString();
                foreach (var state in states)
                {
                    foreach (WallPaperDisplay paperD in imageContainer.Controls)
                    {
                        if (paperD.CheckBox.Text == state.WallpaperName)
                        {
                            paperD.CheckBox.Checked = state.IsSelected;
                            if (state.IsSelected)
                            {
                                string fullPath = Path.Combine(folderPath(), paperD.CheckBox.Text);
                                selectedWallpapers.Add(fullPath);
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(selectedWallpaperName))
                {
                    startselection.SelectedItem = selectedWallpaperName;
                }
                changeselection.SelectedItem = timeInterval;
            }
        }
        private List<WallpaperState> GetSavedWallpaperStates()
        {
            if (File.Exists(filePath()))
            {
                string json = File.ReadAllText(filePath());
                var settings = JsonConvert.DeserializeObject<dynamic>(json);
                return settings?.WallpaperStates.ToObject<List<WallpaperState>>();
            }
            return new List<WallpaperState>();
        }
        private string GetSelectedWallpaperPath()
        {
            string selectedWallpaperName = startselection.SelectedItem.ToString();
            string[] imageFiles = GetImageFiles(folderPath());
            foreach (var imagePath in imageFiles)
            {
                if (Path.GetFileName(imagePath) == selectedWallpaperName)
                {
                    return imagePath;
                }
            }
            return string.Empty;
        }
        #endregion

        #region Helper Methods
        private string folderPath()
        {
            string rp = sf.RP();
            return $"{rp}wallpaper";
        }
        private string filePath()
        {
            string rp = sf.RP();
            return $"{rp}wallpaper_states.txt";
        }
        private static string[] GetImageFiles(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return Directory.GetFiles(directoryPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                   file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                   file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                   file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                   file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                    .ToArray();
            }
            return Array.Empty<string>();
        }
        private static int GetImageCount(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] imageFiles = GetImageFiles(directoryPath);
                return imageFiles.Length;
            }
            return 0;
        }
        #endregion

        #region Cleanup
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (wallpaperTimer != null)
            {
                wallpaperTimer.Stop();
                wallpaperTimer.Dispose();
            }
            base.OnFormClosed(e);
        }
        #endregion

        #region Nested Classes
        public class WallpaperState
        {
            public string WallpaperName { get; set; }
            public bool IsSelected { get; set; }
        }
        #endregion

        #region Events
        public event Action<string> WallpaperChanged;
        #endregion        
    }
}
