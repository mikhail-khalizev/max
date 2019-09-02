using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3d92-87b49170")]
        public void Method_1016_3d92()
        {
            ii(0x1016_3d92, 5); push(0x28);                             /* push 0x28 */
            ii(0x1016_3d97, 5); call(Definitions.sys_check_available_stack_size, 0x1fb6); /* call 0x10165d52 */
            ii(0x1016_3d9c, 1); push(ebx);                              /* push ebx */
            ii(0x1016_3d9d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3d9e, 1); push(esi);                              /* push esi */
            ii(0x1016_3d9f, 1); push(edi);                              /* push edi */
            ii(0x1016_3da0, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3da1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3da3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_3da9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_3dac, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_3daf, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_3db2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3db5, 5); call(0x1016_3c52, -0x168);              /* call 0x10163c52 */
            ii(0x1016_3dba, 2); test(al, al);                           /* test al, al */
            ii(0x1016_3dbc, 2); if(jnz(0x1016_3dc4, 6)) goto l_0x1016_3dc4; /* jnz 0x10163dc4 */
            ii(0x1016_3dbe, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1016_3dc2, 2); jmp(0x1016_3dc8, 4); goto l_0x1016_3dc8; /* jmp 0x10163dc8 */
        l_0x1016_3dc4:
            ii(0x1016_3dc4, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1016_3dc8:
            ii(0x1016_3dc8, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1016_3dcb, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1016_3dce, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1016_3dd1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3dd3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_3dd4, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3dd5, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3dd6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3dd7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_3dd8, 1); ret();                                  /* ret */
        }
    }
}
