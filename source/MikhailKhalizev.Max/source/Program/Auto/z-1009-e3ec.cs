using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e3ec-f09a7ae3")]
        public void Method_1009_e3ec()
        {
            ii(0x1009_e3ec, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1009_e3f1, 5);  call(Definitions.sys_check_available_stack_size, 0xc_795c);/* call 0x10165d52 */
            ii(0x1009_e3f6, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e3f7, 1);  push(esi);                            /* push esi */
            ii(0x1009_e3f8, 1);  push(edi);                            /* push edi */
            ii(0x1009_e3f9, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e3fa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e3fc, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1009_e402, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_e405, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_e408, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_e40b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_e40e, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_e411, 5);  call(0x1007_5e64, -0x2_85b2);         /* call 0x10075e64 */
            ii(0x1009_e416, 1);  push(eax);                            /* push eax */
            ii(0x1009_e417, 5);  mov(ecx, 0x2200);                     /* mov ecx, 0x2200 */
            ii(0x1009_e41c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_e41e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1009_e422, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e425, 5);  call(0x1009_cc08, -0x1822);           /* call 0x1009cc08 */
            ii(0x1009_e42a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_e42d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_e430, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_e433, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e436, 7);  mov(memd[ds, eax + 2], 0x101b_4a40);  /* mov dword [eax+0x2], 0x101b4a40 */
            ii(0x1009_e43d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e440, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_e443, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_e446, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e448, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e449, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e44a, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e44b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e44c, 1);  ret();                                /* ret */
        }
    }
}
