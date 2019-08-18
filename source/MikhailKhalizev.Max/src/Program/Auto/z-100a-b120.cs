using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b120-f8af6e70")]
        public void Method_100a_b120()
        {
            ii(0x100a_b120, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_b125, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ac28); /* call 0x10165d52 */
            ii(0x100a_b12a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b12b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b12c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b12d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b12e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b130, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b136, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b139, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_b13c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_b13f, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_b143, 2); if(jzd(0x100a_b153, 0xe)) goto l_0x100a_b153; /* jz 0x100ab153 */
            ii(0x100a_b145, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b148, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_b14b, 6); or(memd_a32[ds, edx + 0xdd], eax);      /* or [edx+0xdd], eax */
            ii(0x100a_b151, 2); jmpd(0x100a_b161, 0xe); goto l_0x100a_b161; /* jmp 0x100ab161 */
        l_0x100a_b153:
            ii(0x100a_b153, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_b156, 2); not(edx);                               /* not edx */
            ii(0x100a_b158, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_b15b, 6); and(memd_a32[ds, eax + 0xdd], edx);     /* and [eax+0xdd], edx */
        l_0x100a_b161:
            ii(0x100a_b161, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b163, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b164, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b165, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b166, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b167, 1); retd(); return;                         /* ret */
        }
    }
}
