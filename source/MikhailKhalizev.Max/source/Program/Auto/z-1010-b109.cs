using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b109-9bd398ac")]
        public void Method_1010_b109()
        {
            ii(0x1010_b109, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_b10e, 5);  call(Definitions.sys_check_available_stack_size, 0x5_ac3f);/* call 0x10165d52 */
            ii(0x1010_b113, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_b114, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_b115, 1);  push(edx);                            /* push edx */
            ii(0x1010_b116, 1);  push(esi);                            /* push esi */
            ii(0x1010_b117, 1);  push(edi);                            /* push edi */
            ii(0x1010_b118, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_b119, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_b11b, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_b121, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b124, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b127, 3);  mov(edx, memd[ds, eax + 13]);         /* mov edx, [eax+0xd] */
            ii(0x1010_b12a, 3);  sub(edx, 0x1c);                       /* sub edx, 0x1c */
            ii(0x1010_b12d, 5);  mov(eax, 0x4d);                       /* mov eax, 0x4d */
            ii(0x1010_b132, 5);  call(0x100c_aafc, -0x4_063b);         /* call 0x100caafc */
            ii(0x1010_b137, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b13a, 5);  call(0x1010_a564, -0xbdb);            /* call 0x1010a564 */
            ii(0x1010_b13f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b142, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_b144, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b147, 5);  call(Definitions.sys_display_draw_0, 0x5_c338);/* call 0x10167484 */
            ii(0x1010_b14c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_b14e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_b14f, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_b150, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_b151, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_b152, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_b153, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_b154, 1);  ret();                                /* ret */
        }
    }
}
