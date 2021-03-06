namespace NServiceBus.MessageRouting.RoutingSlips.Samples.StepB
{
    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://nservicebus.com/GenericHost.aspx
	*/

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.RoutingSlips();
            configuration.UsePersistence<InMemoryPersistence>();
        }
    }
}