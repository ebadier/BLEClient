using System.Runtime.Serialization;

namespace BLESDK.Model
{
    [DataContract]
    public class MovementValue
    {
        [DataMember]
        public double GyroX
        {
            get; set;
        }

        [DataMember]
        public double GyroY
        {
            get; set;
        }
        [DataMember]
        public double GyroZ
        {
            get; set;
        }
        [DataMember]
        public double AccX
        {
            get; set;
        }
        [DataMember]
        public double AccY
        {
            get; set;
        }
        [DataMember]
        public double AccZ
        {
            get; set;
        }
        [DataMember]
        public double MagX
        {
            get; set;
        }
        [DataMember]
        public double MagY
        {
            get; set;
        }
        [DataMember]
        public double MagZ
        {
            get; set;
        }

        [DataMember]
        public long Timestamp
        {
            get; set;
        }
    }
}
