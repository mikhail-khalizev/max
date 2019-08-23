using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1256-b89a544e")]
        public void Method_1013_1256()
        {
            ii(0x1013_1256, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_125b, 5); call(Definitions.sys_check_available_stack_size, 0x3_4af2); /* call 0x10165d52 */
            ii(0x1013_1260, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1261, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1262, 1); push(esi);                              /* push esi */
            ii(0x1013_1263, 1); push(edi);                              /* push edi */
            ii(0x1013_1264, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1265, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1267, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_126d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1270, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1273, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1276, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_1279, 7); mov(memb[ds, 0x101c_61b2], 0x1);        /* mov byte [0x101c61b2], 0x1 */
            ii(0x1013_1280, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_1283, 5); call(0x1012_f003, -0x2285);             /* call 0x1012f003 */
            ii(0x1013_1288, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_128b, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_128f, 2); if(jnz(0x1013_129e, 0xd)) goto l_0x1013_129e; /* jnz 0x1013129e */
            ii(0x1013_1291, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1296, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_1299, 5); call(0x1013_0c16, -0x688);              /* call 0x10130c16 */
        l_0x1013_129e:
            ii(0x1013_129e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_12a0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_12a1, 1); pop(edi);                               /* pop edi */
            ii(0x1013_12a2, 1); pop(esi);                               /* pop esi */
            ii(0x1013_12a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_12a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_12a5, 1); ret();                                  /* ret */
        }
    }
}
