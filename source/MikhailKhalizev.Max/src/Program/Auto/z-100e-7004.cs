using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7004-b226a451")]
        public void Method_100e_7004()
        {
            ii(0x100e_7004, 5); push(0x1cc);                            /* push 0x1cc */
            ii(0x100e_7009, 5); call(Definitions.sys_check_available_stack_size, 0x7_ed44); /* call 0x10165d52 */
            ii(0x100e_700e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_700f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_7010, 1); push(edx);                              /* push edx */
            ii(0x100e_7011, 1); push(esi);                              /* push esi */
            ii(0x100e_7012, 1); push(edi);                              /* push edi */
            ii(0x100e_7013, 1); push(ebp);                              /* push ebp */
            ii(0x100e_7014, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7016, 6); sub(esp, 0x1a4);                        /* sub esp, 0x1a4 */
            ii(0x100e_701c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_701f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7022, 5); cmp(memw[ds, eax + 0x8], 0x1d);         /* cmp word [eax+0x8], 0x1d */
            ii(0x100e_7027, 2); if(jnz(0x100e_709b, 0x72)) goto l_0x100e_709b; /* jnz 0x100e709b */
            ii(0x100e_7029, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_702c, 4); cmp(memb[ds, eax + 0x3d], 0x7);         /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100e_7030, 2); if(jnz(0x100e_705a, 0x28)) goto l_0x100e_705a; /* jnz 0x100e705a */
            ii(0x100e_7032, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7035, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100e_7038, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_703d, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x100e_7043, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7046, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x100e_7049, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100e_704c, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100e_704f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7051, 7); cmp(memd[ds, eax + 0x101c_a4f4], 0);    /* cmp dword [eax+0x101ca4f4], 0x0 */
            ii(0x100e_7058, 2); if(jz(0x100e_705c, 0x2)) goto l_0x100e_705c; /* jz 0x100e705c */
        l_0x100e_705a:
            ii(0x100e_705a, 2); jmp(0x100e_709b, 0x3f); goto l_0x100e_709b; /* jmp 0x100e709b */
        l_0x100e_705c:
            ii(0x100e_705c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_705f, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x100e_7062, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100e_7065, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7068, 6); push(memd[ds, eax + 0x101b_b4b4]);      /* push dword [eax+0x101bb4b4] */
            ii(0x100e_706e, 5); mov(eax, StringDefinitions.SResearchCompleted); /* mov eax, 0x101a1e24 */
            ii(0x100e_7073, 1); push(eax);                              /* push eax */
            ii(0x100e_7074, 6); lea(eax, ebp - 0x194);                  /* lea eax, [ebp-0x194] */
            ii(0x100e_707a, 1); push(eax);                              /* push eax */
            ii(0x100e_707b, 5); call(Definitions.sys_sprintf, 0x7_ee81); /* call 0x10165f01 */
            ii(0x100e_7080, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_7083, 5); mov(ebx, 0x1_001f);                     /* mov ebx, 0x1001f */
            ii(0x100e_7088, 6); lea(edx, ebp - 0x194);                  /* lea edx, [ebp-0x194] */
            ii(0x100e_708e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7091, 5); call(0x100e_6e2e, -0x268);              /* call 0x100e6e2e */
            ii(0x100e_7096, 5); jmp(0x100e_7181, 0xe6); goto l_0x100e_7181; /* jmp 0x100e7181 */
        l_0x100e_709b:
            ii(0x100e_709b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_709e, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100e_70a2, 6); if(jnz(0x100e_7134, 0x8c)) goto l_0x100e_7134; /* jnz 0x100e7134 */
            ii(0x100e_70a8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_70ab, 5); call(0x1007_611c, -0x7_0f94);           /* call 0x1007611c */
            ii(0x100e_70b0, 6); mov(memd[ss, ebp - 0x198], eax);        /* mov [ebp-0x198], eax */
            ii(0x100e_70b6, 6); lea(edi, ebp - 0x1a4);                  /* lea edi, [ebp-0x1a4] */
            ii(0x100e_70bc, 5); mov(esi, 0x101b_7f44);                  /* mov esi, 0x101b7f44 */
            ii(0x100e_70c1, 1); movsd();                                /* movsd */
            ii(0x100e_70c2, 1); movsd();                                /* movsd */
            ii(0x100e_70c3, 1); movsd();                                /* movsd */
            ii(0x100e_70c4, 6); mov(eax, memd[ss, ebp - 0x198]);        /* mov eax, [ebp-0x198] */
            ii(0x100e_70ca, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100e_70cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_70d0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_70d3, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100e_70d9, 6); mov(eax, memd[ss, ebp - 0x198]);        /* mov eax, [ebp-0x198] */
            ii(0x100e_70df, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100e_70e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_70e5, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_70e8, 6); mov(eax, memd[ds, eax + 0x101c_81d3]);  /* mov eax, [eax+0x101c81d3] */
            ii(0x100e_70ee, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100e_70f1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_70f4, 7); push(memd[ds, eax + ebp - 0x1a4]);      /* push dword [eax+ebp-0x1a4] */
            ii(0x100e_70fb, 6); lea(eax, ebp - 0x194);                  /* lea eax, [ebp-0x194] */
            ii(0x100e_7101, 1); push(eax);                              /* push eax */
            ii(0x100e_7102, 5); call(Definitions.sys_sprintf, 0x7_edfa); /* call 0x10165f01 */
            ii(0x100e_7107, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_710a, 6); mov(eax, memd[ss, ebp - 0x198]);        /* mov eax, [ebp-0x198] */
            ii(0x100e_7110, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100e_7114, 2); if(jz(0x100e_711f, 0x9)) goto l_0x100e_711f; /* jz 0x100e711f */
            ii(0x100e_7116, 6); mov(eax, memd[ss, ebp - 0x198]);        /* mov eax, [ebp-0x198] */
            ii(0x100e_711c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x100e_711f:
            ii(0x100e_711f, 5); mov(ebx, 0x1_001f);                     /* mov ebx, 0x1001f */
            ii(0x100e_7124, 6); lea(edx, ebp - 0x194);                  /* lea edx, [ebp-0x194] */
            ii(0x100e_712a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_712d, 5); call(0x100e_6e2e, -0x304);              /* call 0x100e6e2e */
            ii(0x100e_7132, 2); jmp(0x100e_7181, 0x4d); goto l_0x100e_7181; /* jmp 0x100e7181 */
        l_0x100e_7134:
            ii(0x100e_7134, 7); cmp(memb[ds, 0x101c_37cb], 0);          /* cmp byte [0x101c37cb], 0x0 */
            ii(0x100e_713b, 2); if(jz(0x100e_7146, 0x9)) goto l_0x100e_7146; /* jz 0x100e7146 */
            ii(0x100e_713d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7140, 4); test(memb[ds, eax + 0x14], 0x40);       /* test byte [eax+0x14], 0x40 */
            ii(0x100e_7144, 2); if(jnz(0x100e_7148, 0x2)) goto l_0x100e_7148; /* jnz 0x100e7148 */
        l_0x100e_7146:
            ii(0x100e_7146, 2); jmp(0x100e_7152, 0xa); goto l_0x100e_7152; /* jmp 0x100e7152 */
        l_0x100e_7148:
            ii(0x100e_7148, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_714b, 5); cmp(memw[ds, eax + 0x8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x100e_7150, 2); if(jnz(0x100e_7154, 0x2)) goto l_0x100e_7154; /* jnz 0x100e7154 */
        l_0x100e_7152:
            ii(0x100e_7152, 2); jmp(0x100e_715e, 0xa); goto l_0x100e_715e; /* jmp 0x100e715e */
        l_0x100e_7154:
            ii(0x100e_7154, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7157, 5); cmp(memw[ds, eax + 0x8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x100e_715c, 2); if(jnz(0x100e_7160, 0x2)) goto l_0x100e_7160; /* jnz 0x100e7160 */
        l_0x100e_715e:
            ii(0x100e_715e, 2); jmp(0x100e_7181, 0x21); goto l_0x100e_7181; /* jmp 0x100e7181 */
        l_0x100e_7160:
            ii(0x100e_7160, 6); lea(edx, ebp - 0x194);                  /* lea edx, [ebp-0x194] */
            ii(0x100e_7166, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_7169, 5); call(0x1014_fa43, 0x6_88d5);            /* call 0x1014fa43 */
            ii(0x100e_716e, 5); mov(ebx, 0x1_0004);                     /* mov ebx, 0x10004 */
            ii(0x100e_7173, 6); lea(edx, ebp - 0x194);                  /* lea edx, [ebp-0x194] */
            ii(0x100e_7179, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_717c, 5); call(0x100e_6e2e, -0x353);              /* call 0x100e6e2e */
        l_0x100e_7181:
            ii(0x100e_7181, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7183, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_7184, 1); pop(edi);                               /* pop edi */
            ii(0x100e_7185, 1); pop(esi);                               /* pop esi */
            ii(0x100e_7186, 1); pop(edx);                               /* pop edx */
            ii(0x100e_7187, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_7188, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_7189, 1); ret();                                  /* ret */
        }
    }
}
