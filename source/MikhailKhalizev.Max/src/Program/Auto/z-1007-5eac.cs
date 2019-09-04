using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5eac-6058174")]
        public void Method_1007_5eac()
        {
            ii(0x1007_5eac, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_5eb1, 5); call(Definitions.sys_check_available_stack_size, 0xe_fe9c); /* call 0x10165d52 */
            ii(0x1007_5eb6, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5eb7, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5eb8, 1); push(esi);                              /* push esi */
            ii(0x1007_5eb9, 1); push(edi);                              /* push edi */
            ii(0x1007_5eba, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5ebb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5ebd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5ec3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_5ec6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_5ec9, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1007_5ece, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5ed1, 5); call(Definitions.my_dtor_0x101b_6edc, 0xc_4d6f); /* call 0x1013ac45 */
            ii(0x1007_5ed6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_5ed9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5edc, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_5edf, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_5ee2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5ee4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5ee5, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5ee6, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5ee7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5ee8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5ee9, 1); ret();                                  /* ret */
        }
    }
}
