using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.GreenPower;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.GreenPower
{
    /// <summary>
    /// Gp Sink Commissioning Mode value object class.
    ///
    /// Cluster: Green Power. Command ID 0x05 is sent TO the server.
    /// This command is a specific command used for the Green Power cluster.
    ///
    /// The GP Sink Commissioning Mode command is generated by a remote device, e.g. a
    /// Commissioning Tool, to request a sink to perform a commissioning action in a particular
    /// way.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class GpSinkCommissioningMode : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0021;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x05;

        /// <summary>
        /// Options command message field.
        /// </summary>
        public byte Options { get; set; }

        /// <summary>
        /// Gpm Addr For Security command message field.
        /// </summary>
        public ushort GpmAddrForSecurity { get; set; }

        /// <summary>
        /// Gpm Addr For Pairing command message field.
        /// </summary>
        public ushort GpmAddrForPairing { get; set; }

        /// <summary>
        /// Sink Endpoint command message field.
        /// </summary>
        public byte SinkEndpoint { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GpSinkCommissioningMode()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Options, ZclDataType.Get(DataType.BITMAP_8_BIT));
            serializer.Serialize(GpmAddrForSecurity, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(GpmAddrForPairing, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(SinkEndpoint, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Options = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
            GpmAddrForSecurity = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            GpmAddrForPairing = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            SinkEndpoint = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("GpSinkCommissioningMode [");
            builder.Append(base.ToString());
            builder.Append(", Options=");
            builder.Append(Options);
            builder.Append(", GpmAddrForSecurity=");
            builder.Append(GpmAddrForSecurity);
            builder.Append(", GpmAddrForPairing=");
            builder.Append(GpmAddrForPairing);
            builder.Append(", SinkEndpoint=");
            builder.Append(SinkEndpoint);
            builder.Append(']');

            return builder.ToString();
        }
    }
}