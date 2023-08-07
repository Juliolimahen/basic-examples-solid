namespace SingleResponsibilityPrinciple;

////Errado - Uma classe com várias responsabilidades
//internal class UserManager
//{

//        public void CreateUser(User user) { /* ... */ }
//        public void UpdateUser(User user) { /* ... */ }
//        public void DeleteUser(int userId) { /* ... */ }
//        public void SendEmail(User user) { /* ... */ }//não deveria estar aqui
//}

// Correto - Separação das responsabilidades

public class EmailSender
{
    public void SendEmail(User user)
    {
    }
}