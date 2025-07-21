using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        LoginResult m_LoginResult;
        User m_LoggedInUser;
        AppSettings m_AppSettings;
        bool m_IsLoggedIn = false;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            pictureBoxFacebookLogo.Image = Properties.Resources.FacebookLogo;
            pictureBoxFacebookLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImage = Properties.Resources.FacebookBackground;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_AppSettings = AppSettings.LoadAppSettings();

            try
            {
                attemptLoginWithAccessToken();
            }
            catch (Exception ex)
            {
                loginWithoutAccessToken();
            }

            if (m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                loginWithoutAccessToken();
            }

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_IsLoggedIn = true;
            }

            if (m_IsLoggedIn)
            {
                openFormFeed();
            }
        }

        private void attemptLoginWithAccessToken()
        {
            if (m_AppSettings.LastAccessToken != null)
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
            }
        }

        private void loginWithoutAccessToken()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                m_AppSettings.FacebookPermissions.ToArray()
                //"email",
                //	"public_profile",
                //	"user_age_range",
                //	"user_birthday",
                //	"user_events",
                //	"user_friends",
                //	"user_gender",
                //	"user_hometown",
                //	"user_likes",
                //	"user_link",
                //	"user_location",
                //	"user_photos",
                //	"user_posts",
                //	"user_videos"
                /// add any relevant permissions
                );
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_IsLoggedIn = false;

            // Note to Project reviewer: Behaviour In Accordance to an answer given by from Professor Guy Ronen.
            // On logout, delete the access token.
            // By closing (x) the app without logging out, the access token is saved.
            m_AppSettings.LastAccessToken = string.Empty;
            m_AppSettings.SaveToFile();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_LoginResult != null && m_LoginResult.AccessToken != null)
            {
                m_AppSettings.SaveToFile();
            }
        }

        private void openFormFeed()
        {            
            FormFeed formFeed = new FormFeed(m_LoggedInUser);
			
            this.Hide();
			formFeed.FormClosed += (sender, e) => this.Show();
            formFeed.Show();
        }
    }
}
