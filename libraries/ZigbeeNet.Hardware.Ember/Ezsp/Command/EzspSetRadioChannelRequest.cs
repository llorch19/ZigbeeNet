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
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " setRadioChannel ".
    /// Sets the channel to use for sending and receiving messages. For a list of available radio
    /// channels, see the technical specification for the RF communication module in your
    /// Developer Kit.
    /// * <p>
    /// * <b>Note:</b> Care should be taken when using this API, as all devices on a network must use
    /// the same channel.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspSetRadioChannelRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 154;
        
        /// <summary>
        ///  Desired radio channel.
        /// </summary>
        private int _channel;
        
        private EzspSerializer _serializer;
        
        public EzspSetRadioChannelRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The channel to set as <see cref="uint8_t"/> </summary>
        public void SetChannel(int channel)
        {
            _channel = channel;
        }
        
        /// <summary>
        ///  Desired radio channel.
        /// Return the channel as <see cref="System.Int32"/>
        /// </summary>
        public int GetChannel()
        {
            return _channel;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeUInt8(_channel);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspSetRadioChannelRequest [channel=");
            builder.Append(_channel);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
