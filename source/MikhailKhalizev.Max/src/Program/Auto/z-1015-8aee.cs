using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8aee-1921fce8")]
        public void Method_1015_8aee()
        {
            ii(0x1015_8aee, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_8af3, 5); calld(Definitions.sys_check_available_stack_size, 0xd25a); /* call 0x10165d52 */
            ii(0x1015_8af8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8af9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8afa, 1); pushd(esi);                             /* push esi */
            ii(0x1015_8afb, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8afc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8afd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8aff, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_8b05, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8b08, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_8b0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8b0e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_8b11, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8b16, 5); calld(0x100f_448c, -0x6_468f);          /* call 0x100f448c */
            ii(0x1015_8b1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8b1e, 4); cmp(memb_a32[ds, eax + 0x57], 0x3);     /* cmp byte [eax+0x57], 0x3 */
            ii(0x1015_8b22, 2); if(jnzd(0x1015_8b2d, 0x9)) goto l_0x1015_8b2d; /* jnz 0x10158b2d */
            ii(0x1015_8b24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8b27, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_8b2b, 2); jmpd(0x1015_8b34, 0x7); goto l_0x1015_8b34; /* jmp 0x10158b34 */
        l_0x1015_8b2d:
            ii(0x1015_8b2d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8b30, 4); mov(memb_a32[ds, eax + 0x57], 0x3);     /* mov byte [eax+0x57], 0x3 */
        l_0x1015_8b34:
            ii(0x1015_8b34, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8b37, 4); mov(memb_a32[ds, eax + 0x55], 0);       /* mov byte [eax+0x55], 0x0 */
            ii(0x1015_8b3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8b3e, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x1015_8b42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8b44, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8b45, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8b46, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8b47, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8b48, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8b49, 1); retd();                                 /* ret */
        }
    }
}
