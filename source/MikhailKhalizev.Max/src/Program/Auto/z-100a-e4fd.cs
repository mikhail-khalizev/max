using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e20d535c-9b10-4c74-9b24-403535ee10a5")]
        public void Method_100a_e4fd()
        {
            ii(0x100a_e4fd, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100a_e502, 5); calld(Definitions.sys_check_available_stack_size, 0xb_784b); /* call 0x10165d52 */
            ii(0x100a_e507, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_e508, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_e509, 1); pushd(edx);                             /* push edx */
            ii(0x100a_e50a, 1); pushd(esi);                             /* push esi */
            ii(0x100a_e50b, 1); pushd(edi);                             /* push edi */
            ii(0x100a_e50c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_e50d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_e50f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_e515, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_e518, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e51b, 4); cmp(memb_a32[ds, eax + 0x19], 0);       /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_e51f, 2); if(jnzd(0x100a_e52a, 0x9)) goto l_0x100a_e52a; /* jnz 0x100ae52a */
            ii(0x100a_e521, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_e525, 5); jmpd(0x100a_e6d6, 0x1ac); goto l_0x100a_e6d6; /* jmp 0x100ae6d6 */
        l_0x100a_e52a:
            ii(0x100a_e52a, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100a_e52f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e532, 3); mov(ebx, memd_a32[ds, eax + 0x16]);     /* mov ebx, [eax+0x16] */
            ii(0x100a_e535, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x100a_e538, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e53b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e53e, 5); calld(0x1007_65d0, -0x3_7f73);          /* call 0x100765d0 */
            ii(0x100a_e543, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e545, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e548, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_e54b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e54e, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100a_e554, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_e559, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_e55b, 5); calld(0x100c_1fd4, 0x1_3a74);           /* call 0x100c1fd4 */
            ii(0x100a_e560, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_e563, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100a_e567, 2); if(jnzd(0x100a_e572, 0x9)) goto l_0x100a_e572; /* jnz 0x100ae572 */
            ii(0x100a_e569, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_e56d, 5); jmpd(0x100a_e6d6, 0x164); goto l_0x100a_e6d6; /* jmp 0x100ae6d6 */
        l_0x100a_e572:
            ii(0x100a_e572, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e575, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e578, 5); calld(0x1007_6574, -0x3_8009);          /* call 0x10076574 */
            ii(0x100a_e57d, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_e580, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e583, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e586, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100a_e589, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e58c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_e58e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_e591, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e594, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e597, 5); calld(0x1007_6574, -0x3_8028);          /* call 0x10076574 */
            ii(0x100a_e59c, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x100a_e59f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e5a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e5a5, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100a_e5a8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e5ab, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_e5ad, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_e5b0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_e5b3, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_7ac8); /* call 0x10076af0 */
            ii(0x100a_e5b8, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100a_e5bb, 4); imul(edx, memd_a32[ss, ebp - 0x1c]);    /* imul edx, [ebp-0x1c] */
            ii(0x100a_e5bf, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_e5c2, 4); imul(eax, memd_a32[ss, ebp - 0x18]);    /* imul eax, [ebp-0x18] */
            ii(0x100a_e5c6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_e5c8, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100a_e5cb, 3); fild(memd_a32[ss, ebp - 0x28]);         /* fild dword [ebp-0x28] */
            ii(0x100a_e5ce, 5); calld(Definitions.sys_sqrt, 0xb_7a73);  /* call 0x10166046 */
            ii(0x100a_e5d3, 6); fmul(memq_a32[ds, 0x101a_0ea8]);        /* fmul qword [0x101a0ea8] */
            ii(0x100a_e5d9, 6); fadd(memq_a32[ds, 0x101a_0eb0]);        /* fadd qword [0x101a0eb0] */
            ii(0x100a_e5df, 5); calld(Definitions.sys_round, 0xb_7a9a); /* call 0x1016607e */
            ii(0x100a_e5e4, 3); fistp(memd_a32[ss, ebp - 0x28]);        /* fistp dword [ebp-0x28] */
            ii(0x100a_e5e7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_e5ea, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_e5ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e5f0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e5f3, 5); calld(0x1007_6574, -0x3_8084);          /* call 0x10076574 */
            ii(0x100a_e5f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e5fa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_e5fc, 3); mov(al, memb_a32[ds, edx + 0x4d]);      /* mov al, [edx+0x4d] */
            ii(0x100a_e5ff, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_e602, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e605, 4); cmp(memb_a32[ds, eax + 0x19], 0x3);     /* cmp byte [eax+0x19], 0x3 */
            ii(0x100a_e609, 2); if(jnzd(0x100a_e612, 0x7)) goto l_0x100a_e612; /* jnz 0x100ae612 */
            ii(0x100a_e60b, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x100a_e612:
            ii(0x100a_e612, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_e616, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e618, 2); if(jnzd(0x100a_e623, 0x9)) goto l_0x100a_e623; /* jnz 0x100ae623 */
            ii(0x100a_e61a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_e61e, 5); jmpd(0x100a_e6d6, 0xb3); goto l_0x100a_e6d6; /* jmp 0x100ae6d6 */
        l_0x100a_e623:
            ii(0x100a_e623, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100a_e626, 3); shl(edx, 0x16);                         /* shl edx, 0x16 */
            ii(0x100a_e629, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x100a_e62d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_e62f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_e632, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_e634, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_e637, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100a_e63a, 3); shl(edx, 0x16);                         /* shl edx, 0x16 */
            ii(0x100a_e63d, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x100a_e641, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_e643, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_e646, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_e648, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_e64b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_e652, 2); jmpd(0x100a_e65a, 0x6); goto l_0x100a_e65a; /* jmp 0x100ae65a */
        l_0x100a_e654:
            ii(0x100a_e654, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_e657, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_e65a:
            ii(0x100a_e65a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_e65d, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_e661, 2); if(jged(0x100a_e6d2, 0x6f)) goto l_0x100a_e6d2; /* jge 0x100ae6d2 */
            ii(0x100a_e663, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e666, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e669, 5); calld(0x1007_6574, -0x3_80fa);          /* call 0x10076574 */
            ii(0x100a_e66e, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x100a_e671, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e674, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_e678, 4); imul(eax, memd_a32[ss, ebp - 0x1c]);    /* imul eax, [ebp-0x1c] */
            ii(0x100a_e67c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e67f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_e681, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100a_e684, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100a_e688, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e68b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e68e, 5); calld(0x1007_6574, -0x3_811f);          /* call 0x10076574 */
            ii(0x100a_e693, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x100a_e696, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e699, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_e69d, 4); imul(eax, memd_a32[ss, ebp - 0x18]);    /* imul eax, [ebp-0x18] */
            ii(0x100a_e6a1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e6a4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_e6a6, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100a_e6a9, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x100a_e6ad, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100a_e6b1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_e6b4, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x100a_e6b7, 4); movsx(edx, memw_a32[ss, ebp - 0x22]);   /* movsx edx, word [ebp-0x22] */
            ii(0x100a_e6bb, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100a_e6bd, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_e6bf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_e6c1, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100a_e6c4, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100a_e6c8, 2); if(jld(0x100a_e6d0, 0x6)) goto l_0x100a_e6d0; /* jl 0x100ae6d0 */
            ii(0x100a_e6ca, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_e6ce, 2); jmpd(0x100a_e6d6, 0x6); goto l_0x100a_e6d6; /* jmp 0x100ae6d6 */
        l_0x100a_e6d0:
            ii(0x100a_e6d0, 2); jmpd(0x100a_e654, -0x7e); goto l_0x100a_e654; /* jmp 0x100ae654 */
        l_0x100a_e6d2:
            ii(0x100a_e6d2, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_e6d6:
            ii(0x100a_e6d6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_e6d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_e6db, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_e6dc, 1); popd(edi);                              /* pop edi */
            ii(0x100a_e6dd, 1); popd(esi);                              /* pop esi */
            ii(0x100a_e6de, 1); popd(edx);                              /* pop edx */
            ii(0x100a_e6df, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_e6e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_e6e1, 1); retd(); return;                         /* ret */
        }
    }
}
