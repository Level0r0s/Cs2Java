//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.io
{
    public partial class PrintWriter : Writer
    {
        public Writer @out;
        public virtual PrintWriter append(global::java.lang.CharSequence prm1, int prm2, int prm3){return default(PrintWriter);}
        public virtual PrintWriter append(global::java.lang.CharSequence prm1){return default(PrintWriter);}
        public virtual PrintWriter append(char prm1){return default(PrintWriter);}
        public virtual bool checkError(){return default(bool);}
        protected virtual void clearError(){}
        public override void close(){}
        public override void flush(){}
        public virtual PrintWriter format(global::java.util.Locale prm1, global::java.lang.String prm2, global::System.Object[] prm3){return default(PrintWriter);}
        public virtual PrintWriter format(global::java.lang.String prm1, global::System.Object[] prm2){return default(PrintWriter);}
        public PrintWriter(OutputStream prm1, bool prm2){}
        public PrintWriter(global::java.lang.String prm1){}
        public PrintWriter(File prm1){}
        public PrintWriter(File prm1, global::java.lang.String prm2){}
        public PrintWriter(global::java.lang.String prm1, global::java.lang.String prm2){}
        public PrintWriter(Writer prm1){}
        public PrintWriter(OutputStream prm1){}
        public PrintWriter(Writer prm1, bool prm2){}
        public virtual void print(float prm1){}
        public virtual void print(long prm1){}
        public virtual void print(int prm1){}
        public virtual void print(char prm1){}
        public virtual void print(bool prm1){}
        public virtual void print(global::System.Object prm1){}
        public virtual void print(global::java.lang.String prm1){}
        public virtual void print(char[] prm1){}
        public virtual void print(double prm1){}
        public virtual PrintWriter printf(global::java.lang.String prm1, global::System.Object[] prm2){return default(PrintWriter);}
        public virtual PrintWriter printf(global::java.util.Locale prm1, global::java.lang.String prm2, global::System.Object[] prm3){return default(PrintWriter);}
        public virtual void println(double prm1){}
        public virtual void println(char[] prm1){}
        public virtual void println(float prm1){}
        public virtual void println(global::java.lang.String prm1){}
        public virtual void println(global::System.Object prm1){}
        public virtual void println(int prm1){}
        public virtual void println(char prm1){}
        public virtual void println(bool prm1){}
        public virtual void println(){}
        public virtual void println(long prm1){}
        protected virtual void setError(){}
        public override void write(char[] prm1, int prm2, int prm3){}
        public override void write(global::java.lang.String prm1, int prm2, int prm3){}
        public override void write(char[] prm1){}
        public override void write(int prm1){}
        public override void write(global::java.lang.String prm1){}
    }
}
