namespace SingleResponsibilityPrinciple;


//namespace SingleResponsibilityPrinciple;

////Errado - Uma classe com várias responsabilidades
//internal class UserManager
//{

//        public void CreateUser(User user) { /* ... */ }
//        public void UpdateUser(User user) { /* ... */ }
//        public void DeleteUser(int userId) { /* ... */ }
//        public void SendEmail(User user) { /* ... */ }//não deveria estar aqui
//}

// Correto - Separação das responsabilidades
public class User
{
    public int Id { get; set; }
    public int Name { get; set; }
}