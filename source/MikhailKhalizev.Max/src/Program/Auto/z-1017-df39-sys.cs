using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_df39-f47ec4a2")]
        public void /* sys */ Method_1017_df39()
        {
            ii(0x1017_df39, 1); push(ebx);                              /* push ebx */
            ii(0x1017_df3a, 1); push(ecx);                              /* push ecx */
            ii(0x1017_df3b, 1); push(edx);                              /* push edx */
            ii(0x1017_df3c, 1); push(esi);                              /* push esi */
            ii(0x1017_df3d, 1); push(edi);                              /* push edi */
            ii(0x1017_df3e, 1); push(ebp);                              /* push ebp */
            ii(0x1017_df3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_df41, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1017_df47, 5); if(call_up(/* sys */ 0x1019_4c19, 0x1_6ccd)) return; /* call 0x10194c19 */
            ii(0x1017_df4c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_df4d, 1); pop(edi);                               /* pop edi */
            ii(0x1017_df4e, 1); pop(esi);                               /* pop esi */
            ii(0x1017_df4f, 1); pop(edx);                               /* pop edx */
            ii(0x1017_df50, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_df51, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_df52, 1); retf();                                 /* retf */
        }
    }
}
