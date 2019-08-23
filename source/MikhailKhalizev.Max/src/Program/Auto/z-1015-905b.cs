using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_905b-d0cf90d3")]
        public void Method_1015_905b()
        {
            ii(0x1015_905b, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_9060, 5); call(Definitions.sys_check_available_stack_size, 0xcced); /* call 0x10165d52 */
            ii(0x1015_9065, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9066, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9067, 1); push(esi);                              /* push esi */
            ii(0x1015_9068, 1); push(edi);                              /* push edi */
            ii(0x1015_9069, 1); push(ebp);                              /* push ebp */
            ii(0x1015_906a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_906c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_9072, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9075, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9078, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_907b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_907e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9083, 5); call(0x100f_448c, -0x6_4bfc);           /* call 0x100f448c */
            ii(0x1015_9088, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_908b, 5); call(0x1008_aa4c, -0xc_e644);           /* call 0x1008aa4c */
            ii(0x1015_9090, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1015_9092, 2); if(jnz(0x1015_90a8, 0x14)) goto l_0x1015_90a8; /* jnz 0x101590a8 */
            ii(0x1015_9094, 5); mov(ebx, 0x2b);                         /* mov ebx, 0x2b */
            ii(0x1015_9099, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1015_909e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_90a1, 5); call(0x1016_3053, 0x9fad);              /* call 0x10163053 */
            ii(0x1015_90a6, 2); jmp(0x1015_90f4, 0x4c); goto l_0x1015_90f4; /* jmp 0x101590f4 */
        l_0x1015_90a8:
            ii(0x1015_90a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_90ab, 5); call(0x1007_623c, -0xe_2e74);           /* call 0x1007623c */
            ii(0x1015_90b0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_90b3, 4); mov(dx, memw[ds, edx + 0x52]);          /* mov dx, [edx+0x52] */
            ii(0x1015_90b7, 4); cmp(dx, memw[ds, eax + 0x19]);          /* cmp dx, [eax+0x19] */
            ii(0x1015_90bb, 2); if(jnz(0x1015_90e2, 0x25)) goto l_0x1015_90e2; /* jnz 0x101590e2 */
            ii(0x1015_90bd, 5); call(0x100c_aa00, -0x8_e6c2);           /* call 0x100caa00 */
            ii(0x1015_90c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_90c7, 1); push(eax);                              /* push eax */
            ii(0x1015_90c8, 5); call(0x100c_aa20, -0x8_e6ad);           /* call 0x100caa20 */
            ii(0x1015_90cd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_90cf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_90d1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_90d6, 5); mov(eax, StringDefinitions.MinelayerIsFullCannotPickUpMoreMines); /* mov eax, 0x101b2564 */
            ii(0x1015_90db, 5); call(0x1011_5d23, -0x4_33bd);           /* call 0x10115d23 */
            ii(0x1015_90e0, 2); jmp(0x1015_90f4, 0x12); goto l_0x1015_90f4; /* jmp 0x101590f4 */
        l_0x1015_90e2:
            ii(0x1015_90e2, 5); mov(ebx, 0x2d);                         /* mov ebx, 0x2d */
            ii(0x1015_90e7, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1015_90ec, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_90ef, 5); call(0x1016_3053, 0x9f5f);              /* call 0x10163053 */
        l_0x1015_90f4:
            ii(0x1015_90f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_90f6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_90f7, 1); pop(edi);                               /* pop edi */
            ii(0x1015_90f8, 1); pop(esi);                               /* pop esi */
            ii(0x1015_90f9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_90fa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_90fb, 1); ret();                                  /* ret */
        }
    }
}
