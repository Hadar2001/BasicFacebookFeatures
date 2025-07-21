using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;

namespace BasicFacebookFeatures
{
    public partial class FormMockEvents : Form
    {       
        private int m_LoadingLettersToShow;
        private readonly Timer r_LoadingTimer = new Timer();
        private StringBuilder m_LoadingStringBuilder;
        private ErrorProvider m_ErrorProvider;
        private ToolTip m_ToolTip;

        public FormMockEvents()
        {
            InitializeComponent();
            prepareHintsAndErrors();
            addEventRelatedSortingStrategies();
        }

        private void addEventRelatedSortingStrategies()
        {
            userControlSortableListBoxEvents.AddSortingStrategy<MockEvent>(new SortStrategyAlphabetical<MockEvent>("Alphabet", "Name"));
            userControlSortableListBoxEvents.AddSortingStrategy<MockEvent>(new SortStrategyByDateTimeField<MockEvent>("Sort By Start Date", "StartDate"));
        }

        private void prepareTimer()
        {
            r_LoadingTimer.Interval = 500;
            r_LoadingTimer.Tick += loadingAnimation;
            m_LoadingStringBuilder = new StringBuilder();
        }

        private void loadingAnimation(object sender, EventArgs e)
        {
            m_LoadingLettersToShow = (m_LoadingLettersToShow + 1) % 7;
            m_LoadingStringBuilder.Clear();
            m_LoadingStringBuilder.Append("Loading");
            userControlSortableListBoxEvents.Title = m_LoadingStringBuilder.ToString(0, m_LoadingLettersToShow + 1);
		}

        private void stopLoadingAnimation()
        {
            r_LoadingTimer.Stop();
            userControlSortableListBoxEvents.Title = "Events";
        }
        private void buttonGetEvents_Click(object sender, EventArgs e)
        {                   
            prepareTimer();
            r_LoadingTimer.Start();          
            getEvents();
            stopLoadingAnimation();
        }

        private void getEvents()
        {
            IEnumerable<MockEvent> events = DataCacheManager.SingletonInstance.GetMockEvents();
            
            listEventsBindingSource.DataSource = events;
            userControlSortableListBoxEvents.DataSource = listEventsBindingSource;
		    userControlSortableListBoxEvents.SelectedIndexChanged += userControlSortableListBoxEvents_SelectedIndexChanged; ;
			userControlSortableListBoxEvents.DisplayMember = "Name";
            setButtonsToViewMode();
            userControlSortableListBoxEvents.ViewAvailableSortingStrategies<MockEvent>();			
		}

		private void userControlSortableListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
		{
			MockEvent selectedEvent = userControlSortableListBoxEvents.SelectedItem as MockEvent;

			if (selectedEvent != null && !string.IsNullOrEmpty(selectedEvent.ImageUrl))
			{
				try
				{
					this.pictureBoxEvent.LoadAsync(selectedEvent.ImageUrl);
				}
				catch (Exception ex)
				{
					this.pictureBoxEvent.Image = null;
				}
			}
			else
			{
				this.pictureBoxEvent.Image = null;
			}
		}

		private void buttonDuplicateSelectedEvent_Click(object sender, EventArgs e)
        {
			FormRepeatEvent formRepeatEvent = new FormRepeatEvent();
			MockEvent eventToDuplicate = listEventsBindingSource.Current as MockEvent;
			int repetitions;
            int repetitionInterval;            

            if (formRepeatEvent.ShowDialog() == DialogResult.OK && eventToDuplicate != null)
            {
                repetitions = formRepeatEvent.Repetitions;
                repetitionInterval = formRepeatEvent.IntervalValue;

                for (int i = 0; i < repetitions; i++)
                {
                    createRepeatedEvent(repetitionInterval, eventToDuplicate, i);
                }
            }
        }

        private void createRepeatedEvent(int i_RepetitionsInterval, MockEvent i_PrototypeMockEvent, int i_RepetitionIndex)
        {
            MockEvent copyOfPrototype = i_PrototypeMockEvent.CloneWithNewId();

			copyOfPrototype.StartDate = copyOfPrototype.StartDate?.AddDays(i_RepetitionsInterval * (i_RepetitionIndex + 1));
            copyOfPrototype.EndDate = copyOfPrototype.EndDate?.AddDays(i_RepetitionsInterval * (i_RepetitionIndex + 1));
            listEventsBindingSource.Add(copyOfPrototype);
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            MockEvent mockEvent = userControlSortableListBoxEvents.SelectedItem as MockEvent;

            if (mockEvent != null)
            {
                listEventsBindingSource.Remove(mockEvent);
            }
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            MockEvent newEvent = MockEvent.GetNewEvent();

            listEventsBindingSource.Add(newEvent);
            listEventsBindingSource.Position = listEventsBindingSource.IndexOf(newEvent);
        }

        private void setButtonsToViewMode()
        {
            buttonCreateEvent.Enabled = true;
            buttonDeleteEvent.Enabled = true;
            buttonSaveEvents.Enabled = true;
            buttonDuplicateSelectedEvent.Enabled = true;
            buttonGetEvents.Enabled = true;
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                m_ErrorProvider.SetError(nameTextBox, "Name cannot be empty.");
                e.Cancel = true;
            }
            else
            {
                m_ErrorProvider.SetError(nameTextBox, string.Empty);
            }
        }

        private void endDateDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (endDateDateTimePicker.Value < startDateDateTimePicker.Value)
            {
                m_ErrorProvider.SetError(endDateDateTimePicker, "End date must be after start date.");
                e.Cancel = true;
            }
            else
            {
                m_ErrorProvider.SetError(endDateDateTimePicker, string.Empty);
            }
        }

        private void prepareHintsAndErrors()
        {
            m_ErrorProvider = new ErrorProvider();
            m_ToolTip = new ToolTip();

            m_ToolTip.ToolTipIcon = ToolTipIcon.Info;
            m_ToolTip.ToolTipTitle = "Button Info";
            m_ToolTip.SetToolTip(buttonDeleteEvent, "This deletes the currently selected event.");
            m_ToolTip.SetToolTip(buttonSaveEvents, "Click to save the changes you've made.");
            m_ToolTip.SetToolTip(buttonDuplicateSelectedEvent, "This Opens the duplication Dialog");
        }

        private void buttonSaveEvents_Click(object sender, EventArgs e)
        {
            try
            {
                DataCacheManager.SingletonInstance.SaveEventsToXmlFile<MockEvent>(
                    Path.Combine(Properties.Resources.DocumentsFolderPath,Properties.Resources.events), listEventsBindingSource.List as List<MockEvent>);       
                                
                userControlSortableListBoxEvents.DataSource = null;
			}
            catch (Exception ex)
            {
                throw new Exception("Failed to load mock events", ex);
            }
            finally
            {
                listEventsBindingSource.Clear();
            }
        }
	}
}