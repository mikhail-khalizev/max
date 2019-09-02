using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_feab-604ced0e")]
        public void Method_1013_feab()
        {
            ii(0x1013_feab, 5); push(0x30);                             /* push 0x30 */
            ii(0x1013_feb0, 5); call(Definitions.sys_check_available_stack_size, 0x2_5e9d); /* call 0x10165d52 */
            ii(0x1013_feb5, 1); push(esi);                              /* push esi */
            ii(0x1013_feb6, 1); push(edi);                              /* push edi */
            ii(0x1013_feb7, 1); push(ebp);                              /* push ebp */
            ii(0x1013_feb8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_feba, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_fec0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_fec3, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_fec6, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1013_fec9, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1013_fecc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_fecf, 5); cmp(memw[ds, eax + 0xc], 0);            /* cmp word [eax+0xc], 0x0 */
            ii(0x1013_fed4, 2); if(jz(0x1013_ff3c, 0x66)) goto l_0x1013_ff3c; /* jz 0x1013ff3c */
            ii(0x1013_fed6, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_fedb, 1); push(eax);                              /* push eax */
            ii(0x1013_fedc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_fedf, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1013_fee2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_fee5, 1); push(eax);                              /* push eax */
            ii(0x1013_fee6, 4); movsx(ecx, memw[ss, ebp + 0x10]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_feea, 5); mov(ebx, StringDefinitions.Armor);      /* mov ebx, 0x101acdf3 */
            ii(0x1013_feef, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_fef3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fef6, 5); call(0x1013_f4b0, -0xa4b);              /* call 0x1013f4b0 */
            ii(0x1013_fefb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_fefe, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1013_ff01, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ff04, 1); push(eax);                              /* push eax */
            ii(0x1013_ff05, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ff08, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1013_ff0b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ff0e, 1); push(eax);                              /* push eax */
            ii(0x1013_ff0f, 5); mov(eax, 0x269);                        /* mov eax, 0x269 */
            ii(0x1013_ff14, 1); push(eax);                              /* push eax */
            ii(0x1013_ff15, 5); mov(ecx, 0x269);                        /* mov ecx, 0x269 */
            ii(0x1013_ff1a, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_ff1d, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1013_ff20, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_ff23, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_ff27, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_ff2a, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1013_ff2d, 5); call(0x1013_f629, -0x909);              /* call 0x1013f629 */
            ii(0x1013_ff32, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_ff36, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1013_ff39, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
        l_0x1013_ff3c:
            ii(0x1013_ff3c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ff3f, 5); cmp(memw[ds, eax + 0xa], 0);            /* cmp word [eax+0xa], 0x0 */
            ii(0x1013_ff44, 2); if(jz(0x1013_ffac, 0x66)) goto l_0x1013_ffac; /* jz 0x1013ffac */
            ii(0x1013_ff46, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_ff4b, 1); push(eax);                              /* push eax */
            ii(0x1013_ff4c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_ff4f, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1013_ff52, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ff55, 1); push(eax);                              /* push eax */
            ii(0x1013_ff56, 4); movsx(ecx, memw[ss, ebp + 0x10]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_ff5a, 5); mov(ebx, StringDefinitions.Hits2);      /* mov ebx, 0x101acdf9 */
            ii(0x1013_ff5f, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_ff63, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_ff66, 5); call(0x1013_f4b0, -0xabb);              /* call 0x1013f4b0 */
            ii(0x1013_ff6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_ff6e, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1013_ff71, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ff74, 1); push(eax);                              /* push eax */
            ii(0x1013_ff75, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ff78, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1013_ff7b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ff7e, 1); push(eax);                              /* push eax */
            ii(0x1013_ff7f, 5); mov(eax, 0x26c);                        /* mov eax, 0x26c */
            ii(0x1013_ff84, 1); push(eax);                              /* push eax */
            ii(0x1013_ff85, 5); mov(ecx, 0x26c);                        /* mov ecx, 0x26c */
            ii(0x1013_ff8a, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_ff8d, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1013_ff90, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_ff93, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_ff97, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_ff9a, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1013_ff9d, 5); call(0x1013_f629, -0x979);              /* call 0x1013f629 */
            ii(0x1013_ffa2, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_ffa6, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1013_ffa9, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
        l_0x1013_ffac:
            ii(0x1013_ffac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ffaf, 5); cmp(memw[ds, eax + 0x17], 0);           /* cmp word [eax+0x17], 0x0 */
            ii(0x1013_ffb4, 2); if(jz(0x1014_001c, 0x66)) goto l_0x1014_001c; /* jz 0x1014001c */
            ii(0x1013_ffb6, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_ffbb, 1); push(eax);                              /* push eax */
            ii(0x1013_ffbc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_ffbf, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_ffc2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ffc5, 1); push(eax);                              /* push eax */
            ii(0x1013_ffc6, 4); movsx(ecx, memw[ss, ebp + 0x10]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1013_ffca, 5); mov(ebx, StringDefinitions.Scan);       /* mov ebx, 0x101acdfe */
            ii(0x1013_ffcf, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_ffd3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_ffd6, 5); call(0x1013_f4b0, -0xb2b);              /* call 0x1013f4b0 */
            ii(0x1013_ffdb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_ffde, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_ffe1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ffe4, 1); push(eax);                              /* push eax */
            ii(0x1013_ffe5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ffe8, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_ffeb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_ffee, 1); push(eax);                              /* push eax */
            ii(0x1013_ffef, 5); mov(eax, 0x26d);                        /* mov eax, 0x26d */
            ii(0x1013_fff4, 1); push(eax);                              /* push eax */
            ii(0x1013_fff5, 5); mov(ecx, 0x26d);                        /* mov ecx, 0x26d */
            ii(0x1013_fffa, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1013_fffd, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1014_0000, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0003, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_0007, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_000a, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1014_000d, 5); call(0x1013_f629, -0x9e9);              /* call 0x1013f629 */
            ii(0x1014_0012, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1014_0016, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1014_0019, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
        l_0x1014_001c:
            ii(0x1014_001c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_001f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_0022, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_0025, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_0027, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_0028, 1); pop(edi);                               /* pop edi */
            ii(0x1014_0029, 1); pop(esi);                               /* pop esi */
            ii(0x1014_002a, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
