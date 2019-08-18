using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c62a7797-4109-4f47-a451-c1f68b4b5571")]
        public void /* sys */ Method_1017_df39()
        {
            ii(0x1017_df39, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_df3a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_df3b, 1); pushd(edx);                             /* push edx */
            ii(0x1017_df3c, 1); pushd(esi);                             /* push esi */
            ii(0x1017_df3d, 1); pushd(edi);                             /* push edi */
            ii(0x1017_df3e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_df3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_df41, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1017_df47, 5); calld(/* sys */ 0x1019_4c19, 0x1_6ccd); /* call 0x10194c19 */
            ii(0x1017_df4c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_df4d, 1); popd(edi);                              /* pop edi */
            ii(0x1017_df4e, 1); popd(esi);                              /* pop esi */
            ii(0x1017_df4f, 1); popd(edx);                              /* pop edx */
            ii(0x1017_df50, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_df51, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_df52, 1); retfd(); return;                        /* retf */
        }
    }
}
