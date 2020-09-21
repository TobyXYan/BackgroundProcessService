using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace NetService
{
    class ServiceHelper:IDisposable
    {
        public void Dispose()
        {
            UnRegisterChannels();
        }

        public bool StartService()
        {
            // Clean up ChannelServices before registration
            UnRegisterChannels();


            string confFile =@"C:\VS Pactices\RemoteService\bin\Config\StudentService.xml";
            try
            {
                RemotingConfiguration.Configure(confFile, false);

            }
            catch (RemotingException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }


            return true;

        }//HostThreadRun

        protected void UnRegisterChannels()
        {

            // UnRegister channels on stop service
            foreach (IChannel objChannel in ChannelServices.RegisteredChannels)
                ChannelServices.UnregisterChannel(objChannel);

        }//UnRegisterChannels

    }
}
