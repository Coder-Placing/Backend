using TechTalk.SpecFlow;
using Xunit;

namespace RentalPeAPI.Steps
{
    [Binding]
    public class SpaceManagementSteps
    {
        [Given(@"an authenticated user with an ""(.*)"" role")]
        public void GivenAnAuthenticatedUserWithAnRole(string role)
        {
            // Simular token JWT de rol Owner
        }

        [Given(@"valid space details including dimensions, photos, and space type")]
        public void GivenValidSpaceDetails()
        {
            // Preparar CreateSpaceResource
        }

        [When(@"the user sends a POST request to create a space")]
        public void WhenTheUserSendsAPostRequestToCreateASpace()
        {
            // Ejecutar POST a /api/v1/spaces
        }

        [Then(@"the new space should be assigned to the user's account")]
        public void ThenTheNewSpaceShouldBeAssignedToTheUsersAccount()
        {
            // Validar en ISpaceRepository
        }

        [Given(@"an authenticated user who has registered (.*) spaces")]
        public void GivenAnAuthenticatedUserWhoHasRegisteredSpaces(int spaceCount)
        {
            // Sembrar 3 espacios en DB de prueba
        }

        [When(@"the user sends a GET request to their spaces endpoint")]
        public void WhenTheUserSendsAGetRequestToTheirSpacesEndpoint()
        {
            // Ejecutar GET a /api/v1/spaces
        }

        [Then(@"the response body should contain a list of (.*) spaces with their full details")]
        public void ThenTheResponseBodyShouldContainAListOfSpaces(int expectedCount)
        {
            // Validar que la lista devuelva 3 elementos
        }

        [Given(@"an authenticated user with an unpublished space")]
        public void GivenAnAuthenticatedUserWithAnUnpublishedSpace()
        {
            // Crear espacio con estado inactivo
        }

        [When(@"the user sends a PATCH request to publish the space")]
        public void WhenTheUserSendsAPatchRequestToPublishTheSpace()
        {
            // Ejecutar actualización
        }

        [Then(@"the space status should be updated to ""(.*)""")]
        public void ThenTheSpaceStatusShouldBeUpdatedTo(string expectedStatus)
        {
            // Validar que el enum SpaceStatus haya cambiado
        }

        [Then(@"the space should appear in the public public spaces list endpoint")]
        public void ThenTheSpaceShouldAppearInThePublicList()
        {
            // Validar en el query público
        }
    }
}