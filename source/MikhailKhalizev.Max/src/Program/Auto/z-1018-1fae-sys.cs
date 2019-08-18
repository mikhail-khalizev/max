using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9e580800-f2a3-4918-962a-4735c73c95c2")]
        public void /* sys */ Method_1018_1fae()
        {
            ii(0x1018_1fae, 1); pushd(es);                              /* push es */
            ii(0x1018_1faf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_1fb0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1fb1, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1fb2, 2); fninit();                               /* fninit */
            ii(0x1018_1fb4, 1); pushd(eax);                             /* push eax */
            ii(0x1018_1fb5, 3); fnstcw(memw_a32[ss, esp]);              /* fnstcw word [esp] */
            ii(0x1018_1fb8, 1); popd(eax);                              /* pop eax */
            ii(0x1018_1fb9, 3); cmp(ah, 0x3);                           /* cmp ah, 0x3 */
            ii(0x1018_1fbc, 2); if(jzd(0x1018_1fbf, 0x1)) goto l_0x1018_1fbf; /* jz 0x10181fbf */
            ii(0x1018_1fbe, 1); inc(ebp);                               /* inc ebp */
        l_0x1018_1fbf:
            ii(0x1018_1fbf, 2); or(ebp, ebp);                           /* or ebp, ebp */
            ii(0x1018_1fc1, 2); if(jzd(0x1018_1fc8, 0x5)) goto l_0x1018_1fc8; /* jz 0x10181fc8 */
            ii(0x1018_1fc3, 5); calld(/* sys */ 0x1018_1fde, 0x16);     /* call 0x10181fde */
        l_0x1018_1fc8:
            ii(0x1018_1fc8, 1); wait();                                 /* wait */
            ii(0x1018_1fc9, 2); fninit();                               /* fninit */
            ii(0x1018_1fcb, 6); fldcw(memw_a32[ds, 0x101c_1c44]);       /* fldcw word [0x101c1c44] */
            ii(0x1018_1fd1, 2); fldz();                                 /* fldz */
            ii(0x1018_1fd3, 2); fldz();                                 /* fldz */
            ii(0x1018_1fd5, 2); fldz();                                 /* fldz */
            ii(0x1018_1fd7, 2); fldz();                                 /* fldz */
            ii(0x1018_1fd9, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1fda, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1fdb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_1fdc, 1); popd(es);                               /* pop es */
            ii(0x1018_1fdd, 1); retd(); return;                         /* ret */
        }
    }
}
