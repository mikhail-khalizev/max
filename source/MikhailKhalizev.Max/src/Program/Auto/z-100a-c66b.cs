using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dacb262c-4572-4a25-86a4-0b36c12d75ec")]
        public void Method_100a_c66b()
        {
            ii(0x100a_c66b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_c670, 5); calld(Definitions.sys_check_available_stack_size, 0xb_96dd); /* call 0x10165d52 */
            ii(0x100a_c675, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_c676, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c677, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c678, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c679, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c67a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c67c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_c682, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_c685, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_c688, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c68b, 5); cmp(memw_a32[ds, eax + 0x26], 0x41);    /* cmp word [eax+0x26], 0x41 */
            ii(0x100a_c690, 2); if(jnzd(0x100a_c698, 0x6)) goto l_0x100a_c698; /* jnz 0x100ac698 */
            ii(0x100a_c692, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_c696, 2); if(jzd(0x100a_c69a, 0x2)) goto l_0x100a_c69a; /* jz 0x100ac69a */
        l_0x100a_c698:
            ii(0x100a_c698, 2); jmpd(0x100a_c6a9, 0xf); goto l_0x100a_c6a9; /* jmp 0x100ac6a9 */
        l_0x100a_c69a:
            ii(0x100a_c69a, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x100a_c69f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c6a2, 5); calld(0x100a_d86c, 0x11c5);             /* call 0x100ad86c */
            ii(0x100a_c6a7, 2); jmpd(0x100a_c6b2, 0x9); goto l_0x100a_c6b2; /* jmp 0x100ac6b2 */
        l_0x100a_c6a9:
            ii(0x100a_c6a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c6ac, 6); mov(memw_a32[ds, eax + 0x26], 0xffff);  /* mov word [eax+0x26], 0xffff */
        l_0x100a_c6b2:
            ii(0x100a_c6b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c6b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c6b5, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c6b6, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c6b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c6b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_c6b9, 1); retd(); return;                         /* ret */
        }
    }
}