using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("19682ecf-00db-42af-a9fd-9c522daea866")]
        public void Method_1008_b4b4()
        {
            ii(0x1008_b4b4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_b4b9, 5); calld(Definitions.sys_check_available_stack_size, 0xda894); /* call 0x10165d52 */
            ii(0x1008_b4be, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b4bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b4c0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b4c1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b4c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b4c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b4c5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b4cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b4ce, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b4d1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_b4d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_b4d7, 5); calld(0x1008_b4ec, 0x10);               /* call 0x1008b4ec */
            ii(0x1008_b4dc, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_b4df, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_b4e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b4e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b4e5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b4e6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b4e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b4e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b4e9, 1); retd(); return;                         /* ret */
        }
    }
}
