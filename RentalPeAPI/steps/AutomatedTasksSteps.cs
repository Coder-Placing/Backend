using TechTalk.SpecFlow;
using Xunit;

namespace RentalPeAPI.Steps
{
    [Binding]
    public class AutomatedTasksSteps
    {
        [Given(@"an authenticated user managing a registered IoT device")]
        public void GivenAnAuthenticatedUserManagingARegisteredIotDevice()
        {
            // Preparar datos de IoTDevice
        }

        [Given(@"the user provides valid task details including a monitoring schedule and task objective")]
        public void GivenTheUserProvidesValidTaskDetails()
        {
            // Preparar CreateWorkItemCommand
        }

        [When(@"the user sends a POST request to the create work item endpoint")]
        public void WhenTheUserSendsAPostRequestToTheCreateWorkItemEndpoint()
        {
            // Enviar POST a WorkItemController
        }

        [Then(@"the task should be correctly scheduled in the database")]
        public void ThenTheTaskShouldBeCorrectlyScheduledInTheDatabase()
        {
            // Validar que se guardó en IWorkItemRepository
        }
    }
}