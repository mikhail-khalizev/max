using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_35d5-7bc0ba6e")]
        public void Method_1013_35d5()
        {
            ii(0x1013_35d5, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_35d9, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_35dd, 1); dec(edx);                               /* dec edx */
            ii(0x1013_35de, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_35e1, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_35e6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_35e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_35eb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_35ed, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35f0, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_35f4, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_35f8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_35fb, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_3600, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3602, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3605, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3607, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        }
    }
}
