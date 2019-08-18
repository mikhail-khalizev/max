using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2ae9-5a2714b")]
        public void Method_100a_2ae9()
        {
            ii(0x100a_2ae9, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_2aee, 5); calld(Definitions.sys_check_available_stack_size, 0xc_325f); /* call 0x10165d52 */
            ii(0x100a_2af3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2af4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2af5, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2af6, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2af7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2af8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2afa, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_2b00, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2b03, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2b06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2b08, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2b0b, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2b0e, 5); calld(0x1013_ad71, 0x9_825e);           /* call 0x1013ad71 */
            ii(0x100a_2b13, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2b15, 2); if(jzd(0x100a_2b38, 0x21)) goto l_0x100a_2b38; /* jz 0x100a2b38 */
            ii(0x100a_2b17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2b1a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2b1d, 5); calld(0x1008_af28, -0x1_7bfa);          /* call 0x1008af28 */
            ii(0x100a_2b22, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_2b25, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_2b28, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_2b2b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_2b2e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_2b31, 3); calld_abs(memd_a32[ds, ebx + 0x4]);     /* call dword [ebx+0x4] */
            ii(0x100a_2b34, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2b36, 2); if(jzd(0x100a_2b3a, 0x2)) goto l_0x100a_2b3a; /* jz 0x100a2b3a */
        l_0x100a_2b38:
            ii(0x100a_2b38, 2); jmpd(0x100a_2b40, 0x6); goto l_0x100a_2b40; /* jmp 0x100a2b40 */
        l_0x100a_2b3a:
            ii(0x100a_2b3a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_2b3e, 2); jmpd(0x100a_2b44, 0x4); goto l_0x100a_2b44; /* jmp 0x100a2b44 */
        l_0x100a_2b40:
            ii(0x100a_2b40, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100a_2b44:
            ii(0x100a_2b44, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_2b47, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2b49, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2b4a, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2b4b, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2b4c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2b4d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2b4e, 1); retd(); return;                         /* ret */
        }
    }
}
