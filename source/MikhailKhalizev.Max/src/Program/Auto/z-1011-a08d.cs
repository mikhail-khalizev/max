using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a08d-8efa5458")]
        public void Method_1011_a08d()
        {
            ii(0x1011_a08d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_a092, 5); calld(Definitions.sys_check_available_stack_size, 0x4_bcbb); /* call 0x10165d52 */
            ii(0x1011_a097, 1); pushd(esi);                             /* push esi */
            ii(0x1011_a098, 1); pushd(edi);                             /* push edi */
            ii(0x1011_a099, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_a09a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_a09c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_a0a2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_a0a5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_a0a8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_a0ab, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1011_a0ae, 7); cmp(memb_a32[ds, 0x101c_37ca], 0);      /* cmp byte [0x101c37ca], 0x0 */
            ii(0x1011_a0b5, 2); if(jzd(0x1011_a0c0, 0x9)) goto l_0x1011_a0c0; /* jz 0x1011a0c0 */
            ii(0x1011_a0b7, 7); mov(memd_a32[ss, ebp - 0x18], 0x10);    /* mov dword [ebp-0x18], 0x10 */
            ii(0x1011_a0be, 2); jmpd(0x1011_a0c7, 0x7); goto l_0x1011_a0c7; /* jmp 0x1011a0c7 */
        l_0x1011_a0c0:
            ii(0x1011_a0c0, 7); mov(memd_a32[ss, ebp - 0x18], 0x8);     /* mov dword [ebp-0x18], 0x8 */
        l_0x1011_a0c7:
            ii(0x1011_a0c7, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1011_a0ca, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_a0cd, 3); mov(memb_a32[ds, edx + 0x2a], al);      /* mov [edx+0x2a], al */
            ii(0x1011_a0d0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a0d3, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1011_a0d8, 2); if(jzd(0x1011_a0e4, 0xa)) goto l_0x1011_a0e4; /* jz 0x1011a0e4 */
            ii(0x1011_a0da, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a0dd, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1011_a0e2, 2); if(jnzd(0x1011_a0f6, 0x12)) goto l_0x1011_a0f6; /* jnz 0x1011a0f6 */
        l_0x1011_a0e4:
            ii(0x1011_a0e4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a0e7, 3); shr(memb_a32[ds, eax + 0x2a], 0x1);     /* shr byte [eax+0x2a], 1 */
            ii(0x1011_a0ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a0ed, 3); mov(dl, memb_a32[ds, eax + 0x2a]);      /* mov dl, [eax+0x2a] */
            ii(0x1011_a0f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a0f3, 3); mov(memb_a32[ds, eax + 0x2b], dl);      /* mov [eax+0x2b], dl */
        l_0x1011_a0f6:
            ii(0x1011_a0f6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_a0fa, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_a0fd, 2); if(jled(0x1011_a107, 0x8)) goto l_0x1011_a107; /* jle 0x1011a107 */
            ii(0x1011_a0ff, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a102, 3); shr(memb_a32[ds, eax + 0x2a], 0x1);     /* shr byte [eax+0x2a], 1 */
            ii(0x1011_a105, 2); jmpd(0x1011_a116, 0xf); goto l_0x1011_a116; /* jmp 0x1011a116 */
        l_0x1011_a107:
            ii(0x1011_a107, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_a10b, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_a10e, 2); if(jged(0x1011_a116, 0x6)) goto l_0x1011_a116; /* jge 0x1011a116 */
            ii(0x1011_a110, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a113, 3); shl(memb_a32[ds, eax + 0x2a], 0x1);     /* shl byte [eax+0x2a], 1 */
        l_0x1011_a116:
            ii(0x1011_a116, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_a11a, 2); if(jzd(0x1011_a142, 0x26)) goto l_0x1011_a142; /* jz 0x1011a142 */
            ii(0x1011_a11c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a120, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1011_a123, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_a125, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_a128, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_a12a, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_a12c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_a12f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_a133, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1011_a136, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_a138, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_a13b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_a13d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_a13f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1011_a142:
            ii(0x1011_a142, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_a149, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a14c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a14e, 3); mov(dl, memb_a32[ds, eax + 0x64]);      /* mov dl, [eax+0x64] */
            ii(0x1011_a151, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_a155, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_a157, 2); if(jled(0x1011_a162, 0x9)) goto l_0x1011_a162; /* jle 0x1011a162 */
            ii(0x1011_a159, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_a15c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_a15f, 3); mov(memb_a32[ds, edx + 0x64], al);      /* mov [edx+0x64], al */
        l_0x1011_a162:
            ii(0x1011_a162, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_a165, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_a167, 3); mov(al, memb_a32[ds, edx + 0x64]);      /* mov al, [edx+0x64] */
            ii(0x1011_a16a, 4); sub(memw_a32[ss, ebp - 0xc], ax);       /* sub [ebp-0xc], ax */
            ii(0x1011_a16e, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a172, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1011_a175, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_a177, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_a17a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_a17d, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1011_a17f, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1011_a182, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_a185, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a188, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1011_a18b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a190, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_a194, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_a196, 2); if(jgd(0x1011_a1bd, 0x25)) goto l_0x1011_a1bd; /* jg 0x1011a1bd */
            ii(0x1011_a198, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_a19c, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_a1a0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1a3, 5); calld(0x1011_890d, -0x189b);            /* call 0x1011890d */
            ii(0x1011_a1a8, 3); mov(dl, memb_a32[ss, ebp - 0x1c]);      /* mov dl, [ebp-0x1c] */
            ii(0x1011_a1ab, 3); shl(dl, 0x2);                           /* shl dl, 0x2 */
            ii(0x1011_a1ae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1b1, 3); sub(dl, memb_a32[ss, ebp - 0xc]);       /* sub dl, [ebp-0xc] */
            ii(0x1011_a1b4, 3); mov(memb_a32[ds, eax + 0x64], dl);      /* mov [eax+0x64], dl */
            ii(0x1011_a1b7, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_a1bb, 2); jmpd(0x1011_a1e7, 0x2a); goto l_0x1011_a1e7; /* jmp 0x1011a1e7 */
        l_0x1011_a1bd:
            ii(0x1011_a1bd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1c0, 3); mov(dl, memb_a32[ds, eax + 0x4e]);      /* mov dl, [eax+0x4e] */
            ii(0x1011_a1c3, 3); shl(dl, 0x2);                           /* shl dl, 0x2 */
            ii(0x1011_a1c6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1c9, 3); add(memb_a32[ds, eax + 0x64], dl);      /* add [eax+0x64], dl */
            ii(0x1011_a1cc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1cf, 4); mov(memb_a32[ds, eax + 0x4e], 0);       /* mov byte [eax+0x4e], 0x0 */
            ii(0x1011_a1d3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1d6, 4); cmp(memb_a32[ds, eax + 0x4f], 0);       /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_a1da, 2); if(jzd(0x1011_a1e3, 0x7)) goto l_0x1011_a1e3; /* jz 0x1011a1e3 */
            ii(0x1011_a1dc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_a1df, 4); mov(memb_a32[ds, eax + 0x4f], 0x1);     /* mov byte [eax+0x4f], 0x1 */
        l_0x1011_a1e3:
            ii(0x1011_a1e3, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1011_a1e7:
            ii(0x1011_a1e7, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1011_a1ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_a1ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_a1ed, 1); popd(edi);                              /* pop edi */
            ii(0x1011_a1ee, 1); popd(esi);                              /* pop esi */
            ii(0x1011_a1ef, 1); retd();                                 /* ret */
        }
    }
}
