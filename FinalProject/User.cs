namespace FinalProject
{
    public class User
    {
        private string _firstName { set; get; }
        private string _lastName { set; get; }
        private string _username { set; get; }
        private string _password { set; get; }
        public bool[,] _userSchedule { set; get; }
        public Group usersGroup { set; get; }


        public User()
        {
            bool[,] userSchedule =
                {
                    // The wall of lies.
                    // Monday
                    //09-1/2|1/2-10|10-1/2|1/2-11|11-1/2|1/2-12|12-1/2|1/2-01|01-1/2|1/2-02|02-1/2|1/2-03|03-1/2|1/2-04|04-1/2|1/2-05
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Tuesday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Wednesday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Thursday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Friday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false}
                };
            _userSchedule = userSchedule;
            usersGroup = new Group();
            this._firstName = "John";
            this._lastName = "Doe";
            this._username = "username";
            this._password = "password";
        }

        public User(string firstName, string lastName, bool[,] userSchedule, string username, string password, Group usersGroup)
        {
            this._userSchedule = userSchedule;
            this._firstName = firstName;
            this._lastName = lastName;
            _username = username;
            _password = password;
            this.usersGroup = usersGroup;
        }

        //This constructor is used when a user first creates an account
        public User(string firstName, string lastName, string username, string password)
        {

            bool[,] userSchedule =
    {
                    // The wall of lies.
                    // Monday
                    //09-1/2|1/2-10|10-1/2|1/2-11|11-1/2|1/2-12|12-1/2|1/2-01|01-1/2|1/2-02|02-1/2|1/2-03|03-1/2|1/2-04|04-1/2|1/2-05
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Tuesday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Wednesday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Thursday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                    // Friday
                    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false}
                };


            this._userSchedule = userSchedule;
            this._firstName = firstName;
            this._lastName = lastName;
            _username = username;
            _password = password;
            this.usersGroup = new Group();
        }
    }
}
