using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("41d75379-5523-4875-8643-82b421457699")]
        public void Method_100a_0054()
        {
            ii(0x100a_0054, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_0059, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5cf4); /* call 0x10165d52 */
            ii(0x100a_005e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_005f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_0060, 1); pushd(edx);                             /* push edx */
            ii(0x100a_0061, 1); pushd(esi);                             /* push esi */
            ii(0x100a_0062, 1); pushd(edi);                             /* push edi */
            ii(0x100a_0063, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_0064, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0066, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_006c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_006f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0072, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100a_0075, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_0078, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_007b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_007d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_007e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_007f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0080, 1); popd(edx);                              /* pop edx */
            ii(0x100a_0081, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_0082, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_0083, 1); retd(); return;                         /* ret */
        }
    }
}
