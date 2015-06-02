using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
}

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
    public class HomePageModel : BaseViewModel
    {
        public override void InitializeProperties()
        {
            Title = "Welcome to the Cleveland .NET SIG";
            OnPropertyChanged(nameof(Title));
            Introduction =
                "This is a very simple application, that I wrote for my diabetic son, to keep track of his glucose readings, carbohydrate consumption, and insulin doses. I thought this would be a good demonstration of Xamarin.Forms to share a single code base across multiple device platforms.";
            OnPropertyChanged(nameof(Introduction));

            Events = FindAllEvents();
            OnPropertyChanged(nameof(Events));

        }

        private ICollection<Listable> FindAllEvents()
        {
            var events = new List<Listable>();
            events.AddRange(FindAllEvents<GlucoseCheck>());
            events.AddRange(FindAllEvents<Meal>());
            events.AddRange(FindAllEvents<InsulinDose>());
            events.AddRange(AddTestEvents());
            return events;
        }

        private IEnumerable<Listable> AddTestEvents()
        {
            var check = new GlucoseCheck()
            {
                Timestamp = DateTime.Now,
                Glucose = 100,
            };
            var meal = new Meal()
            {
                Timestamp = DateTime.Now,
                Name = "Dinner",
                Carbohydrates = 120,
            };
            var dose = new InsulinDose()
            {
                Timestamp = DateTime.Now,
                Insulin = 10,
            };
            return new Listable[] {check, meal, dose};
        }

        public IEnumerable<Listable> FindAllEvents<EntityType>()
            where EntityType : Entity, new()
        {
            var events = new List<Listable>();
            var repository = DependencyService.Get<Repository>();
            var folder = $"{typeof (EntityType).Name.ToLower()}";
            foreach (var file in repository.GetFiles(Path.Combine(repository.DefaultPath, folder)))
            {
                var entity = new EntityType();
                entity.Load(file);
                events.Add(entity);
            }
            return events;
        }

        public ICollection<Listable> Events { get; set; }
    }
}
