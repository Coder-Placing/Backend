using TechTalk.SpecFlow;
using Xunit;

namespace RentalPeAPI.Steps
{
    [Binding]
    public class UserIdentitySteps
    {
        [Given(@"the user provides valid registration details with email ""(.*)"", password ""(.*)"", and role ""(.*)""")]
        public void GivenTheUserProvidesValidRegistrationDetails(string email, string password, string role)
        {
            // Aquí irá la configuración de los datos (ej: instanciar tu UserDto)
        }

        [When(@"the user sends a POST request to the registration endpoint")]
        public void WhenTheUserSendsAPostRequestToTheRegistrationEndpoint()
        {
            // Aquí irá la llamada a tu controlador o cliente HTTP
        }

        [Then(@"the response status code should be (.*) Created")]
        public void ThenTheResponseStatusCodeShouldBeCreated(int statusCode)
        {
            // Aquí validas el código HTTP
        }

        [Then(@"the user should be saved in the database with the ""(.*)"" role")]
        public void ThenTheUserShouldBeSavedInTheDatabaseWithTheRole(string role)
        {
            // Aquí validas en tu repositorio si el usuario se guardó
        }

        [Given(@"a user with the email ""(.*)"" already exists in the system")]
        public void GivenAUserWithTheEmailAlreadyExistsInTheSystem(string email)
        {
            // Simular un usuario existente
        }

        [When(@"the user sends a POST request to the registration endpoint with email ""(.*)""")]
        public void WhenTheUserSendsAPostRequestToTheRegistrationEndpointWithEmail(string email)
        {
            // Intentar registrar de nuevo
        }

        [Then(@"the response status code should be (.*) Bad Request")]
        public void ThenTheResponseStatusCodeShouldBeBadRequest(int statusCode)
        {
            // Validar error 400
        }

        [Then(@"the response should contain an error message indicating the email is already in use")]
        public void ThenTheResponseShouldContainAnErrorMessage()
        {
            // Validar el texto del error
        }

        [Given(@"a registered user with email ""(.*)"" and password ""(.*)""")]
        public void GivenARegisteredUserWithEmailAndPassword(string email, string password)
        {
            // Preparar credenciales válidas
        }

        [When(@"the user sends a POST request to the login endpoint with valid credentials")]
        public void WhenTheUserSendsAPostRequestToTheLoginEndpointWithValidCredentials()
        {
            // Enviar petición de login
        }

        [Then(@"the response status code should be (.*) OK")]
        public void ThenTheResponseStatusCodeShouldBeOK(int statusCode)
        {
            // Validar 200 OK
        }

        [Then(@"the response body should contain a valid JWT token")]
        public void ThenTheResponseBodyShouldContainAValidJwtToken()
        {
            // Validar que el token no sea nulo
        }

        [Given(@"a registered user with email ""(.*)""")]
        public void GivenARegisteredUserWithEmail(string email)
        {
            // Preparar usuario
        }

        [When(@"the user sends a POST request to the login endpoint with an incorrect password")]
        public void WhenTheUserSendsAPostRequestToTheLoginEndpointWithAnIncorrectPassword()
        {
            // Enviar petición con mala contraseña
        }

        [Then(@"the response status code should be (.*) Unauthorized")]
        public void ThenTheResponseStatusCodeShouldBeUnauthorized(int statusCode)
        {
            // Validar 401
        }

        [Then(@"the response should contain an error message about invalid credentials")]
        public void ThenTheResponseShouldContainAnErrorMessageAboutInvalidCredentials()
        {
            // Validar texto de credenciales inválidas
        }
    }
}