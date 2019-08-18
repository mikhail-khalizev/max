using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34214a10-cd6f-4116-921c-61bde57ec692")]
        public void Method_100b_6599()
        {
            ii(0x100b_6599, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100b_659e, 5); calld(Definitions.sys_check_available_stack_size, 0xa_f7af); /* call 0x10165d52 */
            ii(0x100b_65a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_65a4, 1); pushd(esi);                             /* push esi */
            ii(0x100b_65a5, 1); pushd(edi);                             /* push edi */
            ii(0x100b_65a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_65a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_65a9, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100b_65af, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_65b2, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_65b5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_65b8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_65ba, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_65bf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_65c1, 2); if(jnzd(0x100b_65d8, 0x15)) goto l_0x100b_65d8; /* jnz 0x100b65d8 */
            ii(0x100b_65c3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_65c6, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_65c9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_65cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_65ce, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_65d4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_65d6, 2); if(jnzd(0x100b_65da, 0x2)) goto l_0x100b_65da; /* jnz 0x100b65da */
        l_0x100b_65d8:
            ii(0x100b_65d8, 2); jmpd(0x100b_65df, 0x5); goto l_0x100b_65df; /* jmp 0x100b65df */
        l_0x100b_65da:
            ii(0x100b_65da, 5); jmpd(0x100b_6703, 0x124); goto l_0x100b_6703; /* jmp 0x100b6703 */
        l_0x100b_65df:
            ii(0x100b_65df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_65e2, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_65e7, 2); if(jnzd(0x100b_6608, 0x1f)) goto l_0x100b_6608; /* jnz 0x100b6608 */
            ii(0x100b_65e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_65ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_65ef, 5); calld(0x1008_a998, -0x2_bc5c);          /* call 0x1008a998 */
            ii(0x100b_65f4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_65f6, 5); mov(edx, 0xf);                          /* mov edx, 0xf */
            ii(0x100b_65fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_65fe, 5); calld(0x1016_3053, 0xa_ca50);           /* call 0x10163053 */
            ii(0x100b_6603, 5); jmpd(0x100b_6703, 0xfb); goto l_0x100b_6703; /* jmp 0x100b6703 */
        l_0x100b_6608:
            ii(0x100b_6608, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_660b, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100b_660f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6612, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100b_6616, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_6619, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100b_661d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6620, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100b_6624, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6627, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_662a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_662f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_6632, 2); if(jged(0x100b_663b, 0x7)) goto l_0x100b_663b; /* jge 0x100b663b */
            ii(0x100b_6634, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6637, 4); mov(memb_a32[ds, eax + 0x4e], 0x2);     /* mov byte [eax+0x4e], 0x2 */
        l_0x100b_663b:
            ii(0x100b_663b, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100b_6640, 5); calld(Definitions.sys_new, 0xa_f7bb);   /* call 0x10165e00 */
            ii(0x100b_6645, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_6648, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_664b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_664e, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100b_6652, 2); if(jzd(0x100b_6679, 0x25)) goto l_0x100b_6679; /* jz 0x100b6679 */
            ii(0x100b_6654, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_6657, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_665a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_665d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_6660, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_6663, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_6666, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_6669, 5); calld(Definitions.my_ctor_c20, 0x6_38e8); /* call 0x10119f56 */
            ii(0x100b_666e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_6671, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_6674, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_6677, 2); jmpd(0x100b_667f, 0x6); goto l_0x100b_667f; /* jmp 0x100b667f */
        l_0x100b_6679:
            ii(0x100b_6679, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_667c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100b_667f:
            ii(0x100b_667f, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x100b_6682, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_6685, 5); calld(0x100a_b3b0, -0xb2da);            /* call 0x100ab3b0 */
            ii(0x100b_668a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_668d, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_6691, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6694, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100b_6698, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_669b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_669e, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_66a2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_66a5, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100b_66a9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_66ac, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_66af, 5); calld(0x100a_b2e0, -0xb3d4);            /* call 0x100ab2e0 */
            ii(0x100b_66b4, 5); calld(0x1011_aca3, 0x6_45ea);           /* call 0x1011aca3 */
            ii(0x100b_66b9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_66bc, 5); calld(0x100a_b33c, -0xb385);            /* call 0x100ab33c */
            ii(0x100b_66c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_66c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_66c6, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100b_66c9, 5); calld(0x1007_6a34, -0x3_fc9a);          /* call 0x10076a34 */
            ii(0x100b_66ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_66d1, 5); calld(0x1015_48ba, 0x9_e1e4);           /* call 0x101548ba */
            ii(0x100b_66d6, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100b_66db, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100b_66e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_66e3, 5); calld(0x1016_3053, 0xa_c96b);           /* call 0x10163053 */
            ii(0x100b_66e8, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100b_66ef, 2); if(jzd(0x100b_66f9, 0x8)) goto l_0x100b_66f9; /* jz 0x100b66f9 */
            ii(0x100b_66f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_66f4, 5); calld(0x1012_ae8d, 0x7_4794);           /* call 0x1012ae8d */
        l_0x100b_66f9:
            ii(0x100b_66f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_66fb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_66fe, 5); calld(0x100a_9f38, -0xc7cb);            /* call 0x100a9f38 */
        l_0x100b_6703:
            ii(0x100b_6703, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6705, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_6706, 1); popd(edi);                              /* pop edi */
            ii(0x100b_6707, 1); popd(esi);                              /* pop esi */
            ii(0x100b_6708, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_6709, 1); retd(); return;                         /* ret */
        }
    }
}
