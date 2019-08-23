using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_dfe7-4e46bf08")]
        public void Method_1015_dfe7()
        {
            ii(0x1015_dfe7, 5); push(0x40);                             /* push 0x40 */
            ii(0x1015_dfec, 5); call(Definitions.sys_check_available_stack_size, 0x7d61); /* call 0x10165d52 */
            ii(0x1015_dff1, 1); push(ebx);                              /* push ebx */
            ii(0x1015_dff2, 1); push(ecx);                              /* push ecx */
            ii(0x1015_dff3, 1); push(edx);                              /* push edx */
            ii(0x1015_dff4, 1); push(esi);                              /* push esi */
            ii(0x1015_dff5, 1); push(edi);                              /* push edi */
            ii(0x1015_dff6, 1); push(ebp);                              /* push ebp */
            ii(0x1015_dff7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_dff9, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_dfff, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_e002, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e005, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1015_e009, 2); if(jnz(0x1015_e014, 0x9)) goto l_0x1015_e014; /* jnz 0x1015e014 */
            ii(0x1015_e00b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e00e, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_e012, 2); if(jz(0x1015_e016, 0x2)) goto l_0x1015_e016; /* jz 0x1015e016 */
        l_0x1015_e014:
            ii(0x1015_e014, 2); jmp(0x1015_e01f, 0x9); goto l_0x1015_e01f; /* jmp 0x1015e01f */
        l_0x1015_e016:
            ii(0x1015_e016, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e019, 4); cmp(memb[ds, eax + 0x59], 0);           /* cmp byte [eax+0x59], 0x0 */
            ii(0x1015_e01d, 2); if(jz(0x1015_e021, 0x2)) goto l_0x1015_e021; /* jz 0x1015e021 */
        l_0x1015_e01f:
            ii(0x1015_e01f, 2); jmp(0x1015_e041, 0x20); goto l_0x1015_e041; /* jmp 0x1015e041 */
        l_0x1015_e021:
            ii(0x1015_e021, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e023, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e026, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e029, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e02e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_e031, 5); mov(ebx, 0x101c_94b4);                  /* mov ebx, 0x101c94b4 */
            ii(0x1015_e036, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_e038, 5); call(0x1013_ad71, -0x2_32cc);           /* call 0x1013ad71 */
            ii(0x1015_e03d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e03f, 2); if(jz(0x1015_e04a, 0x9)) goto l_0x1015_e04a; /* jz 0x1015e04a */
        l_0x1015_e041:
            ii(0x1015_e041, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_e045, 5); jmp(0x1015_e351, 0x307); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e04a:
            ii(0x1015_e04a, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1015_e051, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_e055, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1015_e058, 5); call(Definitions.my_ctor_0x101b_4184, -0xe_756d); /* call 0x10076af0 */
            ii(0x1015_e05d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e060, 5); call(0x1007_623c, -0xe_7e29);           /* call 0x1007623c */
            ii(0x1015_e065, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1015_e069, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_e06c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e06f, 5); call(0x1007_60e4, -0xe_7f90);           /* call 0x100760e4 */
            ii(0x1015_e074, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e076, 6); if(jz(0x1015_e1ad, 0x131)) goto l_0x1015_e1ad; /* jz 0x1015e1ad */
            ii(0x1015_e07c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e07f, 5); call(0x1007_60e4, -0xe_7fa0);           /* call 0x100760e4 */
            ii(0x1015_e084, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_e087, 3); mov(ebx, memd[ss, ebp - 0x1c]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1015_e08a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_e08d, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1015_e090, 5); call(0x1015_d9b1, -0x6e4);              /* call 0x1015d9b1 */
            ii(0x1015_e095, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e097, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1015_e09a, 5); call(0x1008_8b44, -0xd_555b);           /* call 0x10088b44 */
            ii(0x1015_e09f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e0a2, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1015_e0a5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e0aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e0ac, 2); if(jle(0x1015_e0bd, 0xf)) goto l_0x1015_e0bd; /* jle 0x1015e0bd */
            ii(0x1015_e0ae, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e0b1, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1015_e0b4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e0b9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e0bb, 2); if(jnz(0x1015_e0bf, 0x2)) goto l_0x1015_e0bf; /* jnz 0x1015e0bf */
        l_0x1015_e0bd:
            ii(0x1015_e0bd, 2); jmp(0x1015_e0cd, 0xe); goto l_0x1015_e0cd; /* jmp 0x1015e0cd */
        l_0x1015_e0bf:
            ii(0x1015_e0bf, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e0c2, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_e0c5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e0c8, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x1015_e0cb, 2); if(jnz(0x1015_e0cf, 0x2)) goto l_0x1015_e0cf; /* jnz 0x1015e0cf */
        l_0x1015_e0cd:
            ii(0x1015_e0cd, 2); jmp(0x1015_e0d8, 0x9); goto l_0x1015_e0d8; /* jmp 0x1015e0d8 */
        l_0x1015_e0cf:
            ii(0x1015_e0cf, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e0d2, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1015_e0d6, 2); if(jnz(0x1015_e0da, 0x2)) goto l_0x1015_e0da; /* jnz 0x1015e0da */
        l_0x1015_e0d8:
            ii(0x1015_e0d8, 2); jmp(0x1015_e105, 0x2b); goto l_0x1015_e105; /* jmp 0x1015e105 */
        l_0x1015_e0da:
            ii(0x1015_e0da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e0dd, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e0e0, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_e0e2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_e0e5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e0e8, 5); call(0x1007_6074, -0xe_8079);           /* call 0x10076074 */
            ii(0x1015_e0ed, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e0ef, 2); if(jnz(0x1015_e103, 0x12)) goto l_0x1015_e103; /* jnz 0x1015e103 */
            ii(0x1015_e0f1, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e0f4, 5); call(0x1007_623c, -0xe_7ebd);           /* call 0x1007623c */
            ii(0x1015_e0f9, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1015_e0fc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e0ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e101, 2); if(jg(0x1015_e105, 0x2)) goto l_0x1015_e105; /* jg 0x1015e105 */
        l_0x1015_e103:
            ii(0x1015_e103, 2); jmp(0x1015_e11e, 0x19); goto l_0x1015_e11e; /* jmp 0x1015e11e */
        l_0x1015_e105:
            ii(0x1015_e105, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_e10a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e10d, 5); call(0x1015_2605, -0xbb0d);             /* call 0x10152605 */
            ii(0x1015_e112, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1015_e119, 5); jmp(0x1015_e1ad, 0x8f); goto l_0x1015_e1ad; /* jmp 0x1015e1ad */
        l_0x1015_e11e:
            ii(0x1015_e11e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e121, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e124, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e129, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e12f, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_e135, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e13a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_e13d, 2); if(jz(0x1015_e151, 0x12)) goto l_0x1015_e151; /* jz 0x1015e151 */
            ii(0x1015_e13f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e142, 5); call(0x1007_623c, -0xe_7f0b);           /* call 0x1007623c */
            ii(0x1015_e147, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1015_e14a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e14d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e14f, 2); if(jnz(0x1015_e17a, 0x29)) goto l_0x1015_e17a; /* jnz 0x1015e17a */
        l_0x1015_e151:
            ii(0x1015_e151, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1015_e155, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_e159, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_e15c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1015_e15e, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1015_e161, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1015_e164, 5); call(0x1007_5e64, -0xe_8305);           /* call 0x10075e64 */
            ii(0x1015_e169, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1015_e16c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e16e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_e170, 5); call(0x1007_0ca1, -0xe_d4d4);           /* call 0x10070ca1 */
            ii(0x1015_e175, 1); cwde();                                 /* cwde */
            ii(0x1015_e176, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1015_e178, 2); if(jg(0x1015_e17c, 0x2)) goto l_0x1015_e17c; /* jg 0x1015e17c */
        l_0x1015_e17a:
            ii(0x1015_e17a, 2); jmp(0x1015_e185, 0x9); goto l_0x1015_e185; /* jmp 0x1015e185 */
        l_0x1015_e17c:
            ii(0x1015_e17c, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1015_e183, 2); jmp(0x1015_e1ad, 0x28); goto l_0x1015_e1ad; /* jmp 0x1015e1ad */
        l_0x1015_e185:
            ii(0x1015_e185, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e188, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e18b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e190, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e196, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_e19c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e1a1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_e1a4, 2); if(jnz(0x1015_e1ad, 0x7)) goto l_0x1015_e1ad; /* jnz 0x1015e1ad */
            ii(0x1015_e1a6, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1015_e1ad:
            ii(0x1015_e1ad, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1015_e1b1, 2); if(jnz(0x1015_e219, 0x66)) goto l_0x1015_e219; /* jnz 0x1015e219 */
            ii(0x1015_e1b3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e1b6, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e1b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e1be, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e1c4, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_e1ca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e1cf, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1015_e1d2, 2); if(jz(0x1015_e210, 0x3c)) goto l_0x1015_e210; /* jz 0x1015e210 */
            ii(0x1015_e1d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e1d6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e1d9, 5); call(0x1007_60ac, -0xe_8132);           /* call 0x100760ac */
            ii(0x1015_e1de, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1015_e1e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e1e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e1e8, 5); call(0x1016_3053, 0x4e66);              /* call 0x10163053 */
            ii(0x1015_e1ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e1ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e1f2, 5); call(0x1015_2605, -0xbbf2);             /* call 0x10152605 */
            ii(0x1015_e1f7, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_e1fc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e1ff, 5); call(0x1007_6d98, -0xe_746c);           /* call 0x10076d98 */
            ii(0x1015_e204, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e206, 2); if(jz(0x1015_e210, 0x8)) goto l_0x1015_e210; /* jz 0x1015e210 */
            ii(0x1015_e208, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e20b, 5); call(0x1010_094d, -0x5_d8c3);           /* call 0x1010094d */
        l_0x1015_e210:
            ii(0x1015_e210, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_e214, 5); jmp(0x1015_e351, 0x138); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e219:
            ii(0x1015_e219, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1015_e21d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_e221, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_e224, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1015_e226, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1015_e229, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_e22c, 5); call(0x1007_5e64, -0xe_83cd);           /* call 0x10075e64 */
            ii(0x1015_e231, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1015_e234, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e236, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_e238, 5); call(0x1007_0ca1, -0xe_d59c);           /* call 0x10070ca1 */
            ii(0x1015_e23d, 1); cwde();                                 /* cwde */
            ii(0x1015_e23e, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1015_e240, 2); if(jle(0x1015_e277, 0x35)) goto l_0x1015_e277; /* jle 0x1015e277 */
            ii(0x1015_e242, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e244, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e247, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_e24a, 5); call(0x1013_ad11, -0x2_353e);           /* call 0x1013ad11 */
            ii(0x1015_e24f, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e251, 2); if(jnz(0x1015_e263, 0x10)) goto l_0x1015_e263; /* jnz 0x1015e263 */
            ii(0x1015_e253, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e256, 4); mov(dx, memw[ds, eax + 0x41]);          /* mov dx, [eax+0x41] */
            ii(0x1015_e25a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e25d, 4); cmp(dx, memw[ds, eax + 0x1a]);          /* cmp dx, [eax+0x1a] */
            ii(0x1015_e261, 2); if(jz(0x1015_e265, 0x2)) goto l_0x1015_e265; /* jz 0x1015e265 */
        l_0x1015_e263:
            ii(0x1015_e263, 2); jmp(0x1015_e275, 0x10); goto l_0x1015_e275; /* jmp 0x1015e275 */
        l_0x1015_e265:
            ii(0x1015_e265, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e268, 4); mov(dx, memw[ds, eax + 0x43]);          /* mov dx, [eax+0x43] */
            ii(0x1015_e26c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e26f, 4); cmp(dx, memw[ds, eax + 0x1c]);          /* cmp dx, [eax+0x1c] */
            ii(0x1015_e273, 2); if(jz(0x1015_e277, 0x2)) goto l_0x1015_e277; /* jz 0x1015e277 */
        l_0x1015_e275:
            ii(0x1015_e275, 2); jmp(0x1015_e27c, 0x5); goto l_0x1015_e27c; /* jmp 0x1015e27c */
        l_0x1015_e277:
            ii(0x1015_e277, 5); jmp(0x1015_e2eb, 0x6f); goto l_0x1015_e2eb; /* jmp 0x1015e2eb */
        l_0x1015_e27c:
            ii(0x1015_e27c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e27f, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_e283, 2); if(jz(0x1015_e28e, 0x9)) goto l_0x1015_e28e; /* jz 0x1015e28e */
            ii(0x1015_e285, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e288, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1015_e28c, 2); if(jnz(0x1015_e290, 0x2)) goto l_0x1015_e290; /* jnz 0x1015e290 */
        l_0x1015_e28e:
            ii(0x1015_e28e, 2); jmp(0x1015_e299, 0x9); goto l_0x1015_e299; /* jmp 0x1015e299 */
        l_0x1015_e290:
            ii(0x1015_e290, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e293, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1015_e297, 2); if(jnz(0x1015_e2a2, 0x9)) goto l_0x1015_e2a2; /* jnz 0x1015e2a2 */
        l_0x1015_e299:
            ii(0x1015_e299, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_e29c, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_e2a0, 2); if(jnz(0x1015_e2eb, 0x49)) goto l_0x1015_e2eb; /* jnz 0x1015e2eb */
        l_0x1015_e2a2:
            ii(0x1015_e2a2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e2a5, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e2a8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e2ad, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e2b3, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_e2b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e2be, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1015_e2c1, 2); if(jnz(0x1015_e2cc, 0x9)) goto l_0x1015_e2cc; /* jnz 0x1015e2cc */
            ii(0x1015_e2c3, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_e2c7, 5); jmp(0x1015_e351, 0x85); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e2cc:
            ii(0x1015_e2cc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e2cf, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_e2d3, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1015_e2d8, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1015_e2dd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e2e0, 5); call(0x1016_3053, 0x4d6e);              /* call 0x10163053 */
            ii(0x1015_e2e5, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_e2e9, 2); jmp(0x1015_e351, 0x66); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e2eb:
            ii(0x1015_e2eb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e2ee, 4); cmp(memb[ds, eax + 0x50], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x1015_e2f2, 2); if(jz(0x1015_e30c, 0x18)) goto l_0x1015_e30c; /* jz 0x1015e30c */
            ii(0x1015_e2f4, 4); movsx(ecx, memw[ss, ebp - 0x10]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1015_e2f8, 4); movsx(ebx, memw[ss, ebp - 0x16]);       /* movsx ebx, word [ebp-0x16] */
            ii(0x1015_e2fc, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1015_e300, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e303, 5); call(0x1007_0d68, -0xe_d5a0);           /* call 0x10070d68 */
            ii(0x1015_e308, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e30a, 2); if(jnz(0x1015_e312, 0x6)) goto l_0x1015_e312; /* jnz 0x1015e312 */
        l_0x1015_e30c:
            ii(0x1015_e30c, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_e310, 2); jmp(0x1015_e351, 0x3f); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e312:
            ii(0x1015_e312, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1015_e317, 5); call(0x1007_6b90, -0xe_778c);           /* call 0x10076b90 */
            ii(0x1015_e31c, 1); cwde();                                 /* cwde */
            ii(0x1015_e31d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e31f, 2); if(jle(0x1015_e327, 0x6)) goto l_0x1015_e327; /* jle 0x1015e327 */
            ii(0x1015_e321, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_e325, 2); jmp(0x1015_e351, 0x2a); goto l_0x1015_e351; /* jmp 0x1015e351 */
        l_0x1015_e327:
            ii(0x1015_e327, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_e32a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e32d, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_e330, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e335, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_e338, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_e33a, 5); mov(eax, 0x101c_94b4);                  /* mov eax, 0x101c94b4 */
            ii(0x1015_e33f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_e341, 5); call(0x1007_6630, -0xe_7d16);           /* call 0x10076630 */
            ii(0x1015_e346, 7); mov(memb[ds, 0x101c_8170], 0x1);        /* mov byte [0x101c8170], 0x1 */
            ii(0x1015_e34d, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1015_e351:
            ii(0x1015_e351, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1015_e354, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e356, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_e357, 1); pop(edi);                               /* pop edi */
            ii(0x1015_e358, 1); pop(esi);                               /* pop esi */
            ii(0x1015_e359, 1); pop(edx);                               /* pop edx */
            ii(0x1015_e35a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_e35b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_e35c, 1); ret();                                  /* ret */
        }
    }
}
