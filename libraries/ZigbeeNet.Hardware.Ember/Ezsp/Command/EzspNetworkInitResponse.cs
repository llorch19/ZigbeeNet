//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " networkInit ".
    /// Resume network operation after a reboot. The node retains its original type. This should be
    /// called on startup whether or not the node was previously part of a network. EMBER_NOT_JOINED
    /// is returned if the node is not part of a network.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspNetworkInitResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 23;
        
        /// <summary>
        ///  An EmberStatus value that indicates one of the following: successful initialization,
        /// EMBER_NOT_JOINED if the node is not part of a network, or the reason for failure.
        /// </summary>
        private EmberStatus _status;
        
        public EzspNetworkInitResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        ///  An EmberStatus value that indicates one of the following: successful initialization,
        /// EMBER_NOT_JOINED if the node is not part of a network, or the reason for failure.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspNetworkInitResponse [status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
