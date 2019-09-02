using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_b889-dd3b299c")]
        public void Method_100f_b889()
        {
            ii(0x100f_b889, 5); push(0x38);                             /* push 0x38 */
            ii(0x100f_b88e, 5); call(Definitions.sys_check_available_stack_size, 0x6_a4bf); /* call 0x10165d52 */
            ii(0x100f_b893, 1); push(ebx);                              /* push ebx */
            ii(0x100f_b894, 1); push(ecx);                              /* push ecx */
            ii(0x100f_b895, 1); push(edx);                              /* push edx */
            ii(0x100f_b896, 1); push(esi);                              /* push esi */
            ii(0x100f_b897, 1); push(edi);                              /* push edi */
            ii(0x100f_b898, 1); push(ebp);                              /* push ebp */
            ii(0x100f_b899, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_b89b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_b8a1, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_b8a6, 5); call(0x100e_883d, -0x1_306e);           /* call 0x100e883d */
            ii(0x100f_b8ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_b8ae, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b8b3, 5); call(0x1007_6574, -0x8_5344);           /* call 0x10076574 */
            ii(0x100f_b8b8, 5); call(0x1007_623c, -0x8_5681);           /* call 0x1007623c */
            ii(0x100f_b8bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_b8bf, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b8c2, 5); call(0x1007_6800, -0x8_50c7);           /* call 0x10076800 */
            ii(0x100f_b8c7, 5); call(0x100f_f5c1, 0x3cf5);              /* call 0x100ff5c1 */
            ii(0x100f_b8cc, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b8cf, 5); call(0x1007_6730, -0x8_51a4);           /* call 0x10076730 */
            ii(0x100f_b8d4, 6); mov(memw[ds, eax + 18], 0);             /* mov word [eax+0x12], 0x0 */
            ii(0x100f_b8da, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
            ii(0x100f_b8e1, 2); jmp(0x100f_b8e9, 6); goto l_0x100f_b8e9; /* jmp 0x100fb8e9 */
        l_0x100f_b8e3:
            ii(0x100f_b8e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_b8e6, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x100f_b8e9:
            ii(0x100f_b8e9, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x100f_b8ee, 5); call(0x1007_5fdc, -0x8_5917);           /* call 0x10075fdc */
            ii(0x100f_b8f3, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100f_b8f7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_b8f9, 6); if(jg(0x100f_b9c0, 0xc1)) goto l_0x100f_b9c0; /* jg 0x100fb9c0 */
            ii(0x100f_b8ff, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b902, 5); call(0x1007_6730, -0x8_51d7);           /* call 0x10076730 */
            ii(0x100f_b907, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_b909, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_b90c, 4); mov(memw[ds, edx + 23], ax);            /* mov [edx+0x17], ax */
            ii(0x100f_b910, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b913, 5); call(0x1007_6730, -0x8_51e8);           /* call 0x10076730 */
            ii(0x100f_b918, 3); mov(edx, memd[ds, eax + 16]);           /* mov edx, [eax+0x10] */
            ii(0x100f_b91b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b91e, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x100f_b923, 5); call(0x1007_5fdc, -0x8_594c);           /* call 0x10075fdc */
            ii(0x100f_b928, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_b92a, 2); if(jge(0x100f_b938, 0xc)) goto l_0x100f_b938; /* jge 0x100fb938 */
            ii(0x100f_b92c, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b92f, 5); call(0x1007_6730, -0x8_5204);           /* call 0x10076730 */
            ii(0x100f_b934, 4); inc(memw[ds, eax + 18]);                /* inc word [eax+0x12] */
        l_0x100f_b938:
            ii(0x100f_b938, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b93d, 5); call(0x1007_6574, -0x8_53ce);           /* call 0x10076574 */
            ii(0x100f_b942, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x100f_b945, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b948, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b94c, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100f_b94f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_b951, 3); mov(memd[ss, ebp - 28], edx);           /* mov [ebp-0x1c], edx */
            ii(0x100f_b954, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b959, 5); call(0x1007_6574, -0x8_53ea);           /* call 0x10076574 */
            ii(0x100f_b95e, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x100f_b961, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b964, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b968, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100f_b96b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_b96d, 3); mov(memd[ss, ebp - 20], edx);           /* mov [ebp-0x14], edx */
            ii(0x100f_b970, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b975, 5); call(0x1007_6574, -0x8_5406);           /* call 0x10076574 */
            ii(0x100f_b97a, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x100f_b97d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b980, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b984, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100f_b987, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_b989, 3); mov(memd[ss, ebp - 24], edx);           /* mov [ebp-0x18], edx */
            ii(0x100f_b98c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b991, 5); call(0x1007_6574, -0x8_5422);           /* call 0x10076574 */
            ii(0x100f_b996, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x100f_b999, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b99c, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b9a0, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100f_b9a3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_b9a5, 3); mov(memd[ss, ebp - 16], edx);           /* mov [ebp-0x10], edx */
            ii(0x100f_b9a8, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100f_b9ab, 5); call(0x100f_f562, 0x3bb2);              /* call 0x100ff562 */
        l_0x100f_b9b0:
            ii(0x100f_b9b0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_b9b2, 5); call(0x1010_0efe, 0x5547);              /* call 0x10100efe */
            ii(0x100f_b9b7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_b9b9, 2); if(jz(0x100f_b9b0, -0xb)) goto l_0x100f_b9b0; /* jz 0x100fb9b0 */
            ii(0x100f_b9bb, 5); jmp(0x100f_b8e3, -0xdd); goto l_0x100f_b8e3; /* jmp 0x100fb8e3 */
        l_0x100f_b9c0:
            ii(0x100f_b9c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b9c2, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_b9c5, 5); call(0x1007_5eec, -0x8_5ade);           /* call 0x10075eec */
            ii(0x100f_b9ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_b9cc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_b9cd, 1); pop(edi);                               /* pop edi */
            ii(0x100f_b9ce, 1); pop(esi);                               /* pop esi */
            ii(0x100f_b9cf, 1); pop(edx);                               /* pop edx */
            ii(0x100f_b9d0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_b9d1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_b9d2, 1); ret();                                  /* ret */
        }
    }
}
