using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e3c6-7c1a98ff")]
        public void Method_1015_e3c6()
        {
            ii(0x1015_e3c6, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_e3cb, 5); calld(Definitions.sys_check_available_stack_size, 0x7982); /* call 0x10165d52 */
            ii(0x1015_e3d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_e3d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_e3d2, 1); pushd(edx);                             /* push edx */
            ii(0x1015_e3d3, 1); pushd(esi);                             /* push esi */
            ii(0x1015_e3d4, 1); pushd(edi);                             /* push edi */
            ii(0x1015_e3d5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_e3d6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_e3d8, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_e3de, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1015_e3e3, 5); calld(0x1007_5fdc, -0xe_840c);          /* call 0x10075fdc */
            ii(0x1015_e3e8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e3ea, 2); if(jzd(0x1015_e3f5, 0x9)) goto l_0x1015_e3f5; /* jz 0x1015e3f5 */
            ii(0x1015_e3ec, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1015_e3f0, 5); jmpd(0x1015_e55a, 0x165); goto l_0x1015_e55a; /* jmp 0x1015e55a */
        l_0x1015_e3f5:
            ii(0x1015_e3f5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_e3f9, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_e400, 2); jmpd(0x1015_e408, 0x6); goto l_0x1015_e408; /* jmp 0x1015e408 */
        l_0x1015_e402:
            ii(0x1015_e402, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_e405, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1015_e408:
            ii(0x1015_e408, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1015_e40c, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1015_e40f, 2); if(jged(0x1015_e448, 0x37)) goto l_0x1015_e448; /* jge 0x1015e448 */
            ii(0x1015_e411, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1015_e415, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1015_e418, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_e41d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_e41f, 5); calld(0x1007_6b90, -0xe_7894);          /* call 0x10076b90 */
            ii(0x1015_e424, 1); cwde();                                 /* cwde */
            ii(0x1015_e425, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e427, 2); if(jgd(0x1015_e442, 0x19)) goto l_0x1015_e442; /* jg 0x1015e442 */
            ii(0x1015_e429, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e42b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1015_e42f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_e432, 5); mov(ebx, 0x101c_94b4);                  /* mov ebx, 0x101c94b4 */
            ii(0x1015_e437, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_e439, 5); calld(0x1013_ad71, -0x2_36cd);          /* call 0x1013ad71 */
            ii(0x1015_e43e, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e440, 2); if(jzd(0x1015_e446, 0x4)) goto l_0x1015_e446; /* jz 0x1015e446 */
        l_0x1015_e442:
            ii(0x1015_e442, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1015_e446:
            ii(0x1015_e446, 2); jmpd(0x1015_e402, -0x46); goto l_0x1015_e402; /* jmp 0x1015e402 */
        l_0x1015_e448:
            ii(0x1015_e448, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_e44a, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_e44d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e44f, 2); if(jnzd(0x1015_e461, 0x10)) goto l_0x1015_e461; /* jnz 0x1015e461 */
            ii(0x1015_e451, 7); mov(memb_a32[ds, 0x101c_8170], 0);      /* mov byte [0x101c8170], 0x0 */
            ii(0x1015_e458, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1015_e45c, 5); jmpd(0x1015_e55a, 0xf9); goto l_0x1015_e55a; /* jmp 0x1015e55a */
        l_0x1015_e461:
            ii(0x1015_e461, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1015_e466, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e469, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e46f, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_e475, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e47a, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1015_e47d, 2); if(jnzd(0x1015_e488, 0x9)) goto l_0x1015_e488; /* jnz 0x1015e488 */
            ii(0x1015_e47f, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_e483, 5); jmpd(0x1015_e55a, 0xd2); goto l_0x1015_e55a; /* jmp 0x1015e55a */
        l_0x1015_e488:
            ii(0x1015_e488, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_e48c, 6); mov(ax, memw_a32[ds, 0x101c_8168]);     /* mov ax, [0x101c8168] */
            ii(0x1015_e492, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1015_e495:
            ii(0x1015_e495, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1015_e49a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e49d, 5); calld(0x1015_db0e, -0x994);             /* call 0x1015db0e */
            ii(0x1015_e4a2, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e4a4, 2); if(jzd(0x1015_e4aa, 0x4)) goto l_0x1015_e4aa; /* jz 0x1015e4aa */
            ii(0x1015_e4a6, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1015_e4aa:
            ii(0x1015_e4aa, 6); mov(edx, memd_a32[ds, 0x101c_8166]);    /* mov edx, [0x101c8166] */
            ii(0x1015_e4b0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_e4b3, 1); inc(edx);                               /* inc edx */
            ii(0x1015_e4b4, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1015_e4b9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_e4bb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_e4be, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_e4c0, 7); mov(memw_a32[ds, 0x101c_8168], dx);     /* mov [0x101c8168], dx */
            ii(0x1015_e4c7, 6); mov(edx, memd_a32[ds, 0x101c_8166]);    /* mov edx, [0x101c8166] */
            ii(0x1015_e4cd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_e4d0, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1015_e4d6, 6); mov(dl, memb_a32[ds, edx + 0x101c_a490]); /* mov dl, [edx+0x101ca490] */
            ii(0x1015_e4dc, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1015_e4e2, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1015_e4e5, 2); if(jnzd(0x1015_e531, 0x4a)) goto l_0x1015_e531; /* jnz 0x1015e531 */
            ii(0x1015_e4e7, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_e4eb, 2); if(jzd(0x1015_e4f6, 0x9)) goto l_0x1015_e4f6; /* jz 0x1015e4f6 */
            ii(0x1015_e4ed, 7); mov(memb_a32[ds, 0x101c_8170], 0x1);    /* mov byte [0x101c8170], 0x1 */
            ii(0x1015_e4f4, 2); jmpd(0x1015_e50d, 0x17); goto l_0x1015_e50d; /* jmp 0x1015e50d */
        l_0x1015_e4f6:
            ii(0x1015_e4f6, 7); cmp(memb_a32[ds, 0x101c_8170], 0);      /* cmp byte [0x101c8170], 0x0 */
            ii(0x1015_e4fd, 2); if(jnzd(0x1015_e506, 0x7)) goto l_0x1015_e506; /* jnz 0x1015e506 */
            ii(0x1015_e4ff, 5); calld(0x1015_e35d, -0x1a7);             /* call 0x1015e35d */
            ii(0x1015_e504, 2); jmpd(0x1015_e50d, 0x7); goto l_0x1015_e50d; /* jmp 0x1015e50d */
        l_0x1015_e506:
            ii(0x1015_e506, 7); mov(memb_a32[ds, 0x101c_8170], 0);      /* mov byte [0x101c8170], 0x0 */
        l_0x1015_e50d:
            ii(0x1015_e50d, 6); inc(memd_a32[ds, 0x101c_816c]);         /* inc dword [0x101c816c] */
            ii(0x1015_e513, 6); mov(ebx, memd_a32[ds, 0x101c_816c]);    /* mov ebx, [0x101c816c] */
            ii(0x1015_e519, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e51b, 3); mov(dl, memb_a32[ss, ebp - 0x8]);       /* mov dl, [ebp-0x8] */
            ii(0x1015_e51e, 5); mov(eax, memd_a32[ds, 0x101c_8166]);    /* mov eax, [0x101c8166] */
            ii(0x1015_e523, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e526, 5); calld(0x1012_b31a, -0x3_3211);          /* call 0x1012b31a */
            ii(0x1015_e52b, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_e52f, 2); jmpd(0x1015_e55a, 0x29); goto l_0x1015_e55a; /* jmp 0x1015e55a */
        l_0x1015_e531:
            ii(0x1015_e531, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_e535, 2); if(jzd(0x1015_e53d, 0x6)) goto l_0x1015_e53d; /* jz 0x1015e53d */
            ii(0x1015_e537, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_e53b, 2); jmpd(0x1015_e55a, 0x1d); goto l_0x1015_e55a; /* jmp 0x1015e55a */
        l_0x1015_e53d:
            ii(0x1015_e53d, 6); mov(ax, memw_a32[ds, 0x101c_8168]);     /* mov ax, [0x101c8168] */
            ii(0x1015_e543, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1015_e547, 6); if(jnzd(0x1015_e495, -0xb8)) goto l_0x1015_e495; /* jnz 0x1015e495 */
            ii(0x1015_e54d, 5); calld(0x1015_e35d, -0x1f5);             /* call 0x1015e35d */
            ii(0x1015_e552, 5); calld(0x1015_deb9, -0x69e);             /* call 0x1015deb9 */
            ii(0x1015_e557, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
        l_0x1015_e55a:
            ii(0x1015_e55a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1015_e55d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e55f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_e560, 1); popd(edi);                              /* pop edi */
            ii(0x1015_e561, 1); popd(esi);                              /* pop esi */
            ii(0x1015_e562, 1); popd(edx);                              /* pop edx */
            ii(0x1015_e563, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_e564, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_e565, 1); retd(); return;                         /* ret */
        }
    }
}
