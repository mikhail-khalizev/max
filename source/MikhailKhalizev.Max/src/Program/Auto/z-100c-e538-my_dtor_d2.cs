using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e538-20d83f8")]
        public void my_dtor_d2()
        {
            ii(0x100c_e538, 5); push(0x80);                             /* push 0x80 */
            ii(0x100c_e53d, 5); call(Definitions.sys_check_available_stack_size, 0x9_7810); /* call 0x10165d52 */
            ii(0x100c_e542, 1); push(ebx);                              /* push ebx */
            ii(0x100c_e543, 1); push(ecx);                              /* push ecx */
            ii(0x100c_e544, 1); push(esi);                              /* push esi */
            ii(0x100c_e545, 1); push(edi);                              /* push edi */
            ii(0x100c_e546, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e547, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e549, 6); sub(esp, 0x64);                         /* sub esp, 0x64 */
            ii(0x100c_e54f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_e552, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_e555, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e558, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100c_e55b, 6); if(jz(0x100c_e644, 0xe3)) goto l_0x100c_e644; /* jz 0x100ce644 */
            ii(0x100c_e561, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e564, 4); cmp(memd[ds, eax + 49], 0);             /* cmp dword [eax+0x31], 0x0 */
            ii(0x100c_e568, 6); if(jz(0x100c_e63a, 0xcc)) goto l_0x100c_e63a; /* jz 0x100ce63a */
            ii(0x100c_e56e, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_e573, 5); call(Definitions.sys_new, 0x9_7888);    /* call 0x10165e00 */
            ii(0x100c_e578, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_e57b, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_e57e, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_e581, 4); cmp(memd[ss, ebp - 36], 0);             /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100c_e585, 2); if(jz(0x100c_e5bf, 0x38)) goto l_0x100c_e5bf; /* jz 0x100ce5bf */
            ii(0x100c_e587, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e58a, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_e58d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_e590, 1); push(eax);                              /* push eax */
            ii(0x100c_e591, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e594, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_e597, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_e59a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e59d, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_e5a0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_e5a3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e5a6, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_e5a9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e5ac, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_e5af, 5); call(0x100d_7bdc, 0x9628);              /* call 0x100d7bdc */
            ii(0x100c_e5b4, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_e5b7, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100c_e5ba, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_e5bd, 2); jmp(0x100c_e5c5, 6); goto l_0x100c_e5c5; /* jmp 0x100ce5c5 */
        l_0x100c_e5bf:
            ii(0x100c_e5bf, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_e5c2, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x100c_e5c5:
            ii(0x100c_e5c5, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_e5c8, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100c_e5cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e5ce, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100c_e5d1, 3); mov(memd[ss, ebp - 54], eax);           /* mov [ebp-0x36], eax */
            ii(0x100c_e5d4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e5d7, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100c_e5da, 5); call(/* sys */ 0x1016_7dd4, 0x9_97f5);  /* call 0x10167dd4 */
            ii(0x100c_e5df, 3); mov(memd[ss, ebp - 50], eax);           /* mov [ebp-0x32], eax */
            ii(0x100c_e5e2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e5e5, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100c_e5e8, 5); call(/* sys */ 0x1016_7e3c, 0x9_984f);  /* call 0x10167e3c */
            ii(0x100c_e5ed, 4); mov(memw[ss, ebp - 56], ax);            /* mov [ebp-0x38], ax */
            ii(0x100c_e5f1, 3); lea(edx, memd[ss, ebp - 72]);           /* lea edx, [ebp-0x48] */
            ii(0x100c_e5f4, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100c_e5f7, 5); call(0x100d_7d74, 0x9778);              /* call 0x100d7d74 */
            ii(0x100c_e5fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e5ff, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_e601, 5); call(/* sys */ 0x1016_965c, 0x9_b056);  /* call 0x1016965c */
            ii(0x100c_e606, 3); lea(edx, memd[ss, ebp - 72]);           /* lea edx, [ebp-0x48] */
            ii(0x100c_e609, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100c_e60c, 5); call(0x100d_7f6c, 0x995b);              /* call 0x100d7f6c */
            ii(0x100c_e611, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100c_e614, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_e617, 4); cmp(memd[ss, ebp - 28], 0);             /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_e61b, 2); if(jz(0x100c_e631, 0x14)) goto l_0x100c_e631; /* jz 0x100ce631 */
            ii(0x100c_e61d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e61f, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_e622, 5); call(Definitions.my_dtor_d3, 0x970c);   /* call 0x100d7d33 */
            ii(0x100c_e627, 5); call(Definitions.sys_delete, 0x9_7938); /* call 0x10165f64 */
            ii(0x100c_e62c, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_e62f, 2); jmp(0x100c_e638, 7); goto l_0x100c_e638; /* jmp 0x100ce638 */
        l_0x100c_e631:
            ii(0x100c_e631, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x100c_e638:
            ii(0x100c_e638, 2); jmp(0x100c_e644, 0xa); goto l_0x100c_e644; /* jmp 0x100ce644 */
        l_0x100c_e63a:
            ii(0x100c_e63a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e63d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_e63f, 5); call(/* sys */ 0x1016_965c, 0x9_b018);  /* call 0x1016965c */
        l_0x100c_e644:
            ii(0x100c_e644, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e647, 4); cmp(memd[ds, eax + 12], 0);             /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_e64b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e64e, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_e651, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_e654, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_e658, 2); if(jz(0x100c_e66e, 0x14)) goto l_0x100c_e66e; /* jz 0x100ce66e */
            ii(0x100c_e65a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e65c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_e65f, 5); call(Definitions.my_dtor_d3, 0x96cf);   /* call 0x100d7d33 */
            ii(0x100c_e664, 5); call(Definitions.sys_delete, 0x9_78fb); /* call 0x10165f64 */
            ii(0x100c_e669, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100c_e66c, 2); jmp(0x100c_e675, 7); goto l_0x100c_e675; /* jmp 0x100ce675 */
        l_0x100c_e66e:
            ii(0x100c_e66e, 7); mov(memd[ss, ebp - 76], 0);             /* mov dword [ebp-0x4c], 0x0 */
        l_0x100c_e675:
            ii(0x100c_e675, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e678, 4); cmp(memd[ds, eax + 16], 0);             /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_e67c, 2); if(jz(0x100c_e6a8, 0x2a)) goto l_0x100c_e6a8; /* jz 0x100ce6a8 */
            ii(0x100c_e67e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e681, 3); mov(eax, memd[ds, eax + 16]);           /* mov eax, [eax+0x10] */
            ii(0x100c_e684, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_e687, 4); cmp(memd[ss, ebp - 80], 0);             /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100c_e68b, 2); if(jz(0x100c_e6a1, 0x14)) goto l_0x100c_e6a1; /* jz 0x100ce6a1 */
            ii(0x100c_e68d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e68f, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_e692, 5); call(Definitions.my_dtor_d3, 0x969c);   /* call 0x100d7d33 */
            ii(0x100c_e697, 5); call(Definitions.sys_delete, 0x9_78c8); /* call 0x10165f64 */
            ii(0x100c_e69c, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x100c_e69f, 2); jmp(0x100c_e6a8, 7); goto l_0x100c_e6a8; /* jmp 0x100ce6a8 */
        l_0x100c_e6a1:
            ii(0x100c_e6a1, 7); mov(memd[ss, ebp - 84], 0);             /* mov dword [ebp-0x54], 0x0 */
        l_0x100c_e6a8:
            ii(0x100c_e6a8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e6ab, 4); cmp(memd[ds, eax + 20], 0);             /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_e6af, 2); if(jz(0x100c_e6db, 0x2a)) goto l_0x100c_e6db; /* jz 0x100ce6db */
            ii(0x100c_e6b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e6b4, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x100c_e6b7, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x100c_e6ba, 4); cmp(memd[ss, ebp - 88], 0);             /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100c_e6be, 2); if(jz(0x100c_e6d4, 0x14)) goto l_0x100c_e6d4; /* jz 0x100ce6d4 */
            ii(0x100c_e6c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e6c2, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x100c_e6c5, 5); call(Definitions.my_dtor_d3, 0x9669);   /* call 0x100d7d33 */
            ii(0x100c_e6ca, 5); call(Definitions.sys_delete, 0x9_7895); /* call 0x10165f64 */
            ii(0x100c_e6cf, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x100c_e6d2, 2); jmp(0x100c_e6db, 7); goto l_0x100c_e6db; /* jmp 0x100ce6db */
        l_0x100c_e6d4:
            ii(0x100c_e6d4, 7); mov(memd[ss, ebp - 92], 0);             /* mov dword [ebp-0x5c], 0x0 */
        l_0x100c_e6db:
            ii(0x100c_e6db, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e6de, 4); cmp(memd[ds, eax + 24], 0);             /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_e6e2, 2); if(jz(0x100c_e70e, 0x2a)) goto l_0x100c_e70e; /* jz 0x100ce70e */
            ii(0x100c_e6e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e6e7, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x100c_e6ea, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x100c_e6ed, 4); cmp(memd[ss, ebp - 96], 0);             /* cmp dword [ebp-0x60], 0x0 */
            ii(0x100c_e6f1, 2); if(jz(0x100c_e707, 0x14)) goto l_0x100c_e707; /* jz 0x100ce707 */
            ii(0x100c_e6f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e6f5, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x100c_e6f8, 5); call(Definitions.my_dtor_d3, 0x9636);   /* call 0x100d7d33 */
            ii(0x100c_e6fd, 5); call(Definitions.sys_delete, 0x9_7862); /* call 0x10165f64 */
            ii(0x100c_e702, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x100c_e705, 2); jmp(0x100c_e70e, 7); goto l_0x100c_e70e; /* jmp 0x100ce70e */
        l_0x100c_e707:
            ii(0x100c_e707, 7); mov(memd[ss, ebp - 100], 0);            /* mov dword [ebp-0x64], 0x0 */
        l_0x100c_e70e:
            ii(0x100c_e70e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e711, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_e714, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e717, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e719, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e71a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e71b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e71c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_e71d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_e71e, 1); ret();                                  /* ret */
        }
    }
}
