using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0de5-a1902a28")]
        public void Method_1013_0de5()
        {
            ii(0x1013_0de5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_0dea, 5); call(Definitions.sys_check_available_stack_size, 0x3_4f63); /* call 0x10165d52 */
            ii(0x1013_0def, 1); push(ebx);                              /* push ebx */
            ii(0x1013_0df0, 1); push(ecx);                              /* push ecx */
            ii(0x1013_0df1, 1); push(esi);                              /* push esi */
            ii(0x1013_0df2, 1); push(edi);                              /* push edi */
            ii(0x1013_0df3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_0df4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0df6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0dfc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_0dff, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_0e02, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_0e05, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_0e08, 7); mov(memb[ds, 0x101b_b48c], 1);          /* mov byte [0x101bb48c], 0x1 */
            ii(0x1013_0e0f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_0e12, 5); call(0x1012_f003, -0x1e14);             /* call 0x1012f003 */
            ii(0x1013_0e17, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_0e1a, 4); cmp(memb[ds, eax + 23], 0);             /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0e1e, 2); if(jz(0x1013_0e29, 9)) goto l_0x1013_0e29; /* jz 0x10130e29 */
            ii(0x1013_0e20, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_0e23, 4); cmp(memb[ds, eax + 23], 1);             /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0e27, 2); if(jnz(0x1013_0e36, 0xd)) goto l_0x1013_0e36; /* jnz 0x10130e36 */
        l_0x1013_0e29:
            ii(0x1013_0e29, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_0e2e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_0e31, 5); call(0x1013_0c16, -0x220);              /* call 0x10130c16 */
        l_0x1013_0e36:
            ii(0x1013_0e36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0e38, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_0e39, 1); pop(edi);                               /* pop edi */
            ii(0x1013_0e3a, 1); pop(esi);                               /* pop esi */
            ii(0x1013_0e3b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0e3c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0e3d, 1); ret();                                  /* ret */
        }
    }
}
