//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.concurrent
{
    public partial class ExecutorCompletionService<V> : global::java.lang.Object, CompletionService<V>
    {
        public ExecutorCompletionService(Executor prm1, BlockingQueue<Future<V>> prm2){}
        public ExecutorCompletionService(Executor prm1){}
        public virtual Future<V> poll(long prm1, TimeUnit prm2){return default(Future<V>);}
        public virtual Future<V> poll(){return default(Future<V>);}
        public virtual Future<V> submit(global::java.lang.Runnable prm1, V prm2){return default(Future<V>);}
        public virtual Future<V> submit(Callable<V> prm1){return default(Future<V>);}
        public virtual Future<V> take(){return default(Future<V>);}
    }
}