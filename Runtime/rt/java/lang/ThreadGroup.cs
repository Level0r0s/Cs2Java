//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.lang
{
    public partial class ThreadGroup : Object, Thread.UncaughtExceptionHandler
    {
        public virtual int activeCount(){return default(int);}
        public virtual int activeGroupCount(){return default(int);}
        public virtual bool allowThreadSuspension(bool prm1){return default(bool);}
        public void checkAccess(){}
        public void destroy(){}
        public virtual int enumerate(ThreadGroup[] prm1, bool prm2){return default(int);}
        public virtual int enumerate(ThreadGroup[] prm1){return default(int);}
        public virtual int enumerate(Thread[] prm1, bool prm2){return default(int);}
        public virtual int enumerate(Thread[] prm1){return default(int);}
        public void interrupt(){}
        public ThreadGroup(ThreadGroup prm1, String prm2){}
        public ThreadGroup(String prm1){}
        public virtual void list(){}
        public bool parentOf(ThreadGroup prm1){return default(bool);}
        public void resume(){}
        public void setDaemon(bool prm1){}
        public void setMaxPriority(int prm1){}
        public void stop(){}
        public void suspend(){}
        public override String toString(){return default(String);}
        public virtual void uncaughtException(Thread prm1, Throwable prm2){}
        public bool  IsDaemon { get; set;}
        public bool  IsDestroyed { get; private set;}
        public int  MaxPriority { get; set;}
        public String  Name { get; private set;}
        public ThreadGroup  Parent { get; private set;}
    }
}