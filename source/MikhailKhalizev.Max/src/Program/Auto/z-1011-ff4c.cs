using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ff4c-f15550e7")]
        public void Method_1011_ff4c()
        {
            ii(0x1011_ff4c, 5); push(0x88);                             /* push 0x88 */
            ii(0x1011_ff51, 5); call(Definitions.sys_check_available_stack_size, 0x4_5dfc); /* call 0x10165d52 */
            ii(0x1011_ff56, 1); push(ebx);                              /* push ebx */
            ii(0x1011_ff57, 1); push(ecx);                              /* push ecx */
            ii(0x1011_ff58, 1); push(esi);                              /* push esi */
            ii(0x1011_ff59, 1); push(edi);                              /* push edi */
            ii(0x1011_ff5a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_ff5b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ff5d, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x1011_ff63, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_ff66, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_ff69, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ff6c, 4); cmp(memb[ds, eax + 0x6], 0);            /* cmp byte [eax+0x6], 0x0 */
            ii(0x1011_ff70, 6); if(jnz(0x1012_0187, 0x211)) goto l_0x1012_0187; /* jnz 0x10120187 */
            ii(0x1011_ff76, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ff79, 5); call(0x1008_a6f8, -0x9_5886);           /* call 0x1008a6f8 */
            ii(0x1011_ff7e, 3); lea(ecx, ebp - 0x3c);                   /* lea ecx, [ebp-0x3c] */
            ii(0x1011_ff81, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_ff83, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1011_ff85, 5); call(0x1011_d987, -0x2603);             /* call 0x1011d987 */
            ii(0x1011_ff8a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ff8d, 3); mov(ecx, memd[ds, eax + 0x9]);          /* mov ecx, [eax+0x9] */
            ii(0x1011_ff90, 3); sar(ecx, 0x18);                         /* sar ecx, 0x18 */
            ii(0x1011_ff93, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ff96, 3); mov(ebx, memd[ds, eax + 0x8]);          /* mov ebx, [eax+0x8] */
            ii(0x1011_ff99, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1011_ff9c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ff9f, 5); call(0x1008_a6f8, -0x9_58ac);           /* call 0x1008a6f8 */
            ii(0x1011_ffa4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_ffa6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ffa9, 3); add(eax, 0x7);                          /* add eax, 0x7 */
            ii(0x1011_ffac, 5); call(0x1007_65d0, -0xa_99e1);           /* call 0x100765d0 */
            ii(0x1011_ffb1, 5); call(0x1011_ef28, -0x108e);             /* call 0x1011ef28 */
            ii(0x1011_ffb6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ffb9, 5); cmp(memw[ds, eax + 0xd], -0x1 /* 0xff */); /* cmp word [eax+0xd], 0xffff */
            ii(0x1011_ffbe, 2); if(jz(0x1011_ffd1, 0x11)) goto l_0x1011_ffd1; /* jz 0x1011ffd1 */
            ii(0x1011_ffc0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ffc3, 3); add(eax, 0x7);                          /* add eax, 0x7 */
            ii(0x1011_ffc6, 5); call(0x1007_6574, -0xa_9a57);           /* call 0x10076574 */
            ii(0x1011_ffcb, 4); test(memb[ds, eax + 0x13], 0x1);        /* test byte [eax+0x13], 0x1 */
            ii(0x1011_ffcf, 2); if(jnz(0x1011_ffd6, 0x5)) goto l_0x1011_ffd6; /* jnz 0x1011ffd6 */
        l_0x1011_ffd1:
            ii(0x1011_ffd1, 5); jmp(0x1012_014c, 0x176); goto l_0x1012_014c; /* jmp 0x1012014c */
        l_0x1011_ffd6:
            ii(0x1011_ffd6, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x1011_ffda, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_ffdd, 5); call(0x1008_bbed, -0x9_43f5);           /* call 0x1008bbed */
            ii(0x1011_ffe2, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1011_ffe5, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1011_ffe9, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1011_ffee, 5); call(Definitions.sys_new, 0x4_5e0d);    /* call 0x10165e00 */
            ii(0x1011_fff3, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1011_fff6, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1011_fff9, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1011_fffc, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1012_0000, 2); if(jz(0x1012_003d, 0x3b)) goto l_0x1012_003d; /* jz 0x1012003d */
            ii(0x1012_0002, 5); call(0x1008_ac70, -0x9_5397);           /* call 0x1008ac70 */
            ii(0x1012_0007, 1); cwde();                                 /* cwde */
            ii(0x1012_0008, 1); push(eax);                              /* push eax */
            ii(0x1012_0009, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
            ii(0x1012_000e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0011, 3); add(eax, 0x7);                          /* add eax, 0x7 */
            ii(0x1012_0014, 5); call(0x1007_6574, -0xa_9aa5);           /* call 0x10076574 */
            ii(0x1012_0019, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1012_001c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_001e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_0021, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0024, 3); mov(edx, memd[ds, eax + 0xb]);          /* mov edx, [eax+0xb] */
            ii(0x1012_0027, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_002a, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1012_002d, 5); call(0x1014_9237, 0x2_9205);            /* call 0x10149237 */
            ii(0x1012_0032, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1012_0035, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1012_0038, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1012_003b, 2); jmp(0x1012_0043, 0x6); goto l_0x1012_0043; /* jmp 0x10120043 */
        l_0x1012_003d:
            ii(0x1012_003d, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1012_0040, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
        l_0x1012_0043:
            ii(0x1012_0043, 3); mov(edx, memd[ss, ebp - 0x58]);         /* mov edx, [ebp-0x58] */
            ii(0x1012_0046, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1012_0049, 5); call(0x1007_66ac, -0xa_99a2);           /* call 0x100766ac */
            ii(0x1012_004e, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1012_0053, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_0058, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1012_005b, 5); call(0x1008_a6f8, -0x9_5968);           /* call 0x1008a6f8 */
            ii(0x1012_0060, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_0062, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1012_0065, 5); call(0x1007_65d0, -0xa_9a9a);           /* call 0x100765d0 */
            ii(0x1012_006a, 5); call(0x1011_ef28, -0x1147);             /* call 0x1011ef28 */
            ii(0x1012_006f, 7); mov(memd[ss, ebp - 0x60], 0);           /* mov dword [ebp-0x60], 0x0 */
            ii(0x1012_0076, 2); jmp(0x1012_007e, 0x6); goto l_0x1012_007e; /* jmp 0x1012007e */
        l_0x1012_0078:
            ii(0x1012_0078, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1012_007b, 3); inc(memd[ss, ebp - 0x60]);              /* inc dword [ebp-0x60] */
        l_0x1012_007e:
            ii(0x1012_007e, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1012_0081, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1012_0088, 6); if(jge(0x1012_0138, 0xaa)) goto l_0x1012_0138; /* jge 0x10120138 */
            ii(0x1012_008e, 7); mov(memd[ss, ebp - 0x64], 0);           /* mov dword [ebp-0x64], 0x0 */
            ii(0x1012_0095, 2); jmp(0x1012_009d, 0x6); goto l_0x1012_009d; /* jmp 0x1012009d */
        l_0x1012_0097:
            ii(0x1012_0097, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1012_009a, 3); inc(memd[ss, ebp - 0x64]);              /* inc dword [ebp-0x64] */
        l_0x1012_009d:
            ii(0x1012_009d, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1012_00a0, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1012_00a7, 6); if(jge(0x1012_0133, 0x86)) goto l_0x1012_0133; /* jge 0x10120133 */
            ii(0x1012_00ad, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_00b1, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1012_00b4, 5); call(0x1008_a728, -0x9_5991);           /* call 0x1008a728 */
            ii(0x1012_00b9, 4); movsx(edx, memw[ss, ebp - 0x64]);       /* movsx edx, word [ebp-0x64] */
            ii(0x1012_00bd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_00bf, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_00c1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_00c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_00c8, 2); if(jnz(0x1012_00e1, 0x17)) goto l_0x1012_00e1; /* jnz 0x101200e1 */
            ii(0x1012_00ca, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_00ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_00d1, 5); call(0x1008_a728, -0x9_59ae);           /* call 0x1008a728 */
            ii(0x1012_00d6, 4); movsx(edx, memw[ss, ebp - 0x64]);       /* movsx edx, word [ebp-0x64] */
            ii(0x1012_00da, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_00dc, 3); or(memb[ds, eax], 0x40);                /* or byte [eax], 0x40 */
            ii(0x1012_00df, 2); jmp(0x1012_012e, 0x4d); goto l_0x1012_012e; /* jmp 0x1012012e */
        l_0x1012_00e1:
            ii(0x1012_00e1, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_00e5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_00e8, 5); call(0x1008_a728, -0x9_59c5);           /* call 0x1008a728 */
            ii(0x1012_00ed, 4); movsx(edx, memw[ss, ebp - 0x64]);       /* movsx edx, word [ebp-0x64] */
            ii(0x1012_00f1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_00f3, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_00f5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_00fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_00fc, 2); if(jnz(0x1012_012e, 0x30)) goto l_0x1012_012e; /* jnz 0x1012012e */
            ii(0x1012_00fe, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_0102, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1012_0105, 5); call(0x1008_a728, -0x9_59e2);           /* call 0x1008a728 */
            ii(0x1012_010a, 4); movsx(edx, memw[ss, ebp - 0x64]);       /* movsx edx, word [ebp-0x64] */
            ii(0x1012_010e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_0110, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_0112, 2); mov(ah, 0x3);                           /* mov ah, 0x3 */
            ii(0x1012_0114, 2); mul(ah);                                /* mul ah */
            ii(0x1012_0116, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1012_0118, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_011a, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_011e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0121, 5); call(0x1008_a728, -0x9_59fe);           /* call 0x1008a728 */
            ii(0x1012_0126, 4); movsx(edx, memw[ss, ebp - 0x64]);       /* movsx edx, word [ebp-0x64] */
            ii(0x1012_012a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_012c, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
        l_0x1012_012e:
            ii(0x1012_012e, 5); jmp(0x1012_0097, -0x9c); goto l_0x1012_0097; /* jmp 0x10120097 */
        l_0x1012_0133:
            ii(0x1012_0133, 5); jmp(0x1012_0078, -0xc0); goto l_0x1012_0078; /* jmp 0x10120078 */
        l_0x1012_0138:
            ii(0x1012_0138, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_013a, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1012_013d, 5); call(0x1007_5f2c, -0xa_a216);           /* call 0x10075f2c */
            ii(0x1012_0142, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_0144, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1012_0147, 5); call(0x1008_bc9f, -0x9_44ad);           /* call 0x1008bc9f */
        l_0x1012_014c:
            ii(0x1012_014c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_014f, 3); add(eax, 0x7);                          /* add eax, 0x7 */
            ii(0x1012_0152, 5); call(0x1007_6574, -0xa_9be3);           /* call 0x10076574 */
            ii(0x1012_0157, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1012_015a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_015d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0160, 3); add(eax, 0x7);                          /* add eax, 0x7 */
            ii(0x1012_0163, 5); call(0x1007_6574, -0xa_9bf4);           /* call 0x10076574 */
            ii(0x1012_0168, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1012_016b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_016e, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1012_0171, 5); call(0x1007_6aac, -0xa_96ca);           /* call 0x10076aac */
            ii(0x1012_0176, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_0178, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1012_017b, 5); call(0x1009_034f, -0x8_fe31);           /* call 0x1009034f */
            ii(0x1012_0180, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0183, 4); mov(memb[ds, eax + 0x6], 0x1);          /* mov byte [eax+0x6], 0x1 */
        l_0x1012_0187:
            ii(0x1012_0187, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_018a, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1012_018c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_018f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_0192, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_0195, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0198, 5); call(0x1008_a728, -0x9_5a75);           /* call 0x1008a728 */
            ii(0x1012_019d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_019f, 3); test(memb[ds, eax], 0x20);              /* test byte [eax], 0x20 */
            ii(0x1012_01a2, 2); if(jz(0x1012_01c1, 0x1d)) goto l_0x1012_01c1; /* jz 0x101201c1 */
            ii(0x1012_01a4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_01a7, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1012_01a9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_01ac, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_01af, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_01b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_01b5, 5); call(0x1008_a728, -0x9_5a92);           /* call 0x1008a728 */
            ii(0x1012_01ba, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_01bc, 3); test(memb[ds, eax], 0x80);              /* test byte [eax], 0x80 */
            ii(0x1012_01bf, 2); if(jz(0x1012_01c3, 0x2)) goto l_0x1012_01c3; /* jz 0x101201c3 */
        l_0x1012_01c1:
            ii(0x1012_01c1, 2); jmp(0x1012_01c9, 0x6); goto l_0x1012_01c9; /* jmp 0x101201c9 */
        l_0x1012_01c3:
            ii(0x1012_01c3, 4); mov(memb[ss, ebp - 0x6c], 0x1);         /* mov byte [ebp-0x6c], 0x1 */
            ii(0x1012_01c7, 2); jmp(0x1012_01cd, 0x4); goto l_0x1012_01cd; /* jmp 0x101201cd */
        l_0x1012_01c9:
            ii(0x1012_01c9, 4); mov(memb[ss, ebp - 0x6c], 0);           /* mov byte [ebp-0x6c], 0x0 */
        l_0x1012_01cd:
            ii(0x1012_01cd, 3); mov(al, memb[ss, ebp - 0x6c]);          /* mov al, [ebp-0x6c] */
            ii(0x1012_01d0, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1012_01d3, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_01d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_01d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_01d9, 1); pop(edi);                               /* pop edi */
            ii(0x1012_01da, 1); pop(esi);                               /* pop esi */
            ii(0x1012_01db, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_01dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_01dd, 1); ret();                                  /* ret */
        }
    }
}
