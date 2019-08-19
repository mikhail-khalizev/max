using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_89ad-79cb1ec0")]
        public void Method_100b_89ad()
        {
            ii(0x100b_89ad, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100b_89b2, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d39b); /* call 0x10165d52 */
            ii(0x100b_89b7, 1); pushd(esi);                             /* push esi */
            ii(0x100b_89b8, 1); pushd(edi);                             /* push edi */
            ii(0x100b_89b9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_89ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_89bc, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100b_89c2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_89c5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_89c8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_89cb, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100b_89ce, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100b_89d1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_89d4, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100b_89d7, 5); calld(0x100a_b2e0, -0xd6fc);            /* call 0x100ab2e0 */
            ii(0x100b_89dc, 5); calld(0x100b_8204, -0x7dd);             /* call 0x100b8204 */
            ii(0x100b_89e1, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_89e4, 3); add(edx, 0xd);                          /* add edx, 0xd */
            ii(0x100b_89e7, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_89ea, 5); calld(0x1007_5e64, -0x4_2b8b);          /* call 0x10075e64 */
            ii(0x100b_89ef, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_89f2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_1f07); /* call 0x10076af0 */
            ii(0x100b_89f7, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_89fe, 2); jmpd(0x100b_8a06, 0x6); goto l_0x100b_8a06; /* jmp 0x100b8a06 */
        l_0x100b_8a00:
            ii(0x100b_8a00, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_8a03, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_8a06:
            ii(0x100b_8a06, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100b_8a09, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_8a0c, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100b_8a0f, 2); if(jnzd(0x100b_8a1d, 0xc)) goto l_0x100b_8a1d; /* jnz 0x100b8a1d */
            ii(0x100b_8a11, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x100b_8a14, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_8a17, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100b_8a1b, 2); if(jzd(0x100b_8a48, 0x2b)) goto l_0x100b_8a48; /* jz 0x100b8a48 */
        l_0x100b_8a1d:
            ii(0x100b_8a1d, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_8a21, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8a24, 5); calld(0x100b_827c, -0x7ad);             /* call 0x100b827c */
            ii(0x100b_8a29, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100b_8a2d, 4); add(memw_a32[ss, ebp - 0x2c], ax);      /* add [ebp-0x2c], ax */
            ii(0x100b_8a31, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_8a35, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8a38, 5); calld(0x100b_827c, -0x7c1);             /* call 0x100b827c */
            ii(0x100b_8a3d, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x100b_8a42, 4); add(memw_a32[ss, ebp - 0x2a], ax);      /* add [ebp-0x2a], ax */
            ii(0x100b_8a46, 2); jmpd(0x100b_8a00, -0x48); goto l_0x100b_8a00; /* jmp 0x100b8a00 */
        l_0x100b_8a48:
            ii(0x100b_8a48, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100b_8a4b, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_8a4e, 5); calld(0x1008_8b44, -0x2_ff0f);          /* call 0x10088b44 */
            ii(0x100b_8a53, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8a56, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_8a59, 5); calld(0x1007_5e64, -0x4_2bfa);          /* call 0x10075e64 */
            ii(0x100b_8a5e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_8a60, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100b_8a63, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_8a66, 5); calld(0x1007_5e64, -0x4_2c07);          /* call 0x10075e64 */
            ii(0x100b_8a6b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_8a6d, 5); calld(0x100a_5fca, -0x1_2aa8);          /* call 0x100a5fca */
            ii(0x100b_8a72, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8a75, 2); jmpd(0x100b_8a7d, 0x6); goto l_0x100b_8a7d; /* jmp 0x100b8a7d */
        l_0x100b_8a77:
            ii(0x100b_8a77, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_8a7a, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_8a7d:
            ii(0x100b_8a7d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8a80, 5); calld(0x100b_82bc, -0x7c9);             /* call 0x100b82bc */
            ii(0x100b_8a85, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x100b_8a89, 6); if(jled(0x100b_8b18, 0x89)) goto l_0x100b_8b18; /* jle 0x100b8b18 */
            ii(0x100b_8a8f, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_8a93, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8a96, 5); calld(0x100b_827c, -0x81f);             /* call 0x100b827c */
            ii(0x100b_8a9b, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100b_8a9f, 4); add(memw_a32[ss, ebp - 0x2c], ax);      /* add [ebp-0x2c], ax */
            ii(0x100b_8aa3, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_8aa7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8aaa, 5); calld(0x100b_827c, -0x833);             /* call 0x100b827c */
            ii(0x100b_8aaf, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x100b_8ab4, 4); add(memw_a32[ss, ebp - 0x2a], ax);      /* add [ebp-0x2a], ax */
            ii(0x100b_8ab8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8abb, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_8abe, 5); calld(0x1007_5e64, -0x4_2c5f);          /* call 0x10075e64 */
            ii(0x100b_8ac3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_8ac5, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100b_8ac8, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_8acb, 5); calld(0x1007_5e64, -0x4_2c6c);          /* call 0x10075e64 */
            ii(0x100b_8ad0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_8ad2, 5); calld(0x100a_5fca, -0x1_2b0d);          /* call 0x100a5fca */
            ii(0x100b_8ad7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_8ada, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_8add, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100b_8ae1, 2); if(jged(0x100b_8b13, 0x30)) goto l_0x100b_8b13; /* jge 0x100b8b13 */
            ii(0x100b_8ae3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_8ae6, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8ae9, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100b_8aec, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_8aef, 5); calld(0x1008_8b44, -0x2_ffb0);          /* call 0x10088b44 */
            ii(0x100b_8af4, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_8af8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_8afa, 2); if(jnzd(0x100b_8b13, 0x17)) goto l_0x100b_8b13; /* jnz 0x100b8b13 */
            ii(0x100b_8afc, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100b_8aff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8b02, 5); calld(0x1007_5e64, -0x4_2ca3);          /* call 0x10075e64 */
            ii(0x100b_8b07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_8b09, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8b0c, 5); calld(0x100b_7294, -0x187d);            /* call 0x100b7294 */
            ii(0x100b_8b11, 2); jmpd(0x100b_8b39, 0x26); goto l_0x100b_8b39; /* jmp 0x100b8b39 */
        l_0x100b_8b13:
            ii(0x100b_8b13, 5); jmpd(0x100b_8a77, -0xa1); goto l_0x100b_8a77; /* jmp 0x100b8a77 */
        l_0x100b_8b18:
            ii(0x100b_8b18, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100b_8b1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8b1e, 5); calld(0x1007_5e64, -0x4_2cbf);          /* call 0x10075e64 */
            ii(0x100b_8b23, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_8b25, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_8b28, 5); calld(0x100b_7294, -0x1899);            /* call 0x100b7294 */
            ii(0x100b_8b2d, 2); jmpd(0x100b_8b39, 0xa); goto l_0x100b_8b39; /* jmp 0x100b8b39 */
        //  ii(0x100b_8b2f, 10); Недостижимый код.
        l_0x100b_8b39:
            ii(0x100b_8b39, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8b3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8b3e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8b3f, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8b40, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8b41, 1); retd(); return;                         /* ret */
        }
    }
}
