using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c3b8e44-2ef3-4430-b7d7-f896b762e868")]
        public void Method_100c_ae28()
        {
            ii(0x100c_ae28, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_ae2d, 5); calld(Definitions.sys_check_available_stack_size, 0x9af20); /* call 0x10165d52 */
            ii(0x100c_ae32, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ae33, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ae34, 1); pushd(edx);                             /* push edx */
            ii(0x100c_ae35, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ae36, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ae37, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ae38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ae3a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_ae40, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_ae43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_ae46, 5); calld(0x1008_b410, -0x3fa3b);           /* call 0x1008b410 */
            ii(0x100c_ae4b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_ae4e, 5); calld(Definitions.my_3_get_count, -0x3f9d3); /* call 0x1008b480 */
            ii(0x100c_ae53, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ae56, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ae59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ae5b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ae5c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ae5d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ae5e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_ae5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ae60, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ae61, 1); retd(); return;                         /* ret */
        }
    }
}
