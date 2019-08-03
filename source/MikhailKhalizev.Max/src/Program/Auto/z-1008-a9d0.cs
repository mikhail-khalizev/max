using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2fbd5445-b0c7-408e-89c5-e882285c7463")]
        public void Method_1008_a9d0()
        {
            ii(0x1008_a9d0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_a9d5, 5); calld(Definitions.sys_check_available_stack_size, 0xdb378); /* call 0x10165d52 */
            ii(0x1008_a9da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a9db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a9dc, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a9dd, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a9de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a9df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a9e1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a9e7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a9ea, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a9ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a9f0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_a9f3, 6); mov(memd_a32[ds, edx + 0xdd], eax);     /* mov [edx+0xdd], eax */
            ii(0x1008_a9f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a9fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a9fc, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a9fd, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a9fe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a9ff, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_aa00, 1); retd(); return;                         /* ret */
        }
    }
}
