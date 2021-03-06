using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b05e-fc2e0bcf")]
        public void Method_1010_b05e()
        {
            ii(0x1010_b05e, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_b063, 5);  call(Definitions.sys_check_available_stack_size, 0x5_acea);/* call 0x10165d52 */
            ii(0x1010_b068, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_b069, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_b06a, 1);  push(edx);                            /* push edx */
            ii(0x1010_b06b, 1);  push(esi);                            /* push esi */
            ii(0x1010_b06c, 1);  push(edi);                            /* push edi */
            ii(0x1010_b06d, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_b06e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_b070, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_b076, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b079, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b07c, 3);  mov(edx, memd[ds, eax + 13]);         /* mov edx, [eax+0xd] */
            ii(0x1010_b07f, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1010_b084, 5);  call(0x100c_aafc, -0x4_058d);         /* call 0x100caafc */
            ii(0x1010_b089, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b08c, 5);  call(0x1010_a3fc, -0xc95);            /* call 0x1010a3fc */
            ii(0x1010_b091, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b094, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_b096, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b099, 5);  call(Definitions.sys_display_draw_0, 0x5_c3e6);/* call 0x10167484 */
            ii(0x1010_b09e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_b0a0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_b0a1, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_b0a2, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_b0a3, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_b0a4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_b0a5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_b0a6, 1);  ret();                                /* ret */
        }
    }
}
