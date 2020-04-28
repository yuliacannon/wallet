using System;

namespace BusinessCardLibrary
{
    public class BusinessCard
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Company { get; private set; }
        public string Position { get; private set; }
        public string Email { get; private set; }

        public BusinessCard(string name, string company, string position, string email)
        {
            this.Name = name;
            this.PhoneNumber = this.generatePhoneNumber();
            this.Company = company;
            this.Position = position;
            this.Email = email;
        }

        private string generatePhoneNumber()
        {
            return String.Format("{0:(###)-###-####}", new Random().Next(0, 999999999));
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\n" +
                $"Phone number: {this.PhoneNumber}\n" +
                $"Company: {this.Company}\n" +
                $"Position: {this.Position}\n" +
                $"Email: {this.Email}\n";
        }
    }
}
