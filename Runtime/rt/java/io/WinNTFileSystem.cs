//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.io
{
    internal partial class WinNTFileSystem : Win32FileSystem
    {
        public WinNTFileSystem(){}
        protected override global::java.lang.String canonicalize0(global::java.lang.String prm1){return default(global::java.lang.String);}
        protected override global::java.lang.String canonicalizeWithPrefix0(global::java.lang.String prm1, global::java.lang.String prm2){return default(global::java.lang.String);}
        public override bool checkAccess(File prm1, int prm2){return default(bool);}
        public override bool createDirectory(File prm1){return default(bool);}
        public override bool createFileExclusively(global::java.lang.String prm1){return default(bool);}
        protected override bool delete0(File prm1){return default(bool);}
        public override int getBooleanAttributes(File prm1){return default(int);}
        protected override global::java.lang.String getDriveDirectory(int prm1){return default(global::java.lang.String);}
        public override long getLastModifiedTime(File prm1){return default(long);}
        public override long getLength(File prm1){return default(long);}
        public override long getSpace(File prm1, int prm2){return default(long);}
        public override global::java.lang.String[] list(File prm1){return default(global::java.lang.String[]);}
        protected override bool rename0(File prm1, File prm2){return default(bool);}
        public override bool setLastModifiedTime(File prm1, long prm2){return default(bool);}
        public override bool setPermission(File prm1, int prm2, bool prm3, bool prm4){return default(bool);}
        public override bool setReadOnly(File prm1){return default(bool);}
    }
}