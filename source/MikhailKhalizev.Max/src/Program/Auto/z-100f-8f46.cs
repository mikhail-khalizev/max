using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_8f46-4f28afdb")]
        public void Method_100f_8f46()
        {
            ii(0x100f_8f46, 5); push(0xf8);                             /* push 0xf8 */
            ii(0x100f_8f4b, 5); call(Definitions.sys_check_available_stack_size, 0x6_ce02); /* call 0x10165d52 */
            ii(0x100f_8f50, 1); push(ebx);                              /* push ebx */
            ii(0x100f_8f51, 1); push(ecx);                              /* push ecx */
            ii(0x100f_8f52, 1); push(esi);                              /* push esi */
            ii(0x100f_8f53, 1); push(edi);                              /* push edi */
            ii(0x100f_8f54, 1); push(ebp);                              /* push ebp */
            ii(0x100f_8f55, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_8f57, 6); sub(esp, 0xd4);                         /* sub esp, 0xd4 */
            ii(0x100f_8f5d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_8f60, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_8f63, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8f66, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_8f6a, 2); if(jnz(0x100f_8fa3, 0x37)) goto l_0x100f_8fa3; /* jnz 0x100f8fa3 */
            ii(0x100f_8f6c, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_8f71, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8f76, 5); call(0x1013_dc59, 0x4_4cde);            /* call 0x1013dc59 */
            ii(0x100f_8f7b, 5); call(0x100c_aa00, -0x2_e580);           /* call 0x100caa00 */
            ii(0x100f_8f80, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8f85, 1); push(eax);                              /* push eax */
            ii(0x100f_8f86, 5); call(0x100c_aa20, -0x2_e56b);           /* call 0x100caa20 */
            ii(0x100f_8f8b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8f8d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8f8f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_8f94, 5); mov(eax, StringDefinitions.UnableToTransferToDisabledUnits); /* mov eax, 0x101a276b */
            ii(0x100f_8f99, 5); call(0x1011_5d23, 0x1_cd85);            /* call 0x10115d23 */
            ii(0x100f_8f9e, 5); jmp(0x100f_9113, 0x170); goto l_0x100f_9113; /* jmp 0x100f9113 */
        l_0x100f_8fa3:
            ii(0x100f_8fa3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_8fa6, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x100f_8fa9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_8fac, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100f_8faf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8fb2, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_8fb5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_8fb8, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_8fbb, 6); mov(dl, memb[ds, edx + 0x101c_81d5]);   /* mov dl, [edx+0x101c81d5] */
            ii(0x100f_8fc1, 6); cmp(dl, memb[ds, eax + 0x101c_81d5]);   /* cmp dl, [eax+0x101c81d5] */
            ii(0x100f_8fc7, 2); if(jz(0x100f_9012, 0x49)) goto l_0x100f_9012; /* jz 0x100f9012 */
            ii(0x100f_8fc9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8fcc, 5); call(0x1007_6204, -0x8_2dcd);           /* call 0x10076204 */
            ii(0x100f_8fd1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_8fd3, 2); if(jz(0x100f_8fde, 0x9)) goto l_0x100f_8fde; /* jz 0x100f8fde */
            ii(0x100f_8fd5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8fd8, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100f_8fdc, 2); if(jnz(0x100f_8fe3, 0x5)) goto l_0x100f_8fe3; /* jnz 0x100f8fe3 */
        l_0x100f_8fde:
            ii(0x100f_8fde, 5); jmp(0x100f_9113, 0x130); goto l_0x100f_9113; /* jmp 0x100f9113 */
        l_0x100f_8fe3:
            ii(0x100f_8fe3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_8fe6, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x100f_8fe9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_8fec, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100f_8fef, 6); mov(edx, memd[ds, edx + 0x101c_81d2]);  /* mov edx, [edx+0x101c81d2] */
            ii(0x100f_8ff5, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_8ff8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_8ffb, 5); call(0x1007_6204, -0x8_2dfc);           /* call 0x10076204 */
            ii(0x100f_9000, 5); call(0x100f_744f, -0x1bb6);             /* call 0x100f744f */
            ii(0x100f_9005, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_9008, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_900c, 6); if(jz(0x100f_9113, 0x101)) goto l_0x100f_9113; /* jz 0x100f9113 */
        l_0x100f_9012:
            ii(0x100f_9012, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_9015, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_9018, 5); call(0x1008_a998, -0x6_e685);           /* call 0x1008a998 */
            ii(0x100f_901d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_9020, 5); call(0x1016_5c97, 0x6_cc72);            /* call 0x10165c97 */
            ii(0x100f_9025, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_9028, 5); cmp(memw[ss, ebp - 0xc], 0);            /* cmp word [ebp-0xc], 0x0 */
            ii(0x100f_902d, 6); if(jz(0x100f_9113, 0xe0)) goto l_0x100f_9113; /* jz 0x100f9113 */
            ii(0x100f_9033, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_9036, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_9039, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
            ii(0x100f_903d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_903f, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x100f_9044, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_9047, 5); call(0x1016_3053, 0x6_a007);            /* call 0x10163053 */
            ii(0x100f_904c, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9050, 5); call(/* sys */ 0x1016_5df8, 0x6_cda3);  /* call 0x10165df8 */
            ii(0x100f_9055, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_9058, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_905b, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_905e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9061, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_9064, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x1);  /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x100f_906b, 2); if(jnz(0x100f_9089, 0x1c)) goto l_0x100f_9089; /* jnz 0x100f9089 */
            ii(0x100f_906d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9071, 1); push(eax);                              /* push eax */
            ii(0x100f_9072, 5); mov(eax, StringDefinitions.TotalMaterialsTransferredI); /* mov eax, 0x101a2791 */
            ii(0x100f_9077, 1); push(eax);                              /* push eax */
            ii(0x100f_9078, 6); lea(eax, memd[ss, ebp - 0xd4]);         /* lea eax, [ebp-0xd4] */
            ii(0x100f_907e, 1); push(eax);                              /* push eax */
            ii(0x100f_907f, 5); call(Definitions.sys_sprintf, 0x6_ce7d); /* call 0x10165f01 */
            ii(0x100f_9084, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_9087, 2); jmp(0x100f_90d4, 0x4b); goto l_0x100f_90d4; /* jmp 0x100f90d4 */
        l_0x100f_9089:
            ii(0x100f_9089, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_908c, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_908f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9092, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_9095, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x2);  /* cmp byte [eax+0x101c81d5], 0x2 */
            ii(0x100f_909c, 2); if(jnz(0x100f_90ba, 0x1c)) goto l_0x100f_90ba; /* jnz 0x100f90ba */
            ii(0x100f_909e, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_90a2, 1); push(eax);                              /* push eax */
            ii(0x100f_90a3, 5); mov(eax, StringDefinitions.TotalFuelTransferredI); /* mov eax, 0x101a27b1 */
            ii(0x100f_90a8, 1); push(eax);                              /* push eax */
            ii(0x100f_90a9, 6); lea(eax, memd[ss, ebp - 0xd4]);         /* lea eax, [ebp-0xd4] */
            ii(0x100f_90af, 1); push(eax);                              /* push eax */
            ii(0x100f_90b0, 5); call(Definitions.sys_sprintf, 0x6_ce4c); /* call 0x10165f01 */
            ii(0x100f_90b5, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_90b8, 2); jmp(0x100f_90d4, 0x1a); goto l_0x100f_90d4; /* jmp 0x100f90d4 */
        l_0x100f_90ba:
            ii(0x100f_90ba, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_90be, 1); push(eax);                              /* push eax */
            ii(0x100f_90bf, 5); mov(eax, StringDefinitions.TotalGoldTransferredI); /* mov eax, 0x101a27cc */
            ii(0x100f_90c4, 1); push(eax);                              /* push eax */
            ii(0x100f_90c5, 6); lea(eax, memd[ss, ebp - 0xd4]);         /* lea eax, [ebp-0xd4] */
            ii(0x100f_90cb, 1); push(eax);                              /* push eax */
            ii(0x100f_90cc, 5); call(Definitions.sys_sprintf, 0x6_ce30); /* call 0x10165f01 */
            ii(0x100f_90d1, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x100f_90d4:
            ii(0x100f_90d4, 5); call(0x100c_aa00, -0x2_e6d9);           /* call 0x100caa00 */
            ii(0x100f_90d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_90de, 1); push(eax);                              /* push eax */
            ii(0x100f_90df, 5); call(0x100c_aa20, -0x2_e6c4);           /* call 0x100caa20 */
            ii(0x100f_90e4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_90e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_90e8, 6); lea(esi, memd[ss, ebp - 0xd4]);         /* lea esi, [ebp-0xd4] */
            ii(0x100f_90ee, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_90f0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_90f2, 5); call(0x1011_5d23, 0x1_cc2c);            /* call 0x10115d23 */
            ii(0x100f_90f7, 5); call(0x100d_5470, -0x2_3c8c);           /* call 0x100d5470 */
            ii(0x100f_90fc, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_90ff, 5); mov(ebx, 0x3f4);                        /* mov ebx, 0x3f4 */
            ii(0x100f_9104, 5); mov(edx, 0x3f4);                        /* mov edx, 0x3f4 */
            ii(0x100f_9109, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_910e, 5); call(0x1013_daea, 0x4_49d7);            /* call 0x1013daea */
        l_0x100f_9113:
            ii(0x100f_9113, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_9115, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_9116, 1); pop(edi);                               /* pop edi */
            ii(0x100f_9117, 1); pop(esi);                               /* pop esi */
            ii(0x100f_9118, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_9119, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_911a, 1); ret();                                  /* ret */
        }
    }
}
