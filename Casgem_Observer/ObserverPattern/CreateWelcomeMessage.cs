using Casgem_Observer.DAL;

namespace Casgem_Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public void CreateNewUser(AppUser appUSer)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUSer.Name + " " + appUSer.Surname,
                Content = "Dergi bültenimize abone olduğunuz için teşekkür ederiz, hoş geldiniz"
            });
            context.SaveChanges();
        }

    }
}
