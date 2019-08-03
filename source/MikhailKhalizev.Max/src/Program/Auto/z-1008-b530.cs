using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f04c857-f3fd-42ba-95c5-6aca1725e661")]
        public void Method_1008_b530()
        {
            ii(0x1008_b530, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b535, 5); calld(Definitions.sys_check_available_stack_size, 0xda818); /* call 0x10165d52 */
            ii(0x1008_b53a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b53b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b53c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b53d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b53e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b53f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b541, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b547, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b54a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b54d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b550, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1008_b552, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_b555, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1008_b557, 2); if(jnzd(0x1008_b55f, 0x6)) goto l_0x1008_b55f; /* jnz 0x1008b55f */
            ii(0x1008_b559, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_b55d, 2); jmpd(0x1008_b563, 0x4); goto l_0x1008_b563; /* jmp 0x1008b563 */
        l_0x1008_b55f:
            ii(0x1008_b55f, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_b563:
            ii(0x1008_b563, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_b566, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_b569, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_b56c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b56e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b56f, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b570, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b571, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b572, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b573, 1); retd(); return;                         /* ret */
        }
    }
}