using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cfc2-a83cdd47")]
        public void Method_1007_cfc2()
        {
            ii(0x1007_cfc2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_cfc7, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8d86); /* call 0x10165d52 */
            ii(0x1007_cfcc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_cfcd, 1); pushd(esi);                             /* push esi */
            ii(0x1007_cfce, 1); pushd(edi);                             /* push edi */
            ii(0x1007_cfcf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_cfd0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cfd2, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_cfd8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_cfdb, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_cfde, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_cfe1, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_cfe8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_cfeb, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1007_cfee, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_cff3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_cff5, 2); if(jled(0x1007_d000, 0x9)) goto l_0x1007_d000; /* jle 0x1007d000 */
            ii(0x1007_cff7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_cffa, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_cffe, 2); if(jnzd(0x1007_d002, 0x2)) goto l_0x1007_d002; /* jnz 0x1007d002 */
        l_0x1007_d000:
            ii(0x1007_d000, 2); jmpd(0x1007_d03c, 0x3a); goto l_0x1007_d03c; /* jmp 0x1007d03c */
        l_0x1007_d002:
            ii(0x1007_d002, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d005, 5); calld(0x1007_623c, -0x6dce);            /* call 0x1007623c */
            ii(0x1007_d00a, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1007_d00d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_d010, 3); cmp(eax, 0x23);                         /* cmp eax, 0x23 */
            ii(0x1007_d013, 2); if(jled(0x1007_d01b, 0x6)) goto l_0x1007_d01b; /* jle 0x1007d01b */
            ii(0x1007_d015, 4); add(memd_a32[ss, ebp - 0x14], 0x38);    /* add dword [ebp-0x14], 0x38 */
            ii(0x1007_d019, 2); jmpd(0x1007_d03c, 0x21); goto l_0x1007_d03c; /* jmp 0x1007d03c */
        l_0x1007_d01b:
            ii(0x1007_d01b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d01e, 5); calld(0x1007_623c, -0x6de7);            /* call 0x1007623c */
            ii(0x1007_d023, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x1007_d026, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_d029, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_d02b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_d02e, 3); shl(edx, 0x3);                          /* shl edx, 0x3 */
            ii(0x1007_d031, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1007_d033, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x1007_d036, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1007_d039, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1007_d03c:
            ii(0x1007_d03c, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_d040, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d043, 5); calld(0x1007_6074, -0x6fd4);            /* call 0x10076074 */
            ii(0x1007_d048, 2); test(al, al);                           /* test al, al */
            ii(0x1007_d04a, 2); if(jzd(0x1007_d053, 0x7)) goto l_0x1007_d053; /* jz 0x1007d053 */
            ii(0x1007_d04c, 7); add(memd_a32[ss, ebp - 0x14], 0x80);    /* add dword [ebp-0x14], 0x80 */
        l_0x1007_d053:
            ii(0x1007_d053, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d056, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_d059, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_d05e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_d061, 2); if(jnzd(0x1007_d067, 0x4)) goto l_0x1007_d067; /* jnz 0x1007d067 */
            ii(0x1007_d063, 4); add(memd_a32[ss, ebp - 0x14], 0x8);     /* add dword [ebp-0x14], 0x8 */
        l_0x1007_d067:
            ii(0x1007_d067, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1007_d06b, 6); if(jzd(0x1007_d130, 0xbf)) goto l_0x1007_d130; /* jz 0x1007d130 */
            ii(0x1007_d071, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_d074, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d077, 5); calld(0x1007_78a5, -0x57d7);            /* call 0x100778a5 */
            ii(0x1007_d07c, 2); test(al, al);                           /* test al, al */
            ii(0x1007_d07e, 2); if(jzd(0x1007_d0ba, 0x3a)) goto l_0x1007_d0ba; /* jz 0x1007d0ba */
            ii(0x1007_d080, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1007_d085, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_d088, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d08b, 5); calld(0x1015_c75a, 0xd_f6ca);           /* call 0x1015c75a */
            ii(0x1007_d090, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_d093, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1007_d098, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_d09a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_d09d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1007_d09f, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1007_d0a3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_d0a5, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1007_d0a8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_d0ab, 4); test(memb_a32[ds, edx + 0x13], 0x2);    /* test byte [edx+0x13], 0x2 */
            ii(0x1007_d0af, 2); if(jnzd(0x1007_d0b5, 0x4)) goto l_0x1007_d0b5; /* jnz 0x1007d0b5 */
            ii(0x1007_d0b1, 4); add(memd_a32[ss, ebp - 0x14], 0x40);    /* add dword [ebp-0x14], 0x40 */
        l_0x1007_d0b5:
            ii(0x1007_d0b5, 5); jmpd(0x1007_d130, 0x76); goto l_0x1007_d130; /* jmp 0x1007d130 */
        l_0x1007_d0ba:
            ii(0x1007_d0ba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_d0bd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d0c0, 5); calld(0x1007_cd41, -0x384);             /* call 0x1007cd41 */
            ii(0x1007_d0c5, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
            ii(0x1007_d0c8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d0cb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_d0cd, 3); mov(cl, memb_a32[ds, eax + 0x50]);      /* mov cl, [eax+0x50] */
            ii(0x1007_d0d0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_d0d2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_d0d5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d0d8, 5); calld(0x1015_d211, 0xe_0134);           /* call 0x1015d211 */
            ii(0x1007_d0dd, 1); cwde();                                 /* cwde */
            ii(0x1007_d0de, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1007_d0e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d0e4, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1007_d0e7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_d0ec, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1007_d0ee, 2); if(jld(0x1007_d130, 0x40)) goto l_0x1007_d130; /* jl 0x1007d130 */
            ii(0x1007_d0f0, 4); add(memd_a32[ss, ebp - 0x14], 0x40);    /* add dword [ebp-0x14], 0x40 */
            ii(0x1007_d0f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d0f7, 5); cmp(memw_a32[ds, eax + 0x8], 0x3f);     /* cmp word [eax+0x8], 0x3f */
            ii(0x1007_d0fc, 2); if(jzd(0x1007_d108, 0xa)) goto l_0x1007_d108; /* jz 0x1007d108 */
            ii(0x1007_d0fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d101, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1007_d106, 2); if(jnzd(0x1007_d10a, 0x2)) goto l_0x1007_d10a; /* jnz 0x1007d10a */
        l_0x1007_d108:
            ii(0x1007_d108, 2); jmpd(0x1007_d114, 0xa); goto l_0x1007_d114; /* jmp 0x1007d114 */
        l_0x1007_d10a:
            ii(0x1007_d10a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d10d, 5); cmp(memw_a32[ds, eax + 0x8], 0x3a);     /* cmp word [eax+0x8], 0x3a */
            ii(0x1007_d112, 2); if(jnzd(0x1007_d116, 0x2)) goto l_0x1007_d116; /* jnz 0x1007d116 */
        l_0x1007_d114:
            ii(0x1007_d114, 2); jmpd(0x1007_d120, 0xa); goto l_0x1007_d120; /* jmp 0x1007d120 */
        l_0x1007_d116:
            ii(0x1007_d116, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d119, 5); cmp(memw_a32[ds, eax + 0x8], 0x5);      /* cmp word [eax+0x8], 0x5 */
            ii(0x1007_d11e, 2); if(jnzd(0x1007_d122, 0x2)) goto l_0x1007_d122; /* jnz 0x1007d122 */
        l_0x1007_d120:
            ii(0x1007_d120, 2); jmpd(0x1007_d12c, 0xa); goto l_0x1007_d12c; /* jmp 0x1007d12c */
        l_0x1007_d122:
            ii(0x1007_d122, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d125, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1007_d12a, 2); if(jnzd(0x1007_d130, 0x4)) goto l_0x1007_d130; /* jnz 0x1007d130 */
        l_0x1007_d12c:
            ii(0x1007_d12c, 4); add(memd_a32[ss, ebp - 0x14], 0x38);    /* add dword [ebp-0x14], 0x38 */
        l_0x1007_d130:
            ii(0x1007_d130, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1007_d135, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x1007_d138, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_d13b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_d13e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d140, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d141, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d142, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d143, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d144, 1); retd(); return;                         /* ret */
        }
    }
}
