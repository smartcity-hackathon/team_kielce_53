using System.Collections.Generic;
using VolunteeringApp.Models;

namespace VolunteeringApp.Repositories
{
    public static class Repository
    {
        private const string Name = "repo";

        public static bool IsInitialized { get; private set; }

        public static List<UserModel> Users { get; }

        public static List<ClassifiedModel> Classifieds { get; }

        public static List<OrganizationModel> Organizations { get; }

        public static List<ClassifiedDetailsModel> ClassifiedDetails { get; }

        public static List<AcceptedClassifiedModel> AcceptedClassified { get; }

        public static List<StatisticModel> Statistics { get; }


        static Repository()
        {
            IsInitialized = false;

            Users = new List<UserModel>();
            Classifieds = new List<ClassifiedModel>();
            Organizations = new List<OrganizationModel>();
            ClassifiedDetails = new List<ClassifiedDetailsModel>();
            AcceptedClassified = new List<AcceptedClassifiedModel>();
            Statistics = new List<StatisticModel>();
        }

        public static void Load()
        {
            InitUsers();
            InitClassifieds();
            InitOrganizations();
            InitClassifiedDetails();

            IsInitialized = true;
        }

        private static void InitUsers()
        {
            Users.Add(new UserModel
            {
                Id = 1,
                Email = "admin",
                Password = "hackathon",
                IsAdmin = true
            });
        }

        private static void InitClassifieds()
        {
            Classifieds.Add(new ClassifiedModel
            {
                Id  = 1,
                OrganizationId = 1,
                ClassifiedDetailsId = 1,
                Subtitle = "Zbiórka zabawek",
                StartDate = "15-06-2018",
                EndDate = "17-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 2,
                OrganizationId = 2,
                ClassifiedDetailsId = 2,
                Subtitle = "Segregacja książek",
                StartDate = "16-06-2018",
                EndDate = "17-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 3,
                OrganizationId = 3,
                ClassifiedDetailsId = 3,
                Subtitle = "Pomoc przy lekcjach",
                StartDate = "27-06-2018",
                EndDate = "27-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 4,
                OrganizationId = 4,
                ClassifiedDetailsId = 4,
                Subtitle = "Wieczór bajkowy",
                StartDate = "18-06-2018",
                EndDate = "18-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 5,
                OrganizationId = 5,
                ClassifiedDetailsId = 5,
                Subtitle = "Sprzątanie",
                StartDate = "28-06-2018",
                EndDate = "29-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 6,
                OrganizationId = 6,
                ClassifiedDetailsId = 6,
                Subtitle = "Pomoc przy pakowaniu paczek",
                StartDate = "23-06-2018",
                EndDate = "25-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 7,
                OrganizationId = 7,
                ClassifiedDetailsId = 7,
                Subtitle = "Układanie książek",
                StartDate = "20-06-2018",
                EndDate = "20-06-2018"
            });

            Classifieds.Add(new ClassifiedModel
            {
                Id = 8,
                OrganizationId = 5,
                ClassifiedDetailsId = 8,
                Subtitle = "Wyprowadzanie psów",
                StartDate = "20-06-2018",
                EndDate = "21-06-2018"
            });

        }

        private static void InitOrganizations()
        {
            Organizations.Add(new OrganizationModel
            {
                Id = 1,
                Name = "Dom dziecka \"Dobra Chata\"",
                Address = "Kielce, ul. Sandomierska 126",
                Phone = "41 365 76 53"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 2,
                Name = "Miejska Biblioteka Publiczna Filia nr 4",
                Address = "Kielce, ul. Górnicza 64",
                Phone = "41 500 64 66"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 3,
                Name = "Świetlica Wspierająco-Integrująca w Kielcach",
                Address = "Kielce, ul. Żeromskiego 13a",
                Phone = "41 230 01 00"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 4,
                Name = "Miejska Biblioteka Publiczna Filia nr 50",
                Address = "Kielce, ul. Zagórska 60",
                Phone = "41 215 61 55"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 5,
                Name = "Schronisko dla zwierząt",
                Address = "Kielce",
                Phone = "41 215 61 55"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 6,
                Name = "Szlachetna paczka",
                Address = "Kielce, ul. Zapolskiej 14d",
                Phone = "517 667 323"
            });

            Organizations.Add(new OrganizationModel
            {
                Id = 7,
                Name = "Biblioteka Publiczna Filia nr 13",
                Address = "Kielce, ul. Naruszewicza 25 14d",
                Phone = "41 589 25 01"
            });
        }

        private static void InitClassifiedDetails()
        {
            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 1,
                Description = "Ogłaszamy zbiorkę zabawek dla dzieci od dnia 15-06-2018 do 17-06-2018. Zabawki zadbane w dobrym stanie dla dzieci w wieku 0-10 lat." +
                              " Książki również są mile widziane. Darowizny można przynosić do naszej placówki w godz. 8-18 pon-piątku."
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 2,
                Description = "W każdy piątek po godz. 18 układanie książek. Wszystkich chętnych zapraszamy. Dziękujemy!"
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 3,
                Description = "Poszukujemy osoby powyżej 16 roku życia do pomocy przy odrabianiu pracy domowej dzieciom w wieku 6-12 lat od pon-piątku od godz. 14:00-18:00." +
                              "Serdecznie zapraszamy i dziękujemy!"
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 4,
                Description = "W każdy poniedziałek w godz. 15-18 odbędą się \"Poniedziałki z braćmi Grimm dla dzieci\" od lat 4 do lat 10. Poszukujemy do czytania kilku osób." +
                              " Jeśli jesteś chętny zapisz się."
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 5,
                Description = "W poniedziałek w godz. 15-20 odbędzie się sprzątanie kojców w naszym schronisku. Wszystkich chętnych serdecznie zapraszamy."
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 6,
                Description = "Poszukujemy ludzi dobrych serc do pomocy przy pakowaniu paczek na święta. Zapraszamy codziennie od godz. 8:00 do 21:30. Wszyskich chętnych zapraszamy."
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 7,
                Description = "Poszukujemy chętnych osób w każdą niedzielęod godz. 10 do 15 w celu ułożenia książek. Zgłoszenia prosimy składać telefonicznie lub za pomocą aplikacji"
            });

            ClassifiedDetails.Add(new ClassifiedDetailsModel
            {
                Id = 8,
                Description = "W każdy wtorek w godz. 18-20 odbywa się wyprowadzanie zwierzaków. Wszystkich chętnych serdecznie zapraszamy."
            });

        }
    }
}