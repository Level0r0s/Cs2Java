//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class DatagramPacket : global::java.lang.Object
    {
        public DatagramPacket(byte[] prm1, int prm2, SocketAddress prm3){}
        public DatagramPacket(byte[] prm1, int prm2, InetAddress prm3, int prm4){}
        public DatagramPacket(byte[] prm1, int prm2, int prm3, SocketAddress prm4){}
        public DatagramPacket(byte[] prm1, int prm2, int prm3){}
        public DatagramPacket(byte[] prm1, int prm2){}
        public DatagramPacket(byte[] prm1, int prm2, int prm3, InetAddress prm4, int prm5){}
        public virtual void setAddress(InetAddress prm1){}
        public virtual void setData(byte[] prm1){}
        public virtual void setData(byte[] prm1, int prm2, int prm3){}
        public virtual void setLength(int prm1){}
        public virtual void setPort(int prm1){}
        public virtual void setSocketAddress(SocketAddress prm1){}
        public InetAddress  Address { get; set;}
        public byte[]  Data { get; set;}
        public int  Length { get; set;}
        public int  Offset { get; private set;}
        public int  Port { get; set;}
        public SocketAddress  SocketAddress { get; set;}
    }
}
