//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util
{
    public partial class SimpleTimeZone : TimeZone
    {
        public static int STANDARD_TIME;
        public static int UTC_TIME;
        public static int WALL_TIME;
        public override global::System.Object clone(){return default(global::System.Object);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public override int getOffset(int prm1, int prm2, int prm3, int prm4, int prm5, int prm6){return default(int);}
        public override int getOffset(long prm1){return default(int);}
        public override int hashCode(){return default(int);}
        public override bool hasSameRules(TimeZone prm1){return default(bool);}
        public override bool inDaylightTime(Date prm1){return default(bool);}
        public SimpleTimeZone(int prm1, global::java.lang.String prm2, int prm3, int prm4, int prm5, int prm6, int prm7, int prm8, int prm9, int prm10, int prm11, int prm12, int prm13){}
        public SimpleTimeZone(int prm1, global::java.lang.String prm2, int prm3, int prm4, int prm5, int prm6, int prm7, int prm8, int prm9, int prm10, int prm11){}
        public SimpleTimeZone(int prm1, global::java.lang.String prm2, int prm3, int prm4, int prm5, int prm6, int prm7, int prm8, int prm9, int prm10){}
        public SimpleTimeZone(int prm1, global::java.lang.String prm2){}
        public override bool observesDaylightTime(){return default(bool);}
        public virtual void setDSTSavings(int prm1){}
        public virtual void setEndRule(int prm1, int prm2, int prm3, int prm4){}
        public virtual void setEndRule(int prm1, int prm2, int prm3, int prm4, bool prm5){}
        public virtual void setEndRule(int prm1, int prm2, int prm3){}
        public override void setRawOffset(int prm1){}
        public virtual void setStartRule(int prm1, int prm2, int prm3){}
        public virtual void setStartRule(int prm1, int prm2, int prm3, int prm4, bool prm5){}
        public virtual void setStartRule(int prm1, int prm2, int prm3, int prm4){}
        public virtual void setStartYear(int prm1){}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public override bool useDaylightTime(){return default(bool);}
        public int  DSTSavings { get; set;}
        public int  RawOffset { get; set;}
    }
}
