using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_1216-1e3211dc")]
        public void Method_1012_1216()
        {
            ii(0x1012_1216, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_121b, 5);  call(Definitions.sys_check_available_stack_size, 0x4_4b32);/* call 0x10165d52 */
            ii(0x1012_1220, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_1221, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_1222, 1);  push(edx);                            /* push edx */
            ii(0x1012_1223, 1);  push(esi);                            /* push esi */
            ii(0x1012_1224, 1);  push(edi);                            /* push edi */
            ii(0x1012_1225, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_1226, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_1228, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_122e, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_1231, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_1235, 6);  mov(al, memb[ds, eax + 0x101b_b020]); /* mov al, [eax+0x101bb020] */
            ii(0x1012_123b, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1012_123e, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1012_1241, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_1243, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_1244, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_1245, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_1246, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_1247, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_1248, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_1249, 1);  ret();                                /* ret */
        }
    }
}
