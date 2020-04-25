namespace buoi2.Ass5
{
    public class phoneNumber
    {
        public string name;
        public string phone;
        public string newPhone;

        public phoneNumber()
        {
        }

        public phoneNumber(string name, string phone, string newPhone)
        {
            this.name = name;
            this.phone = phone;
            this.newPhone = newPhone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string NewPhone
        {
            get => newPhone;
            set => newPhone = value;
        }
    }
}