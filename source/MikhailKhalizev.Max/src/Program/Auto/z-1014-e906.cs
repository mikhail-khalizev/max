using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_e906-9b161c80")]
        public void Method_1014_e906()
        {
            ii(0x1014_e906, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_e90b, 5); call(Definitions.sys_check_available_stack_size, 0x1_7442); /* call 0x10165d52 */
            ii(0x1014_e910, 1); push(esi);                              /* push esi */
            ii(0x1014_e911, 1); push(edi);                              /* push edi */
            ii(0x1014_e912, 1); push(ebp);                              /* push ebp */
            ii(0x1014_e913, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_e915, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_e91b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_e91e, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1014_e921, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_e924, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_e927, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_e92a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_e92d, 5); call(0x1007_6730, -0xd_8202);           /* call 0x10076730 */
            ii(0x1014_e932, 5); cmp(memw[ds, eax + 29], 0);             /* cmp word [eax+0x1d], 0x0 */
            ii(0x1014_e937, 2); if(jz(0x1014_e989, 0x50)) goto l_0x1014_e989; /* jz 0x1014e989 */
            ii(0x1014_e939, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1014_e93d, 1); push(eax);                              /* push eax */
            ii(0x1014_e93e, 5); mov(ecx, 0x101c_8178);                  /* mov ecx, 0x101c8178 */
            ii(0x1014_e943, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_e947, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_e94b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_e94e, 5); call(0x1014_e823, -0x130);              /* call 0x1014e823 */
            ii(0x1014_e953, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1014_e957, 1); push(eax);                              /* push eax */
            ii(0x1014_e958, 5); mov(ecx, 0x101c_819c);                  /* mov ecx, 0x101c819c */
            ii(0x1014_e95d, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_e961, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_e965, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_e968, 5); call(0x1014_e823, -0x14a);              /* call 0x1014e823 */
            ii(0x1014_e96d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1014_e971, 1); push(eax);                              /* push eax */
            ii(0x1014_e972, 5); mov(ecx, 0x101c_8184);                  /* mov ecx, 0x101c8184 */
            ii(0x1014_e977, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_e97b, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_e97f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_e982, 5); call(0x1014_e823, -0x164);              /* call 0x1014e823 */
            ii(0x1014_e987, 2); jmp(0x1014_e9da, 0x51); goto l_0x1014_e9da; /* jmp 0x1014e9da */
        l_0x1014_e989:
            ii(0x1014_e989, 5); call(0x1007_6034, -0xd_895a);           /* call 0x10076034 */
            ii(0x1014_e98e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_e990, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_e992, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_e996, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_e99a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_e99d, 5); call(0x1007_4c30, -0xd_9d72);           /* call 0x10074c30 */
            ii(0x1014_e9a2, 3); lea(ebx, memd[ss, ebp - 20]);           /* lea ebx, [ebp-0x14] */
            ii(0x1014_e9a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_e9a7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_e9a9, 5); call(0x1007_66ac, -0xd_8302);           /* call 0x100766ac */
            ii(0x1014_e9ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_e9b0, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_e9b3, 5); call(0x1013_ad71, -0x1_3c47);           /* call 0x1013ad71 */
            ii(0x1014_e9b8, 2); test(al, al);                           /* test al, al */
            ii(0x1014_e9ba, 2); if(jz(0x1014_e9d0, 0x14)) goto l_0x1014_e9d0; /* jz 0x1014e9d0 */
            ii(0x1014_e9bc, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_e9bf, 5); call(0x1007_6574, -0xd_8450);           /* call 0x10076574 */
            ii(0x1014_e9c4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_e9c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_e9c9, 7); add(memw[ds, edx + 163], ax);           /* add [edx+0xa3], ax */
        l_0x1014_e9d0:
            ii(0x1014_e9d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_e9d2, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_e9d5, 5); call(0x1007_5f2c, -0xd_8aae);           /* call 0x10075f2c */
        l_0x1014_e9da:
            ii(0x1014_e9da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_e9dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_e9dd, 1); pop(edi);                               /* pop edi */
            ii(0x1014_e9de, 1); pop(esi);                               /* pop esi */
            ii(0x1014_e9df, 1); ret();                                  /* ret */
        }
    }
}
