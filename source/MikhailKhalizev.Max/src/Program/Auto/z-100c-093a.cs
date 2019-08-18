using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_093a-48386fe9")]
        public void Method_100c_093a()
        {
            ii(0x100c_093a, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100c_093f, 5); calld(Definitions.sys_check_available_stack_size, 0xa_540e); /* call 0x10165d52 */
            ii(0x100c_0944, 1); pushd(esi);                             /* push esi */
            ii(0x100c_0945, 1); pushd(edi);                             /* push edi */
            ii(0x100c_0946, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_0947, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0949, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100c_094f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_0952, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_0955, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_0958, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100c_095b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_095e, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_9e73); /* call 0x10076af0 */
            ii(0x100c_0963, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_0966, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_9e7b); /* call 0x10076af0 */
            ii(0x100c_096b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_096e, 4); imul(eax, memd_a32[ss, ebp - 0x4]);     /* imul eax, [ebp-0x4] */
            ii(0x100c_0972, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_0975, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_0977, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_097a, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_097d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_0981, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100c_0983, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_0985, 5); calld(0x1007_6e7c, -0x4_9b0e);          /* call 0x10076e7c */
            ii(0x100c_098a, 1); dec(eax);                               /* dec eax */
            ii(0x100c_098b, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x100c_098f, 6); mov(memw_a32[ss, ebp - 0x12], 0);       /* mov word [ebp-0x12], 0x0 */
            ii(0x100c_0995, 6); mov(memw_a32[ss, ebp - 0x16], 0);       /* mov word [ebp-0x16], 0x0 */
            ii(0x100c_099b, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100c_09a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_09a3, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x100c_09a6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_09a9, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_09ac, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_09b0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_09b2, 5); calld(Definitions.my_min, -0x3_7233);   /* call 0x10089784 */
            ii(0x100c_09b7, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
        l_0x100c_09bb:
            ii(0x100c_09bb, 4); inc(memw_a32[ss, ebp - 0x12]);          /* inc word [ebp-0x12] */
            ii(0x100c_09bf, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100c_09c2, 4); cmp(ax, memw_a32[ss, ebp - 0x16]);      /* cmp ax, [ebp-0x16] */
            ii(0x100c_09c6, 6); if(jled(0x100c_0a7a, 0xae)) goto l_0x100c_0a7a; /* jle 0x100c0a7a */
            ii(0x100c_09cc, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
            ii(0x100c_09d0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_09d3, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100c_09d7, 6); if(jgd(0x100c_0aa6, 0xc9)) goto l_0x100c_0aa6; /* jg 0x100c0aa6 */
            ii(0x100c_09dd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_09e0, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100c_09e3, 3); sub(dx, memw_a32[ds, eax]);             /* sub dx, [eax] */
            ii(0x100c_09e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_09e9, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x100c_09ec, 3); sub(bx, memw_a32[ds, eax]);             /* sub bx, [eax] */
            ii(0x100c_09ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_09f1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_09f4, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x100c_09f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_09fa, 4); mov(memw_a32[ss, ebp - 0x12], ax);      /* mov [ebp-0x12], ax */
            ii(0x100c_09fe, 2); jmpd(0x100c_0a07, 0x7); goto l_0x100c_0a07; /* jmp 0x100c0a07 */
        l_0x100c_0a00:
            ii(0x100c_0a00, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100c_0a03, 4); dec(memw_a32[ss, ebp - 0x12]);          /* dec word [ebp-0x12] */
        l_0x100c_0a07:
            ii(0x100c_0a07, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100c_0a0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0a0d, 2); if(jld(0x100c_0a28, 0x19)) goto l_0x100c_0a28; /* jl 0x100c0a28 */
            ii(0x100c_0a0f, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_0a13, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100c_0a17, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_0a1a, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_0a1e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_0a20, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_0a24, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_0a26, 2); if(jgd(0x100c_0a00, -0x28)) goto l_0x100c_0a00; /* jg 0x100c0a00 */
        l_0x100c_0a28:
            ii(0x100c_0a28, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100c_0a2d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_0a30, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x100c_0a33, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0a36, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x100c_0a38, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_0a3b, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x100c_0a3f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_0a41, 5); calld(Definitions.my_min, -0x3_72c2);   /* call 0x10089784 */
            ii(0x100c_0a46, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x100c_0a4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_0a4c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0a4f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_0a51, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_0a54, 4); movsx(ebx, memw_a32[ss, ebp - 0x12]);   /* movsx ebx, word [ebp-0x12] */
            ii(0x100c_0a58, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100c_0a5a, 5); calld(0x1007_6e7c, -0x4_9be3);          /* call 0x10076e7c */
            ii(0x100c_0a5f, 4); mov(memw_a32[ss, ebp - 0x12], ax);      /* mov [ebp-0x12], ax */
            ii(0x100c_0a63, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_0a67, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_0a6a, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100c_0a6d, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x100c_0a71, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_0a73, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_0a75, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_0a77, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100c_0a7a:
            ii(0x100c_0a7a, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x100c_0a7e, 2); if(jzd(0x100c_0a8a, 0xa)) goto l_0x100c_0a8a; /* jz 0x100c0a8a */
            ii(0x100c_0a80, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_0a83, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_0a86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0a88, 2); if(jld(0x100c_0a8c, 0x2)) goto l_0x100c_0a8c; /* jl 0x100c0a8c */
        l_0x100c_0a8a:
            ii(0x100c_0a8a, 2); jmpd(0x100c_0a94, 0x8); goto l_0x100c_0a94; /* jmp 0x100c0a94 */
        l_0x100c_0a8c:
            ii(0x100c_0a8c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_0a8f, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
        l_0x100c_0a94:
            ii(0x100c_0a94, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_0a97, 4); add(memd_a32[ss, ebp - 0x24], 0x2);     /* add dword [ebp-0x24], 0x2 */
            ii(0x100c_0a9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_0a9e, 3); add(memw_a32[ds, edx], ax);             /* add [edx], ax */
            ii(0x100c_0aa1, 5); jmpd(0x100c_09bb, -0xeb); goto l_0x100c_09bb; /* jmp 0x100c09bb */
        l_0x100c_0aa6:
            ii(0x100c_0aa6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_0aa8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_0aa9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_0aaa, 1); popd(esi);                              /* pop esi */
            ii(0x100c_0aab, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
