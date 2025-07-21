using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public partial class FormFeed : Form
    {
        private Menu m_MenuForm;
        private User m_LoggedInUser;
		
		public FormFeed(User i_LoggedInUser)
		{
			InitializeComponent();
			m_LoggedInUser = i_LoggedInUser;
			m_MenuForm = new Menu("Categories Menu");
			populateMenu();
			prepareImages();
			prepareSortingOptions();						
			prepareDecorations();
			MenuRenderer.Render(m_MenuForm, flowLayoutPanelMenu);
		}

		private void prepareImages()
		{
			this.panelAlbums.BackgroundImage = Properties.Resources.FacebookPic;
			this.panelAlbums.BackgroundImageLayout = ImageLayout.Stretch;
			this.panelFriends.BackgroundImage = Properties.Resources.FacebookPic;
			this.panelFriends.BackgroundImageLayout = ImageLayout.Stretch;
			this.panelLikedPages.BackgroundImage = Properties.Resources.FacebookPic;
			this.panelLikedPages.BackgroundImageLayout = ImageLayout.Stretch;
			this.panelPosts.BackgroundImage = Properties.Resources.FacebookPic;
			this.panelPosts.BackgroundImageLayout = ImageLayout.Stretch;
		}

		private void prepareSortingOptions()
		{
			ISortStrategy<Post> postAlphabetSortStrategy = new SortStrategyAlphabetical<Post>("Alphabet", "Message");
			ISortStrategy<Post> postLengthSortStrategy = new SortStrategyStringLength<Post>("Length", "Message");
			ISortStrategy<Album> albumAlphabeticalSortStrategy = new SortStrategyAlphabetical<Album>("Alphabet", "Name");
			ISortStrategy<Album> sortByUpdateTime = new SortStrategyByDateTimeField<Album>("ByDateTime", "CreatedTime");
			ISortStrategy<Event> eventSortStrategy = new SortStrategyAlphabetical<Event>("Alphabet", "Name");
			ISortStrategy<Page> pageSortStrategy = new SortStrategyAlphabetical<Page>("Alphabet", "Name");			

			userControlSortableListBoxAlbums.AddSortingStrategy(albumAlphabeticalSortStrategy);
			userControlSortableListBoxPosts.AddSortingStrategy(postAlphabetSortStrategy);
			userControlSortableListBoxPosts.AddSortingStrategy(postLengthSortStrategy);
			userControlSortableListBoxAlbums.AddSortingStrategy(sortByUpdateTime);
			userControlSortableListBoxLikedPages.AddSortingStrategy(pageSortStrategy);		
		}

        private void prepareDecorations()
        {
			UserControlTitlePanelDecorated baseAlbums = this.userControlSortableListBoxAlbums.UserControlLabelCoreTitle;
			UserControlTitlePanelDecorated basePosts = this.userControlSortableListBoxPosts.UserControlLabelCoreTitle;
			UserControlTitlePanelDecorated baseLikedPages = this.userControlSortableListBoxLikedPages.UserControlLabelCoreTitle;
			UserControlTitlePanelDecorated baseFriends = this.userControlSortableListBoxFriends.UserControlLabelCoreTitle;

			ITitlePanelDecorator outerMostAlbumsDecorator = new TitlePanelMovingTextDecorator(new TitlePanelDimmingPanelDecorator(new TitlePanelFlashingDecorator(baseAlbums)));
			ITitlePanelDecorator outerMostPostsDecorator = new TitlePanelMovingTextDecorator(new TitlePanelDimmingPanelDecorator(new TitlePanelFlashingDecorator(basePosts)));
			ITitlePanelDecorator outerMostLikedPagesDecorator = new TitlePanelMovingTextDecorator(new TitlePanelDimmingPanelDecorator(new TitlePanelFlashingDecorator(baseLikedPages)));
			ITitlePanelDecorator outerMostFriendsDecorator = new TitlePanelMovingTextDecorator(new TitlePanelDimmingPanelDecorator(new TitlePanelFlashingDecorator(baseFriends)));

			DecorationsHelper.SetUpDecoration(
				userControlSortableListBoxAlbums,
				outerMostAlbumsDecorator,
				title => title.PanelSurrounding.MouseEnter += (s, e) => title.RaiseDecorationRequested(),
				title => title.PanelSurrounding.MouseLeave += (s, e) => title.RaiseDecorationStopRequested()
			);

			DecorationsHelper.SetUpDecoration(
				userControlSortableListBoxPosts,
				outerMostPostsDecorator,
				title => title.PanelSurrounding.MouseEnter += (s, e) => title.RaiseDecorationRequested(),
				title => title.PanelSurrounding.MouseLeave += (s, e) => title.RaiseDecorationStopRequested()
			);

			DecorationsHelper.SetUpDecoration(
				userControlSortableListBoxLikedPages,
				outerMostLikedPagesDecorator,
				title => title.PanelSurrounding.MouseEnter += (s, e) => title.RaiseDecorationRequested(),
				title => title.PanelSurrounding.MouseLeave += (s, e) => title.RaiseDecorationStopRequested()
			);

			DecorationsHelper.SetUpDecoration(
				userControlSortableListBoxFriends,
				outerMostFriendsDecorator,
				title => title.PanelSurrounding.MouseEnter += (s, e) => title.RaiseDecorationRequested(),
				title => title.PanelSurrounding.MouseLeave += (s, e) => title.RaiseDecorationStopRequested()
			);
		}

		private void populateMenu()
		{
			m_MenuForm = new Menu("Categories Menu");

			m_MenuForm.AddMenuItem(new MenuItem("Get All", getAll));
			m_MenuForm.AddMenuItem(new MenuItem("Posts", getPosts));
			m_MenuForm.AddMenuItem(new MenuItem("Albums", getAlbums));
			m_MenuForm.AddMenuItem(new MenuItem("Events", getEvents));
			m_MenuForm.AddMenuItem(new MenuItem("Liked Pages", getLikedPages));
			m_MenuForm.AddMenuItem(new MenuItem("Friends", getFriends));
			m_MenuForm.AddMenuItem(new MenuItem("Show Statistics", goToSummaryForm));
		}

        private void goToSummaryForm()
        {
            
            FormUserActivityChart formUserActivityChart = new FormUserActivityChart(m_LoggedInUser);
			this.Hide();

			formUserActivityChart.FormClosed += (sender, e) => this.Show();
            formUserActivityChart.Show();
        }

        private void getAll()
        {           			
            new Thread(() =>
            {
                getPosts();
                getAlbums();
                getLikedPages();
                getFriends();
            }).Start();                        
		}

        private void getFriends()
        {
			new Thread(() =>
			{
				FacebookObjectCollection<User> friends = DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<User>("friends");
					
				this.Invoke(new Action(() =>  {
					userBindingSource.DataSource = friends;
					userControlSortableListBoxFriends.DisplayMember = "Name";
					userControlSortableListBoxFriends.DataSource = userBindingSource;
                    
				}));				
			}).Start();			

            userControlSortableListBoxFriends.ViewAvailableSortingStrategies<User>();
		}
        private void getPosts()
        {
			new Thread(() => 
            {
				FacebookObjectCollection<Post> posts = DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Post>("posts");                
				
                this.Invoke(new Action(() =>
                {
					postBindingSource.DataSource = posts;
					userControlSortableListBoxPosts.DisplayMember = "Message";
                    userControlSortableListBoxPosts.DataSource = postBindingSource;
                }));				
			}).Start();

			userControlSortableListBoxPosts.ViewAvailableSortingStrategies<Post>();
		}

        private void getAlbums()
        {
            new Thread( () =>
            {
                FacebookObjectCollection<Album> albums = DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Album>("albums");
								
                this.Invoke(new Action(() =>
                {
					albumBindingSource.DataSource = albums;
					userControlSortableListBoxAlbums.DisplayMember = "Name";
                    userControlSortableListBoxAlbums.DataSource = albumBindingSource;
                }));
                
            }).Start();

			userControlSortableListBoxAlbums.ViewAvailableSortingStrategies<Album>();
		}

        private void getEvents()
        {
            // Note to reviewer: Due to limitations in fetching events from the facebook api,
            // we implemented event management using an XML file as a mock data store.
            // This was done in a separate form, which also includes extended functionality
            // using the Prototype design pattern.
            FormMockEvents mockEvents = new FormMockEvents();

            mockEvents.ShowDialog();
            mockEvents.FormClosed += (sender, e) => this.Show();
		}

        private void getLikedPages()
        {
			new Thread(() =>
			{
				FacebookObjectCollection<Page> likedPages = DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Page>("likes");
				
                this.Invoke(new Action(() =>
                {
					pageBindingSource.DataSource = likedPages;
					userControlSortableListBoxLikedPages.DisplayMember = "Name";
                    userControlSortableListBoxLikedPages.DataSource = pageBindingSource;
                }));
			}).Start();

			userControlSortableListBoxLikedPages.ViewAvailableSortingStrategies<Page>();
		}
    }
}
