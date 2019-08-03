using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a6c5bb9-3297-4d94-b06a-bf4b41a3d6af")]
        public void Method_1008_b2ec()
        {
            ii(0x1008_b2ec, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_b2f1, 5); calld(Definitions.sys_check_available_stack_size, 0xdaa5c); /* call 0x10165d52 */
            ii(0x1008_b2f6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b2f7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b2f8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b2f9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b2fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b2fc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b302, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b305, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_b308, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_b30b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1008_b30f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_b312, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_b315, 5); calld(0x1008_b410, 0xf6);               /* call 0x1008b410 */
            ii(0x1008_b31a, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_b31d, 5); calld(0x100c_d990, 0x4266e);            /* call 0x100cd990 */
            ii(0x1008_b322, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b324, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b325, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b326, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b327, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b328, 1); retd(); return;                         /* ret */
        }
    }
}
