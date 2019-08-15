using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d590b4f-b880-40a8-98c4-78ba333b5561")]
        public void Method_100e_3a40()
        {
            ii(0x100e_3a40, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_3a45, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2308); /* call 0x10165d52 */
            ii(0x100e_3a4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_3a4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_3a4c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_3a4d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_3a4e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_3a4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3a51, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_3a57, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_3a5a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_3a5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_3a60, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_3a63, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a66, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3a69, 5); calld(0x1007_6574, -0x6_d4fa);          /* call 0x10076574 */
            ii(0x100e_3a6e, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x100e_3a73, 2); if(jnzd(0x100e_3a8f, 0x1a)) goto l_0x100e_3a8f; /* jnz 0x100e3a8f */
            ii(0x100e_3a75, 5); calld(0x100d_4e6c, -0xec0e);            /* call 0x100d4e6c */
            ii(0x100e_3a7a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3a7c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_3a7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3a80, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x100e_3a85, 5); calld(0x1010_5b00, 0x2_2076);           /* call 0x10105b00 */
            ii(0x100e_3a8a, 5); jmpd(0x100e_3b1f, 0x90); goto l_0x100e_3b1f; /* jmp 0x100e3b1f */
        l_0x100e_3a8f:
            ii(0x100e_3a8f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a92, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3a95, 5); calld(0x1007_6574, -0x6_d526);          /* call 0x10076574 */
            ii(0x100e_3a9a, 5); cmp(memw_a32[ds, eax + 0x8], 0xb);      /* cmp word [eax+0x8], 0xb */
            ii(0x100e_3a9f, 2); if(jnzd(0x100e_3ab8, 0x17)) goto l_0x100e_3ab8; /* jnz 0x100e3ab8 */
            ii(0x100e_3aa1, 5); calld(0x100d_4e6c, -0xec3a);            /* call 0x100d4e6c */
            ii(0x100e_3aa6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3aa8, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_3aaa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3aac, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100e_3ab1, 5); calld(0x1010_5b00, 0x2_204a);           /* call 0x10105b00 */
            ii(0x100e_3ab6, 2); jmpd(0x100e_3b1f, 0x67); goto l_0x100e_3b1f; /* jmp 0x100e3b1f */
        l_0x100e_3ab8:
            ii(0x100e_3ab8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3abb, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3abe, 5); calld(0x1007_6574, -0x6_d54f);          /* call 0x10076574 */
            ii(0x100e_3ac3, 5); cmp(memw_a32[ds, eax + 0x8], 0x9);      /* cmp word [eax+0x8], 0x9 */
            ii(0x100e_3ac8, 2); if(jnzd(0x100e_3ae1, 0x17)) goto l_0x100e_3ae1; /* jnz 0x100e3ae1 */
            ii(0x100e_3aca, 5); calld(0x100d_4e6c, -0xec63);            /* call 0x100d4e6c */
            ii(0x100e_3acf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3ad1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_3ad3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3ad5, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100e_3ada, 5); calld(0x1010_5b00, 0x2_2021);           /* call 0x10105b00 */
            ii(0x100e_3adf, 2); jmpd(0x100e_3b1f, 0x3e); goto l_0x100e_3b1f; /* jmp 0x100e3b1f */
        l_0x100e_3ae1:
            ii(0x100e_3ae1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3ae4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3ae7, 5); calld(0x1007_6574, -0x6_d578);          /* call 0x10076574 */
            ii(0x100e_3aec, 5); cmp(memw_a32[ds, eax + 0x8], 0x3);      /* cmp word [eax+0x8], 0x3 */
            ii(0x100e_3af1, 2); if(jnzd(0x100e_3b0a, 0x17)) goto l_0x100e_3b0a; /* jnz 0x100e3b0a */
            ii(0x100e_3af3, 5); calld(0x100d_4e6c, -0xec8c);            /* call 0x100d4e6c */
            ii(0x100e_3af8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3afa, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_3afc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3afe, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100e_3b03, 5); calld(0x1010_5b00, 0x2_1ff8);           /* call 0x10105b00 */
            ii(0x100e_3b08, 2); jmpd(0x100e_3b1f, 0x15); goto l_0x100e_3b1f; /* jmp 0x100e3b1f */
        l_0x100e_3b0a:
            ii(0x100e_3b0a, 5); calld(0x100d_4e6c, -0xeca3);            /* call 0x100d4e6c */
            ii(0x100e_3b0f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3b11, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_3b13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_3b15, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x100e_3b1a, 5); calld(0x1010_5b00, 0x2_1fe1);           /* call 0x10105b00 */
        l_0x100e_3b1f:
            ii(0x100e_3b1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3b21, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3b22, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3b23, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3b24, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3b25, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3b26, 1); retd(); return;                         /* ret */
        }
    }
}
