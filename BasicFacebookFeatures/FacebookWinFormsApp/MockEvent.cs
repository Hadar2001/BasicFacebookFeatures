using System;

namespace BasicFacebookFeatures
{
    // Comment to reviewer: this class is used to mock the event since we don't receive events from FACEBOOKAPI
    [Serializable]
    public class MockEvent
    {

        private static Random s_RandomImageIdGenerator = new Random();
		public string Id { get; set; } 

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int AttendingCount { get; set; }

        public int MaybeCount { get; set; }

        public string ImageUrl { get; set; }

		public MockEvent()
		{
            // random image every new Event generated but maintains image upon duplication
			ImageUrl = $"https://picsum.photos/id/{s_RandomImageIdGenerator.Next(1000)}/300"; 
		}

		public static MockEvent GetNewEvent()
        {
            return getNewMockEvent();
        }

        private static MockEvent getNewMockEvent()
        {
            int generatedId = s_RandomImageIdGenerator.Next(1000);

			return new MockEvent()
            {
                Id = Guid.NewGuid().ToString(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                Name = "New Event",
                Description = "New Event Description",
                Location = "New Event Location",
                AttendingCount = 0,
                MaybeCount = 0,               
			};
        }

        public MockEvent CloneWithNewId()
        {
            MockEvent clonedEvent = this.DeepClone();
            clonedEvent.Id = Guid.NewGuid().ToString();

            return clonedEvent;
		}
    }
}
