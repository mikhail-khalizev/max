using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_355e-5dde084")]
        public void Method_1013_355e()
        {
            ii(0x1013_355e, 5); mov(edi, 0xc283_f455);                  /* mov edi, 0xc283f455 */
            ii(0x1013_3563, 6); or(cl, memb_a32[ds, ecx + 0x1ffa_c1d0]); /* or cl, [ecx+0x1ffac1d0] */
            ii(0x1013_3569, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_356b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_356d, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_3571, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_3574, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3576, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_357a, 3); lea(ebx, eax + 0xa);                    /* lea ebx, [eax+0xa] */
            ii(0x1013_357d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_357f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3582, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3584, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_3587, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_358b, 3); add(edx, 0x9);                          /* add edx, 0x9 */
            ii(0x1013_358e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3590, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3593, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_3595, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_3597, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1013_359b, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1013_359e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_35a0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_35a4, 3); lea(ebx, eax + 0x9);                    /* lea ebx, [eax+0x9] */
            ii(0x1013_35a7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_35a9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_35ac, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_35ae, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35b1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35b6, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x1013_35ba, 5); calld(0x1007_6e7c, -0xb_c743);          /* call 0x10076e7c */
            ii(0x1013_35bf, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_35c2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_35c7, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1013_35cb, 5); calld(0x1007_6e7c, -0xb_c754);          /* call 0x10076e7c */
            ii(0x1013_35d0, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_35d3, 2); if(jmpd_func(0x1013_360a, 0x35)) return; /* jmp 0x1013360a */
        }
    }
}
