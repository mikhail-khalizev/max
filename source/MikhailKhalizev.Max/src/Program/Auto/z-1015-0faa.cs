using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_0faa-ae0dde79")]
        public void Method_1015_0faa()
        {
            ii(0x1015_0faa, 5); push(0x34);                             /* push 0x34 */
            ii(0x1015_0faf, 5); call(Definitions.sys_check_available_stack_size, 0x1_4d9e); /* call 0x10165d52 */
            ii(0x1015_0fb4, 1); push(ebx);                              /* push ebx */
            ii(0x1015_0fb5, 1); push(ecx);                              /* push ecx */
            ii(0x1015_0fb6, 1); push(esi);                              /* push esi */
            ii(0x1015_0fb7, 1); push(edi);                              /* push edi */
            ii(0x1015_0fb8, 1); push(ebp);                              /* push ebp */
            ii(0x1015_0fb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0fbb, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_0fc1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_0fc4, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_0fc7, 7); mov(memd[ss, ebp - 0x14], 0x3);         /* mov dword [ebp-0x14], 0x3 */
            ii(0x1015_0fce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0fd1, 4); inc(memw[ds, eax + 0x2]);               /* inc word [eax+0x2] */
        l_0x1015_0fd5:
            ii(0x1015_0fd5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0fd8, 3); dec(memw[ds, eax]);                     /* dec word [eax] */
            ii(0x1015_0fdb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0fde, 4); inc(memw[ds, eax + 0x2]);               /* inc word [eax+0x2] */
            ii(0x1015_0fe2, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_0fe9, 2); jmp(0x1015_0fef, 0x4); goto l_0x1015_0fef; /* jmp 0x10150fef */
        l_0x1015_0feb:
            ii(0x1015_0feb, 4); add(memd[ss, ebp - 0xc], 0x2);          /* add dword [ebp-0xc], 0x2 */
        l_0x1015_0fef:
            ii(0x1015_0fef, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_0ff3, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1015_0ff6, 6); if(jge(0x1015_1161, 0x165)) goto l_0x1015_1161; /* jge 0x10151161 */
            ii(0x1015_0ffc, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1015_1003, 2); jmp(0x1015_100b, 0x6); goto l_0x1015_100b; /* jmp 0x1015100b */
        l_0x1015_1005:
            ii(0x1015_1005, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_1008, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1015_100b:
            ii(0x1015_100b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_100e, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1015_1012, 6); if(jge(0x1015_115c, 0x144)) goto l_0x1015_115c; /* jge 0x1015115c */
            ii(0x1015_1018, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_101c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_101f, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1015_1024, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_1026, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1029, 5); call(0x1008_b1a4, -0xc_5e8a);           /* call 0x1008b1a4 */
            ii(0x1015_102e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1031, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1015_1034, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_1036, 2); if(jl(0x1015_1047, 0xf)) goto l_0x1015_1047; /* jl 0x10151047 */
            ii(0x1015_1038, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_103b, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_103e, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1015_1045, 2); if(jl(0x1015_1049, 0x2)) goto l_0x1015_1049; /* jl 0x10151049 */
        l_0x1015_1047:
            ii(0x1015_1047, 2); jmp(0x1015_1055, 0xc); goto l_0x1015_1055; /* jmp 0x10151055 */
        l_0x1015_1049:
            ii(0x1015_1049, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_104c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_104e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1051, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_1053, 2); if(jge(0x1015_1057, 0x2)) goto l_0x1015_1057; /* jge 0x10151057 */
        l_0x1015_1055:
            ii(0x1015_1055, 2); jmp(0x1015_1067, 0x10); goto l_0x1015_1067; /* jmp 0x10151067 */
        l_0x1015_1057:
            ii(0x1015_1057, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_105a, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1015_105e, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1015_1065, 2); if(jl(0x1015_1069, 0x2)) goto l_0x1015_1069; /* jl 0x10151069 */
        l_0x1015_1067:
            ii(0x1015_1067, 2); jmp(0x1015_109b, 0x32); goto l_0x1015_109b; /* jmp 0x1015109b */
        l_0x1015_1069:
            ii(0x1015_1069, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1015_106e, 1); push(eax);                              /* push eax */
            ii(0x1015_106f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1072, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_1074, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1015_1077, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_107a, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1015_107d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1080, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_1083, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1085, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1088, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_108b, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_108e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1091, 5); call(0x1007_02b9, -0xe_0ddd);           /* call 0x100702b9 */
            ii(0x1015_1096, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_1099, 2); if(jnz(0x1015_10a0, 0x5)) goto l_0x1015_10a0; /* jnz 0x101510a0 */
        l_0x1015_109b:
            ii(0x1015_109b, 5); jmp(0x1015_1157, 0xb7); goto l_0x1015_1157; /* jmp 0x10151157 */
        l_0x1015_10a0:
            ii(0x1015_10a0, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1015_10a3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10a6, 5); call(0x1014_edfa, -0x22b1);             /* call 0x1014edfa */
            ii(0x1015_10ab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10ae, 5); call(0x1015_24a1, 0x13ee);              /* call 0x101524a1 */
            ii(0x1015_10b3, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_10b6, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_10bb, 5); call(0x1010_3752, -0x4_d96e);           /* call 0x10103752 */
            ii(0x1015_10c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10c3, 5); call(0x1014_9fa8, -0x7120);             /* call 0x10149fa8 */
            ii(0x1015_10c8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_10cb, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1015_10ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10d1, 4); mov(memw[ds, eax + 0x1a], dx);          /* mov [eax+0x1a], dx */
            ii(0x1015_10d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_10d8, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1015_10dc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10df, 4); mov(memw[ds, eax + 0x1c], dx);          /* mov [eax+0x1c], dx */
            ii(0x1015_10e3, 5); call(0x100d_53f0, -0x7_bcf8);           /* call 0x100d53f0 */
            ii(0x1015_10e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_10ea, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_10ec, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_10ef, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_10f4, 5); call(0x1010_346f, -0x4_dc8a);           /* call 0x1010346f */
            ii(0x1015_10f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_10fc, 5); call(0x1015_48ba, 0x37b9);              /* call 0x101548ba */
            ii(0x1015_1101, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_1106, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1109, 5); call(0x1007_1838, -0xd_f8d6);           /* call 0x10071838 */
            ii(0x1015_110e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1110, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_1113, 5); call(0x1007_65d0, -0xd_ab48);           /* call 0x100765d0 */
            ii(0x1015_1118, 5); call(0x1007_1838, -0xd_f8e5);           /* call 0x10071838 */
            ii(0x1015_111d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1120, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_1124, 2); if(jz(0x1015_112f, 0x9)) goto l_0x1015_112f; /* jz 0x1015112f */
            ii(0x1015_1126, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1129, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1015_112d, 2); if(jnz(0x1015_1131, 0x2)) goto l_0x1015_1131; /* jnz 0x10151131 */
        l_0x1015_112f:
            ii(0x1015_112f, 2); jmp(0x1015_113a, 0x9); goto l_0x1015_113a; /* jmp 0x1015113a */
        l_0x1015_1131:
            ii(0x1015_1131, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1134, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1015_1138, 2); if(jnz(0x1015_114b, 0x11)) goto l_0x1015_114b; /* jnz 0x1015114b */
        l_0x1015_113a:
            ii(0x1015_113a, 5); call(0x1012_0a90, -0x3_06af);           /* call 0x10120a90 */
            ii(0x1015_113f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1141, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_1143, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1146, 5); call(0x1014_f017, -0x2134);             /* call 0x1014f017 */
        l_0x1015_114b:
            ii(0x1015_114b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_114d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_1150, 5); call(0x1007_5f2c, -0xd_b229);           /* call 0x10075f2c */
            ii(0x1015_1155, 2); jmp(0x1015_116a, 0x13); goto l_0x1015_116a; /* jmp 0x1015116a */
        l_0x1015_1157:
            ii(0x1015_1157, 5); jmp(0x1015_1005, -0x157); goto l_0x1015_1005; /* jmp 0x10151005 */
        l_0x1015_115c:
            ii(0x1015_115c, 5); jmp(0x1015_0feb, -0x176); goto l_0x1015_0feb; /* jmp 0x10150feb */
        l_0x1015_1161:
            ii(0x1015_1161, 4); add(memd[ss, ebp - 0x14], 0x2);         /* add dword [ebp-0x14], 0x2 */
            ii(0x1015_1165, 5); jmp(0x1015_0fd5, -0x195); goto l_0x1015_0fd5; /* jmp 0x10150fd5 */
        l_0x1015_116a:
            ii(0x1015_116a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_116c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_116d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_116e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_116f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_1170, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_1171, 1); ret();                                  /* ret */
        }
    }
}
