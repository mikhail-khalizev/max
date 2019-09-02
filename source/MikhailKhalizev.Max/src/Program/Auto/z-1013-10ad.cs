using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_10ad-f3bf1b46")]
        public void Method_1013_10ad()
        {
            ii(0x1013_10ad, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_10b2, 5); call(Definitions.sys_check_available_stack_size, 0x3_4c9b); /* call 0x10165d52 */
            ii(0x1013_10b7, 1); push(ebx);                              /* push ebx */
            ii(0x1013_10b8, 1); push(ecx);                              /* push ecx */
            ii(0x1013_10b9, 1); push(esi);                              /* push esi */
            ii(0x1013_10ba, 1); push(edi);                              /* push edi */
            ii(0x1013_10bb, 1); push(ebp);                              /* push ebp */
            ii(0x1013_10bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_10be, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_10c4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_10c7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_10ca, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_10cd, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_10d0, 7); mov(memb[ds, 0x101c_61b0], 1);          /* mov byte [0x101c61b0], 0x1 */
            ii(0x1013_10d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_10d9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_10dc, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1013_10e2, 5); call(0x100c_fb73, -0x6_1574);           /* call 0x100cfb73 */
            ii(0x1013_10e7, 7); mov(memb[ds, 0x101c_61b1], 0);          /* mov byte [0x101c61b1], 0x0 */
            ii(0x1013_10ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_10f0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_10f3, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1013_10f9, 5); call(0x100c_fb73, -0x6_158b);           /* call 0x100cfb73 */
            ii(0x1013_10fe, 7); mov(memb[ds, 0x101c_61b3], 0);          /* mov byte [0x101c61b3], 0x0 */
            ii(0x1013_1105, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1108, 5); call(0x1012_f003, -0x210a);             /* call 0x1012f003 */
            ii(0x1013_110d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1110, 4); cmp(memb[ds, eax + 23], 0);             /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_1114, 2); if(jz(0x1013_111f, 9)) goto l_0x1013_111f; /* jz 0x1013111f */
            ii(0x1013_1116, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1119, 4); cmp(memb[ds, eax + 23], 1);             /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_111d, 2); if(jnz(0x1013_112c, 0xd)) goto l_0x1013_112c; /* jnz 0x1013112c */
        l_0x1013_111f:
            ii(0x1013_111f, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_1124, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1127, 5); call(0x1013_0c16, -0x516);              /* call 0x10130c16 */
        l_0x1013_112c:
            ii(0x1013_112c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_112e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_112f, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1130, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1131, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1132, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1133, 1); ret();                                  /* ret */
        }
    }
}
