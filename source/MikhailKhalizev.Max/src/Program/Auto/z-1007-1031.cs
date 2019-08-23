using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1031-dec19879")]
        public void Method_1007_1031()
        {
            ii(0x1007_1031, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1007_1036, 5); call(Definitions.sys_check_available_stack_size, 0xf_4d17); /* call 0x10165d52 */
            ii(0x1007_103b, 1); push(ebx);                              /* push ebx */
            ii(0x1007_103c, 1); push(ecx);                              /* push ecx */
            ii(0x1007_103d, 1); push(edx);                              /* push edx */
            ii(0x1007_103e, 1); push(esi);                              /* push esi */
            ii(0x1007_103f, 1); push(edi);                              /* push edi */
            ii(0x1007_1040, 1); push(ebp);                              /* push ebp */
            ii(0x1007_1041, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1043, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_1049, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_104c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_104f, 5); call(0x1007_623c, 0x51e8);              /* call 0x1007623c */
            ii(0x1007_1054, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1007_1057, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_105a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_105c, 2); if(jz(0x1007_1067, 0x9)) goto l_0x1007_1067; /* jz 0x10071067 */
            ii(0x1007_105e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1061, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_1065, 2); if(jnz(0x1007_1073, 0xc)) goto l_0x1007_1073; /* jnz 0x10071073 */
        l_0x1007_1067:
            ii(0x1007_1067, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_106e, 5); jmp(0x1007_1143, 0xd0); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_1073:
            ii(0x1007_1073, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1076, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1007_107a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_107d, 2); jmp(0x1007_10cc, 0x4d); goto l_0x1007_10cc; /* jmp 0x100710cc */
        l_0x1007_107f:
            ii(0x1007_107f, 7); mov(memd[ss, ebp - 0x8], 0xd);          /* mov dword [ebp-0x8], 0xd */
            ii(0x1007_1086, 5); jmp(0x1007_1143, 0xb8); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_108b:
            ii(0x1007_108b, 7); mov(memd[ss, ebp - 0x8], 0xa);          /* mov dword [ebp-0x8], 0xa */
            ii(0x1007_1092, 5); jmp(0x1007_1143, 0xac); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_1097:
            ii(0x1007_1097, 7); mov(memd[ss, ebp - 0x8], 0x10);         /* mov dword [ebp-0x8], 0x10 */
            ii(0x1007_109e, 5); jmp(0x1007_1143, 0xa0); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_10a3:
            ii(0x1007_10a3, 7); mov(memd[ss, ebp - 0x8], 0x1c);         /* mov dword [ebp-0x8], 0x1c */
            ii(0x1007_10aa, 5); jmp(0x1007_1143, 0x94); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_10af:
            ii(0x1007_10af, 7); mov(memd[ss, ebp - 0x8], 0x8);          /* mov dword [ebp-0x8], 0x8 */
            ii(0x1007_10b6, 5); jmp(0x1007_1143, 0x88); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_10bb:
            ii(0x1007_10bb, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_10c2, 5); jmp(0x1007_1143, 0x7c); goto l_0x1007_1143; /* jmp 0x10071143 */
        l_0x1007_10c7:
            ii(0x1007_10c7, 5); jmp(0x1007_113c, 0x70); goto l_0x1007_113c; /* jmp 0x1007113c */
        l_0x1007_10cc:
            ii(0x1007_10cc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_10cf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_10d2, 5); cmp(memw[ss, ebp - 0x10], 0x42);        /* cmp word [ebp-0x10], 0x42 */
            ii(0x1007_10d7, 2); if(jb(0x1007_1114, 0x3b)) goto l_0x1007_1114; /* jb 0x10071114 */
            ii(0x1007_10d9, 5); cmp(memw[ss, ebp - 0x10], 0x43);        /* cmp word [ebp-0x10], 0x43 */
            ii(0x1007_10de, 2); if(jbe(0x1007_107f, -0x61)) goto l_0x1007_107f; /* jbe 0x1007107f */
            ii(0x1007_10e0, 5); cmp(memw[ss, ebp - 0x10], 0x47);        /* cmp word [ebp-0x10], 0x47 */
            ii(0x1007_10e5, 2); if(jb(0x1007_1107, 0x20)) goto l_0x1007_1107; /* jb 0x10071107 */
            ii(0x1007_10e7, 5); cmp(memw[ss, ebp - 0x10], 0x47);        /* cmp word [ebp-0x10], 0x47 */
            ii(0x1007_10ec, 2); if(jbe(0x1007_10af, -0x3f)) goto l_0x1007_10af; /* jbe 0x100710af */
            ii(0x1007_10ee, 5); cmp(memw[ss, ebp - 0x10], 0x4c);        /* cmp word [ebp-0x10], 0x4c */
            ii(0x1007_10f3, 2); if(jb(0x1007_1105, 0x10)) goto l_0x1007_1105; /* jb 0x10071105 */
            ii(0x1007_10f5, 5); cmp(memw[ss, ebp - 0x10], 0x4c);        /* cmp word [ebp-0x10], 0x4c */
            ii(0x1007_10fa, 2); if(jbe(0x1007_1097, -0x65)) goto l_0x1007_1097; /* jbe 0x10071097 */
            ii(0x1007_10fc, 5); cmp(memw[ss, ebp - 0x10], 0x53);        /* cmp word [ebp-0x10], 0x53 */
            ii(0x1007_1101, 2); if(jz(0x1007_10a3, -0x60)) goto l_0x1007_10a3; /* jz 0x100710a3 */
            ii(0x1007_1103, 2); jmp(0x1007_10c7, -0x3e); goto l_0x1007_10c7; /* jmp 0x100710c7 */
        l_0x1007_1105:
            ii(0x1007_1105, 2); jmp(0x1007_10c7, -0x40); goto l_0x1007_10c7; /* jmp 0x100710c7 */
        l_0x1007_1107:
            ii(0x1007_1107, 5); cmp(memw[ss, ebp - 0x10], 0x45);        /* cmp word [ebp-0x10], 0x45 */
            ii(0x1007_110c, 6); if(jz(0x1007_108b, -0x87)) goto l_0x1007_108b; /* jz 0x1007108b */
            ii(0x1007_1112, 2); jmp(0x1007_10c7, -0x4d); goto l_0x1007_10c7; /* jmp 0x100710c7 */
        l_0x1007_1114:
            ii(0x1007_1114, 5); cmp(memw[ss, ebp - 0x10], 0x29);        /* cmp word [ebp-0x10], 0x29 */
            ii(0x1007_1119, 2); if(jb(0x1007_112f, 0x14)) goto l_0x1007_112f; /* jb 0x1007112f */
            ii(0x1007_111b, 5); cmp(memw[ss, ebp - 0x10], 0x2a);        /* cmp word [ebp-0x10], 0x2a */
            ii(0x1007_1120, 2); if(jbe(0x1007_10bb, -0x67)) goto l_0x1007_10bb; /* jbe 0x100710bb */
            ii(0x1007_1122, 5); cmp(memw[ss, ebp - 0x10], 0x37);        /* cmp word [ebp-0x10], 0x37 */
            ii(0x1007_1127, 6); if(jz(0x1007_1097, -0x96)) goto l_0x1007_1097; /* jz 0x10071097 */
            ii(0x1007_112d, 2); jmp(0x1007_10c7, -0x68); goto l_0x1007_10c7; /* jmp 0x100710c7 */
        l_0x1007_112f:
            ii(0x1007_112f, 5); cmp(memw[ss, ebp - 0x10], 0x23);        /* cmp word [ebp-0x10], 0x23 */
            ii(0x1007_1134, 6); if(jz(0x1007_1097, -0xa3)) goto l_0x1007_1097; /* jz 0x10071097 */
            ii(0x1007_113a, 2); jmp(0x1007_10c7, -0x75); goto l_0x1007_10c7; /* jmp 0x100710c7 */
        l_0x1007_113c:
            ii(0x1007_113c, 7); mov(memd[ss, ebp - 0x8], 0xc);          /* mov dword [ebp-0x8], 0xc */
        l_0x1007_1143:
            ii(0x1007_1143, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_1146, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1148, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_1149, 1); pop(edi);                               /* pop edi */
            ii(0x1007_114a, 1); pop(esi);                               /* pop esi */
            ii(0x1007_114b, 1); pop(edx);                               /* pop edx */
            ii(0x1007_114c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_114d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_114e, 1); ret();                                  /* ret */
        }
    }
}
