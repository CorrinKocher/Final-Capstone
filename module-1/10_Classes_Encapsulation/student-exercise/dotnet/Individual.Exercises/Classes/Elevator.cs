namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public Elevator(int numberOfLevels)
        {
            this.CurrentLevel = 1;
            this.DoorIsOpen = false;
            this.NumberOfLevels = numberOfLevels;
        }
       public int CurrentLevel { get; private set; }

        public int NumberOfLevels { get;  }
        

        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            if(this.DoorIsOpen == false)
            {
                this.DoorIsOpen = true;
            }
        }

        public void CloseDoor()
        {
            if(this.DoorIsOpen == true)
            {
                this.DoorIsOpen = false;
            }
        }
        public void GoUp(int desiredFloor)
        {
            if(this.DoorIsOpen == false && CurrentLevel < NumberOfLevels)
            {
                    CurrentLevel = desiredFloor;
                
            }
        }
        public void GoDown(int desiredFloor)
        {
            if(this.DoorIsOpen == false && CurrentLevel > 1)
            {
                    CurrentLevel = desiredFloor;
                
            }
        }
    }

}
