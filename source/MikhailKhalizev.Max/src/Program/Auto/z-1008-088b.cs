using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_088b-a0547f6c")]
        public void Method_1008_088b()
        {
            ii(0x1008_088b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_0890, 5); calld(Definitions.sys_check_available_stack_size, 0xe_54bd); /* call 0x10165d52 */
            ii(0x1008_0895, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_0896, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_0897, 1); pushd(esi);                             /* push esi */
            ii(0x1008_0898, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0899, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_089a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_089c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_08a2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_08a5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_08a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_08ab, 5); cmp(memw_a32[ds, eax + 0x8], 0x38);     /* cmp word [eax+0x8], 0x38 */
            ii(0x1008_08b0, 2); if(jzd(0x1008_08bc, 0xa)) goto l_0x1008_08bc; /* jz 0x100808bc */
            ii(0x1008_08b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_08b5, 5); cmp(memw_a32[ds, eax + 0x8], 0x4a);     /* cmp word [eax+0x8], 0x4a */
            ii(0x1008_08ba, 2); if(jnzd(0x1008_08c2, 0x6)) goto l_0x1008_08c2; /* jnz 0x100808c2 */
        l_0x1008_08bc:
            ii(0x1008_08bc, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_08c0, 2); jmpd(0x1008_08c6, 0x4); goto l_0x1008_08c6; /* jmp 0x100808c6 */
        l_0x1008_08c2:
            ii(0x1008_08c2, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_08c6:
            ii(0x1008_08c6, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_08c9, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_08cc, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_08cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_08d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_08d2, 1); popd(edi);                              /* pop edi */
            ii(0x1008_08d3, 1); popd(esi);                              /* pop esi */
            ii(0x1008_08d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_08d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_08d6, 1); retd(); return;                         /* ret */
        }
    }
}
