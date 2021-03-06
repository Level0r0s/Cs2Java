//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    public abstract partial class LongBuffer : Buffer, global::java.lang.Comparable<LongBuffer>
    {
        public LongBuffer(){}
        public static LongBuffer allocate(int prm1){return default(LongBuffer);}
        public long[] array(){return default(long[]);}
        public int arrayOffset(){return default(int);}
        public virtual LongBuffer asReadOnlyBuffer(){return default(LongBuffer);}
        public virtual LongBuffer compact(){return default(LongBuffer);}
        public virtual int compareTo(LongBuffer prm1){return default(int);}
        public virtual LongBuffer duplicate(){return default(LongBuffer);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public virtual LongBuffer get(long[] prm1, int prm2, int prm3){return default(LongBuffer);}
        public virtual LongBuffer get(long[] prm1){return default(LongBuffer);}
        public virtual long get(){return default(long);}
        public virtual long get(int prm1){return default(long);}
        public bool hasArray(){return default(bool);}
        public override int hashCode(){return default(int);}
        public virtual ByteOrder order(){return default(ByteOrder);}
        public LongBuffer put(long[] prm1){return default(LongBuffer);}
        public virtual LongBuffer put(long[] prm1, int prm2, int prm3){return default(LongBuffer);}
        public virtual LongBuffer put(int prm1, long prm2){return default(LongBuffer);}
        public virtual LongBuffer put(LongBuffer prm1){return default(LongBuffer);}
        public virtual LongBuffer put(long prm1){return default(LongBuffer);}
        public virtual LongBuffer slice(){return default(LongBuffer);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public static LongBuffer wrap(long[] prm1, int prm2, int prm3){return default(LongBuffer);}
        public static LongBuffer wrap(long[] prm1){return default(LongBuffer);}
        public bool  IsDirect { get; private set;}
    }
}
