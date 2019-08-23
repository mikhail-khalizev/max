using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a48b-9d326494")]
        public void Method_100e_a48b()
        {
            ii(0x100e_a48b, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_a490, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b8bd); /* call 0x10165d52 */
            ii(0x100e_a495, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a496, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a497, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a498, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a49a, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_a4a0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a4a3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_a4a6, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100e_a4a9, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100e_a4ac, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100e_a4af, 3); add(eax, memd_a32[ss, ebp + 0x1c]);     /* add eax, [ebp+0x1c] */
            ii(0x100e_a4b2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_a4b5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a4b8, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_a4bc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_a4bf, 2); jmpd(0x100e_a4c7, 0x6); goto l_0x100e_a4c7; /* jmp 0x100ea4c7 */
        l_0x100e_a4c1:
            ii(0x100e_a4c1, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_a4c4, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x100e_a4c7:
            ii(0x100e_a4c7, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_a4cb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a4ce, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x100e_a4d1, 6); if(jged(0x100e_a5f3, 0x11c)) goto l_0x100e_a5f3; /* jge 0x100ea5f3 */
            ii(0x100e_a4d7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a4da, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_a4dd, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_a4e0, 2); jmpd(0x100e_a4e8, 0x6); goto l_0x100e_a4e8; /* jmp 0x100ea4e8 */
        l_0x100e_a4e2:
            ii(0x100e_a4e2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_a4e5, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x100e_a4e8:
            ii(0x100e_a4e8, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100e_a4ec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a4ef, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x100e_a4f2, 6); if(jged(0x100e_a5ee, 0xf6)) goto l_0x100e_a5ee; /* jge 0x100ea5ee */
            ii(0x100e_a4f8, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_a4fc, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a500, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a503, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_a507, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_a509, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_a50c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a50e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_a510, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x100e_a512, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100e_a516, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x100e_a519, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100e_a51c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_a51e, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a521, 5); calld(/* sys */ 0x1016_cae8, 0x8_25c2); /* call 0x1016cae8 */
            ii(0x100e_a526, 5); and(eax, 0x7c00);                       /* and eax, 0x7c00 */
            ii(0x100e_a52b, 3); sar(eax, 0xa);                          /* sar eax, 0xa */
            ii(0x100e_a52e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_a530, 4); movsx(eax, memw_a32[ss, ebp + 0x1c]);   /* movsx eax, word [ebp+0x1c] */
            ii(0x100e_a534, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_a537, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_a53b, 4); movsx(ebx, memw_a32[ss, ebp + 0x18]);   /* movsx ebx, word [ebp+0x18] */
            ii(0x100e_a53f, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x100e_a542, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a544, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a548, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a54a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a54d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a54f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_a552, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_a554, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a557, 5); calld(/* sys */ 0x1016_cae8, 0x8_258c); /* call 0x1016cae8 */
            ii(0x100e_a55c, 5); and(eax, 0x3e0);                        /* and eax, 0x3e0 */
            ii(0x100e_a561, 3); sar(eax, 0x5);                          /* sar eax, 0x5 */
            ii(0x100e_a564, 4); movsx(ebx, memw_a32[ss, ebp + 0x1c]);   /* movsx ebx, word [ebp+0x1c] */
            ii(0x100e_a568, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100e_a56b, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100e_a56f, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100e_a573, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a576, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100e_a578, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a57c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a57e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a581, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a583, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_a586, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_a588, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a58b, 5); calld(/* sys */ 0x1016_cae8, 0x8_2558); /* call 0x1016cae8 */
            ii(0x100e_a590, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x100e_a593, 4); movsx(edx, memw_a32[ss, ebp + 0x1c]);   /* movsx edx, word [ebp+0x1c] */
            ii(0x100e_a597, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a59a, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100e_a59e, 4); movsx(ebx, memw_a32[ss, ebp + 0x18]);   /* movsx ebx, word [ebp+0x18] */
            ii(0x100e_a5a2, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_a5a5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a5a7, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a5ab, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a5ad, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a5b0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a5b2, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_a5b5, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_a5b9, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x100e_a5bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_a5be, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_a5c2, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100e_a5c5, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x100e_a5c7, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100e_a5cb, 2); or(edx, eax);                           /* or edx, eax */
            ii(0x100e_a5cd, 4); movsx(ebx, memw_a32[ss, ebp - 0x20]);   /* movsx ebx, word [ebp-0x20] */
            ii(0x100e_a5d1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a5d5, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_a5d8, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100e_a5dc, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_a5de, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_a5e1, 6); mov(dl, memb_a32[ds, edx + 0x1020_0520]); /* mov dl, [edx+0x10200520] */
            ii(0x100e_a5e7, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_a5e9, 5); jmpd(0x100e_a4e2, -0x10c); goto l_0x100e_a4e2; /* jmp 0x100ea4e2 */
        l_0x100e_a5ee:
            ii(0x100e_a5ee, 5); jmpd(0x100e_a4c1, -0x132); goto l_0x100e_a4c1; /* jmp 0x100ea4c1 */
        l_0x100e_a5f3:
            ii(0x100e_a5f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a5f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a5f6, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a5f7, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a5f8, 3); retd(0x10);                             /* ret 0x10 */
        }
    }
}
