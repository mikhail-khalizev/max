using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("12d973b8-9624-4eff-937d-6752769fbce6")]
        public void Method_1014_9ab7()
        {
            ii(0x1014_9ab7, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_9abc, 5); calld(Definitions.sys_check_available_stack_size, 0x1c291); /* call 0x10165d52 */
            ii(0x1014_9ac1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_9ac2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_9ac3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_9ac4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9ac5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9ac7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_9acd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_9ad0, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_9ad3, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_9ad6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9ad9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_9adc, 4); mov(memw_a32[ds, edx + 0x33], ax);      /* mov [edx+0x33], ax */
            ii(0x1014_9ae0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9ae3, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_9ae6, 4); mov(memw_a32[ds, edx + 0x3b], ax);      /* mov [edx+0x3b], ax */
            ii(0x1014_9aea, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_9aed, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1014_9af0, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_9af2, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1014_9af5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_9af8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_9afb, 5); calld(0x1014_9b07, 0x7);                /* call 0x10149b07 */
            ii(0x1014_9b00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9b02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9b03, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9b04, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9b05, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_9b06, 1); retd(); return;                         /* ret */
        }
    }
}
