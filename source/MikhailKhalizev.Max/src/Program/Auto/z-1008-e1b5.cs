using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_e1b5-f1c0e5fa")]
        public void Method_1008_e1b5()
        {
            ii(0x1008_e1b5, 5); push(0x60);                             /* push 0x60 */
            ii(0x1008_e1ba, 5); call(Definitions.sys_check_available_stack_size, 0xd_7b93); /* call 0x10165d52 */
            ii(0x1008_e1bf, 1); push(ebx);                              /* push ebx */
            ii(0x1008_e1c0, 1); push(ecx);                              /* push ecx */
            ii(0x1008_e1c1, 1); push(edx);                              /* push edx */
            ii(0x1008_e1c2, 1); push(esi);                              /* push esi */
            ii(0x1008_e1c3, 1); push(edi);                              /* push edi */
            ii(0x1008_e1c4, 1); push(ebp);                              /* push ebp */
            ii(0x1008_e1c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_e1c7, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1008_e1cd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_e1d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e1d3, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e1d6, 5); call(0x1007_6b90, -0x1_764b);           /* call 0x10076b90 */
            ii(0x1008_e1db, 1); cwde();                                 /* cwde */
            ii(0x1008_e1dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_e1de, 2); if(jz(0x1008_e1e9, 9)) goto l_0x1008_e1e9; /* jz 0x1008e1e9 */
            ii(0x1008_e1e0, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_e1e4, 5); jmp(0x1008_e390, 0x1a7); goto l_0x1008_e390; /* jmp 0x1008e390 */
        l_0x1008_e1e9:
            ii(0x1008_e1e9, 4); or(memb[ss, ebp - 0xc], 1);             /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_e1ed, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e1f0, 5); call(0x1007_64fc, -0x1_7cf9);           /* call 0x100764fc */
            ii(0x1008_e1f5, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_e1f8, 4); and(memb[ss, ebp - 0xc], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_e1fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e1ff, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_e202, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_e205, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_e208, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x1008_e20b, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_e20e, 3); call_abs(memd[ds, ebx + 0x1c]);         /* call dword [ebx+0x1c] */
            ii(0x1008_e211, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_e214, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_e217, 2); jmp(0x1008_e21f, 6); goto l_0x1008_e21f; /* jmp 0x1008e21f */
        l_0x1008_e219:
            ii(0x1008_e219, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_e21c, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1008_e21f:
            ii(0x1008_e21f, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_e223, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x1008_e226, 6); if(jge(0x1008_e356, 0x12a)) goto l_0x1008_e356; /* jge 0x1008e356 */
            ii(0x1008_e22c, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_e22f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_e232, 2); jmp(0x1008_e23a, 6); goto l_0x1008_e23a; /* jmp 0x1008e23a */
        l_0x1008_e234:
            ii(0x1008_e234, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e237, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1008_e23a:
            ii(0x1008_e23a, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e23e, 3); cmp(eax, memd[ss, ebp - 0x24]);         /* cmp eax, [ebp-0x24] */
            ii(0x1008_e241, 6); if(jge(0x1008_e351, 0x10a)) goto l_0x1008_e351; /* jge 0x1008e351 */
            ii(0x1008_e247, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1008_e24b, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1008_e24f, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1008_e254, 5); call(0x1010_3541, 0x7_52e8);            /* call 0x10103541 */
            ii(0x1008_e259, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e25b, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e25e, 5); call(0x1007_643c, -0x1_7e27);           /* call 0x1007643c */
            ii(0x1008_e263, 2); jmp(0x1008_e26d, 8); goto l_0x1008_e26d; /* jmp 0x1008e26d */
        l_0x1008_e265:
            ii(0x1008_e265, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e268, 5); call(0x1007_6bf8, -0x1_7675);           /* call 0x10076bf8 */
        l_0x1008_e26d:
            ii(0x1008_e26d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e26f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e272, 5); call(0x1013_ad71, 0xa_cafa);            /* call 0x1013ad71 */
            ii(0x1008_e277, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e279, 2); if(jz(0x1008_e2bb, 0x40)) goto l_0x1008_e2bb; /* jz 0x1008e2bb */
            ii(0x1008_e27b, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e27e, 5); call(0x1007_63a0, -0x1_7ee3);           /* call 0x100763a0 */
            ii(0x1008_e283, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e285, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1008_e288, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e28b, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_e28e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_e291, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_e293, 2); if(jnz(0x1008_e2b5, 0x20)) goto l_0x1008_e2b5; /* jnz 0x1008e2b5 */
            ii(0x1008_e295, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e298, 5); call(0x1007_63a0, -0x1_7efd);           /* call 0x100763a0 */
            ii(0x1008_e29d, 5); cmp(memw[ds, eax + 8], 0x29);           /* cmp word [eax+0x8], 0x29 */
            ii(0x1008_e2a2, 2); if(jz(0x1008_e2b3, 0xf)) goto l_0x1008_e2b3; /* jz 0x1008e2b3 */
            ii(0x1008_e2a4, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e2a7, 5); call(0x1007_63a0, -0x1_7f0c);           /* call 0x100763a0 */
            ii(0x1008_e2ac, 5); cmp(memw[ds, eax + 8], 0x2a);           /* cmp word [eax+0x8], 0x2a */
            ii(0x1008_e2b1, 2); if(jnz(0x1008_e2b5, 2)) goto l_0x1008_e2b5; /* jnz 0x1008e2b5 */
        l_0x1008_e2b3:
            ii(0x1008_e2b3, 2); jmp(0x1008_e2b7, 2); goto l_0x1008_e2b7; /* jmp 0x1008e2b7 */
        l_0x1008_e2b5:
            ii(0x1008_e2b5, 2); jmp(0x1008_e2b9, 2); goto l_0x1008_e2b9; /* jmp 0x1008e2b9 */
        l_0x1008_e2b7:
            ii(0x1008_e2b7, 2); jmp(0x1008_e2bb, 2); goto l_0x1008_e2bb; /* jmp 0x1008e2bb */
        l_0x1008_e2b9:
            ii(0x1008_e2b9, 2); jmp(0x1008_e265, -0x56); goto l_0x1008_e265; /* jmp 0x1008e265 */
        l_0x1008_e2bb:
            ii(0x1008_e2bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e2bd, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e2c0, 5); call(0x1013_ad71, 0xa_caac);            /* call 0x1013ad71 */
            ii(0x1008_e2c5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e2c7, 6); if(jz(0x1008_e34c, 0x7f)) goto l_0x1008_e34c; /* jz 0x1008e34c */
            ii(0x1008_e2cd, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1008_e2d2, 5); call(Definitions.sys_new, 0xd_7b29);    /* call 0x10165e00 */
            ii(0x1008_e2d7, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1008_e2da, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_e2dd, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_e2e0, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1008_e2e4, 2); if(jz(0x1008_e306, 0x20)) goto l_0x1008_e306; /* jz 0x1008e306 */
            ii(0x1008_e2e6, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e2e9, 5); call(0x1007_63d4, -0x1_7f1a);           /* call 0x100763d4 */
            ii(0x1008_e2ee, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_e2f0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_e2f3, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_e2f6, 5); call(0x1009_abbe, 0xc8c3);              /* call 0x1009abbe */
            ii(0x1008_e2fb, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_e2fe, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_e301, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_e304, 2); jmp(0x1008_e30c, 6); goto l_0x1008_e30c; /* jmp 0x1008e30c */
        l_0x1008_e306:
            ii(0x1008_e306, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_e309, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1008_e30c:
            ii(0x1008_e30c, 3); mov(edx, memd[ss, ebp - 0x40]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_e30f, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_e312, 5); call(0x1008_b060, -0x32b7);             /* call 0x1008b060 */
            ii(0x1008_e317, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_e31a, 5); call(0x1008_af84, -0x339b);             /* call 0x1008af84 */
            ii(0x1008_e31f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e321, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e324, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e327, 5); call(0x1009_ca40, 0xe714);              /* call 0x1009ca40 */
            ii(0x1008_e32c, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_e32f, 5); call(0x1008_af84, -0x33b0);             /* call 0x1008af84 */
            ii(0x1008_e334, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x1008_e339, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e33b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_e33d, 5); call(0x100a_4d50, 0x1_6a0e);            /* call 0x100a4d50 */
            ii(0x1008_e342, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e344, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_e347, 5); call(0x1008_8b7c, -0x57d0);             /* call 0x10088b7c */
        l_0x1008_e34c:
            ii(0x1008_e34c, 5); jmp(0x1008_e234, -0x11d); goto l_0x1008_e234; /* jmp 0x1008e234 */
        l_0x1008_e351:
            ii(0x1008_e351, 5); jmp(0x1008_e219, -0x13d); goto l_0x1008_e219; /* jmp 0x1008e219 */
        l_0x1008_e356:
            ii(0x1008_e356, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_e359, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e35c, 5); call(0x1007_6b90, -0x1_77d1);           /* call 0x10076b90 */
            ii(0x1008_e361, 1); cwde();                                 /* cwde */
            ii(0x1008_e362, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_e364, 2); if(jle(0x1008_e376, 0x10)) goto l_0x1008_e376; /* jle 0x1008e376 */
            ii(0x1008_e366, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_e36a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e36c, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e36f, 5); call(0x1007_5f6c, -0x1_8408);           /* call 0x10075f6c */
            ii(0x1008_e374, 2); jmp(0x1008_e390, 0x1a); goto l_0x1008_e390; /* jmp 0x1008e390 */
        l_0x1008_e376:
            ii(0x1008_e376, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_e37a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e37c, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_e37f, 5); call(0x1007_5f6c, -0x1_8418);           /* call 0x10075f6c */
            ii(0x1008_e384, 2); jmp(0x1008_e390, 0xa); goto l_0x1008_e390; /* jmp 0x1008e390 */
        //  ii(0x1008_e386, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_e388, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
        //  ii(0x1008_e38b, 5); call(0x1007_5f6c, -0x1_8424);           /* call 0x10075f6c */
        l_0x1008_e390:
            ii(0x1008_e390, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1008_e393, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_e395, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_e396, 1); pop(edi);                               /* pop edi */
            ii(0x1008_e397, 1); pop(esi);                               /* pop esi */
            ii(0x1008_e398, 1); pop(edx);                               /* pop edx */
            ii(0x1008_e399, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_e39a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_e39b, 1); ret();                                  /* ret */
        }
    }
}
