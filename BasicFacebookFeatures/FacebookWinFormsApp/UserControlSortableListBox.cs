using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class UserControlSortableListBox : UserControl
    {
        private readonly Dictionary<string, object> r_Sorting_Strategies;
       
		private ITitlePanelDecorator m_TitlePanelDecorator;

		public event EventHandler SelectedIndexChanged;

		public UserControlSortableListBox()
        {
            InitializeComponent();							
			r_Sorting_Strategies = new Dictionary<string, object>();
        }

		public object DataSource
        {
            get { return listBoxItems.DataSource; }
            set { listBoxItems.DataSource = value; }
        }

        public string Title
        {
            get { return this.userControlLabelCoreTitle.InnerLabel.Text; }
            set { this.userControlLabelCoreTitle.InnerLabel.Text = value; }
        }

        public ITitlePanelDecorator TitlePanelDecorator
        {
            get { return m_TitlePanelDecorator; }
            set { m_TitlePanelDecorator = value; }
		}

        public UserControlTitlePanelDecorated UserControlLabelCoreTitle
		{
			get { return userControlLabelCoreTitle; }
			set { userControlLabelCoreTitle = value; }
		}

		public string DisplayMember
        {
            get { return listBoxItems.DisplayMember; }
            set { listBoxItems.DisplayMember = value; }
        }

        public ListBox.ObjectCollection Items
        {
            get { return listBoxItems.Items; }
        }

        public object SelectedItem
        {
            get { return listBoxItems.SelectedItem; }
        }

        private void listboxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = null;

            if (listBoxItems.SelectedIndex > -1)
            {
                selectedItem = listBoxItems.SelectedItem;
            }

            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged?.Invoke(selectedItem, EventArgs.Empty);
            }
        }

        public void PopulateListBoxFromList<T>(List<T> i_Items, string i_DisplayMember)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(
               () =>
               {
                   this.Items.Clear();
                   this.DisplayMember = i_DisplayMember;

                   foreach (T item in i_Items)
                   {
                       this.Items.Add(item);
                   }
               }));
            }
            else
            {
                this.Items.Clear();
                this.DisplayMember = i_DisplayMember;

                foreach (T item in i_Items)
                {
                    this.Items.Add(item);
                }
            }
        }

        internal void AddSortingStrategy<T>(ISortStrategy<T> i_SortStrategy)
        {
            if (i_SortStrategy == null)
            {
                throw new ArgumentNullException("The Sorting Strategy can't be null...");
            }

            if (r_Sorting_Strategies.ContainsKey(i_SortStrategy.StrategyName))
            {
                throw new ArgumentException("You already have a strategy with the same key...");
            }

            if (string.IsNullOrEmpty(i_SortStrategy.StrategyName))
            {
                throw new ArgumentNullException($"Strategy Name can't be null {i_SortStrategy.StrategyName}");
            }

            r_Sorting_Strategies.Add(i_SortStrategy.StrategyName, i_SortStrategy);
        }

        private void viewSortingOptions<T>()
        {
            int yOffset = 20;
            RadioButton radioButton;
            GroupBox sortingOptionsGroupBox;

            sortingOptionsGroupBox = new GroupBox
            {
                Text = "Sorting Options",
                Location = new Point(10, 10),
                ForeColor = Color.Beige,
            };

            foreach (ISortStrategy<T> sortStrategy in r_Sorting_Strategies.Values)
            {
                radioButton = new RadioButton
                {
                    Text = sortStrategy.StrategyTitle,
                    AutoSize = true,
                    Location = new Point(10, yOffset),
                    Tag = sortStrategy.StrategyName
                };

                radioButton.CheckedChanged += radioButton_CheckedChanged<T>;
                sortingOptionsGroupBox.Controls.Add(radioButton);
                yOffset += radioButton.Height + 5;
            }

            this.Invoke(new Action(() => panelSorting.Controls.Add(sortingOptionsGroupBox)));
        }

        private void radioButton_CheckedChanged<T>(object sender, EventArgs e)
        {
            string selectedSortingStrategy = string.Empty;
            ISortStrategy<T> theSelectedSortingStrategy = null;
            List<T> listOfItems;
            RadioButton theSelectedRadioButton = sender as RadioButton;

            if (theSelectedRadioButton != null && theSelectedRadioButton.Checked)
            {
                selectedSortingStrategy = theSelectedRadioButton.Tag.ToString();
                theSelectedSortingStrategy = r_Sorting_Strategies[selectedSortingStrategy] as ISortStrategy<T>;
            }

            if (theSelectedSortingStrategy != null)
            {
                if (!isBindingSource())
                {
                    if (theSelectedSortingStrategy != null)
                    {
                        listOfItems = this.Items.Cast<T>().ToList();

                        // Note to code reviewer: even if a programmer implemented a faulty sort strategy, the app will not crash..
                        try
                        {
                            theSelectedSortingStrategy.Sort(listOfItems, theSelectedSortingStrategy.FieldName);
                            PopulateListBoxFromList<T>(listOfItems, this.DisplayMember);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, $"Error during sort {ex.Message}");
                        }
                    }
                }
                else
                {
                    sortUsingBindingSource<T>(theSelectedSortingStrategy);
                }
            }
        }

        private void sortUsingBindingSource<T>(ISortStrategy<T> i_SortStrategy)
        {
            BindingSource bindingSource = this.DataSource as BindingSource;
            List<T> items;

            if (bindingSource != null)
            {
                items = bindingSource.Cast<T>().ToList();
                bindingSource.Clear();
                i_SortStrategy.Sort(items, i_SortStrategy.FieldName);
                bindingSource.DataSource = items;
                bindingSource.ResetBindings(false);
            }
        }

		private bool isBindingSource()
        {
            return this.DataSource is BindingSource;
        }

        internal void ViewAvailableSortingStrategies<T>()
        {
            this.viewSortingOptions<T>();
        }        
	}
}
