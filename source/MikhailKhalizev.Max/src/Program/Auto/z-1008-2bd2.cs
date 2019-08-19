using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2bd2-c0743d4c")]
        public void Method_1008_2bd2()
        {
            ii(0x1008_2bd2, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_2bd7, 5); calld(Definitions.sys_check_available_stack_size, 0xe_3176); /* call 0x10165d52 */
            ii(0x1008_2bdc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_2bdd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_2bde, 1); pushd(esi);                             /* push esi */
            ii(0x1008_2bdf, 1); pushd(edi);                             /* push edi */
            ii(0x1008_2be0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_2be1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2be3, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_2be9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_2bec, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_2bef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2bf1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2bf4, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2bf7, 5); calld(0x1013_ad11, 0xb_8115);           /* call 0x1013ad11 */
            ii(0x1008_2bfc, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2bfe, 2); if(jzd(0x1008_2c09, 0x9)) goto l_0x1008_2c09; /* jz 0x10082c09 */
            ii(0x1008_2c00, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_2c04, 5); jmpd(0x1008_2d51, 0x148); goto l_0x1008_2d51; /* jmp 0x10082d51 */
        l_0x1008_2c09:
            ii(0x1008_2c09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2c0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2c0e, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2c11, 5); calld(0x1013_ad11, 0xb_80fb);           /* call 0x1013ad11 */
            ii(0x1008_2c16, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2c18, 2); if(jzd(0x1008_2c23, 0x9)) goto l_0x1008_2c23; /* jz 0x10082c23 */
            ii(0x1008_2c1a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_2c1e, 5); jmpd(0x1008_2d51, 0x12e); goto l_0x1008_2d51; /* jmp 0x10082d51 */
        l_0x1008_2c23:
            ii(0x1008_2c23, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_2c26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2c29, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2c2c, 5); calld(0x1008_9d7c, 0x714b);             /* call 0x10089d7c */
            ii(0x1008_2c31, 5); calld(0x100a_2d3d, 0x2_0107);           /* call 0x100a2d3d */
            ii(0x1008_2c36, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_2c39, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_2c3c, 5); calld(0x1007_5e64, -0xcddd);            /* call 0x10075e64 */
            ii(0x1008_2c41, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2c43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2c46, 5); calld(0x1007_0ca1, -0x1_1faa);          /* call 0x10070ca1 */
            ii(0x1008_2c4b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_2c4d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_2c50, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_2c53, 5); calld(0x1007_5e64, -0xcdf4);            /* call 0x10075e64 */
            ii(0x1008_2c58, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2c5a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2c5d, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2c60, 5); calld(0x1007_65d0, -0xc695);            /* call 0x100765d0 */
            ii(0x1008_2c65, 5); calld(0x1007_0ca1, -0x1_1fc9);          /* call 0x10070ca1 */
            ii(0x1008_2c6a, 3); cmp(bx, ax);                            /* cmp bx, ax */
            ii(0x1008_2c6d, 2); if(jged(0x1008_2c7e, 0xf)) goto l_0x1008_2c7e; /* jge 0x10082c7e */
            ii(0x1008_2c6f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_2c72, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2c75, 5); calld(0x1008_2abe, -0x1bc);             /* call 0x10082abe */
            ii(0x1008_2c7a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2c7c, 2); if(jnzd(0x1008_2c87, 0x9)) goto l_0x1008_2c87; /* jnz 0x10082c87 */
        l_0x1008_2c7e:
            ii(0x1008_2c7e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_2c82, 5); jmpd(0x1008_2d51, 0xca); goto l_0x1008_2d51; /* jmp 0x10082d51 */
        l_0x1008_2c87:
            ii(0x1008_2c87, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_2c8a, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1008_2c8d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_2c90, 5); calld(0x1007_6668, -0xc62d);            /* call 0x10076668 */
            ii(0x1008_2c95, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_2c98, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1008_2c9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2c9e, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_2ca1, 5); calld(0x1008_b530, 0x888a);             /* call 0x1008b530 */
            ii(0x1008_2ca6, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2ca8, 2); if(jzd(0x1008_2cde, 0x34)) goto l_0x1008_2cde; /* jz 0x10082cde */
            ii(0x1008_2caa, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_2cad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2cb0, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_2cb3, 5); calld(0x1007_6574, -0xc744);            /* call 0x10076574 */
            ii(0x1008_2cb8, 5); calld(0x1015_27b8, 0xc_fafb);           /* call 0x101527b8 */
            ii(0x1008_2cbd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_2cc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2cc3, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_2cc6, 5); calld(0x1007_6630, -0xc69b);            /* call 0x10076630 */
            ii(0x1008_2ccb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_2cce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2cd1, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_2cd4, 5); calld(0x1007_6574, -0xc765);            /* call 0x10076574 */
            ii(0x1008_2cd9, 5); calld(0x1015_2783, 0xc_faa5);           /* call 0x10152783 */
        l_0x1008_2cde:
            ii(0x1008_2cde, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_2ce1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2ce4, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2ce7, 5); calld(0x1007_6630, -0xc6bc);            /* call 0x10076630 */
            ii(0x1008_2cec, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_2cef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2cf2, 5); calld(0x1015_27ed, 0xc_faf6);           /* call 0x101527ed */
            ii(0x1008_2cf7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2cfa, 6); mov(memw_a32[ds, eax + 0x1e], 0);       /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_2d00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2d03, 6); mov(memw_a32[ds, eax + 0x20], 0);       /* mov word [eax+0x20], 0x0 */
            ii(0x1008_2d09, 5); calld(0x1008_b0e4, 0x83d6);             /* call 0x1008b0e4 */
            ii(0x1008_2d0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2d10, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_2d12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2d15, 5); calld(0x100a_297d, 0x1_fc63);           /* call 0x100a297d */
            ii(0x1008_2d1a, 5); calld(0x1008_a79c, 0x7a7d);             /* call 0x1008a79c */
            ii(0x1008_2d1f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_2d21, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_2d23, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_2d26, 5); calld(0x1007_65d0, -0xc75b);            /* call 0x100765d0 */
            ii(0x1008_2d2b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2d2d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_2d32, 5); calld(0x100a_53ac, 0x2_2675);           /* call 0x100a53ac */
            ii(0x1008_2d37, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_2d3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2d3d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_2d40, 5); calld(0x1007_5f2c, -0xce19);            /* call 0x10075f2c */
            ii(0x1008_2d45, 2); jmpd(0x1008_2d51, 0xa); goto l_0x1008_2d51; /* jmp 0x10082d51 */
        //  ii(0x1008_2d47, 10); Недостижимый код.
        l_0x1008_2d51:
            ii(0x1008_2d51, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_2d54, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_2d56, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_2d57, 1); popd(edi);                              /* pop edi */
            ii(0x1008_2d58, 1); popd(esi);                              /* pop esi */
            ii(0x1008_2d59, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_2d5a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_2d5b, 1); retd(); return;                         /* ret */
        }
    }
}
