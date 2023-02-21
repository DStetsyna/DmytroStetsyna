using System.Xml.Serialization;

namespace Lista_3
{
    [XmlRoot(ElementName = "Staff")]
    public class Person
    {
        [XmlAttribute("PESEL")]
        public string Pesel { get; set; }
        [XmlAttribute("FirstName")]
        public string FirstName { get; set; }
        [XmlAttribute("LastName")]
        public string LastName { get; set; }
        [XmlAttribute("Age")]
        public string Age { get; set; }

        public Person()
        {

        }

        public Person(string Pesel, string FirstName, string LastName, string Age)
        {
            this.Pesel = Pesel;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public Person(Person osoba)
        {
            this.Pesel = osoba.Pesel;
            this.FirstName = osoba.FirstName;
            this.LastName = osoba.LastName;
            this.Age = osoba.Age;
        }
    }
}