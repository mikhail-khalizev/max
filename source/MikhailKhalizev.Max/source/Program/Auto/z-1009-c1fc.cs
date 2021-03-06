using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c1fc-1419de3a")]
        public void Method_1009_c1fc()
        {
            ii(0x1009_c1fc, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_c201, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9b4c);/* call 0x10165d52 */
            ii(0x1009_c206, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c207, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c208, 1);  push(esi);                            /* push esi */
            ii(0x1009_c209, 1);  push(edi);                            /* push edi */
            ii(0x1009_c20a, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c20b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c20d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1009_c213, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c216, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c219, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1009_c21e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1009_c222, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c225, 5);  call(0x100c_d7e8, 0x3_15be);          /* call 0x100cd7e8 */
            ii(0x1009_c22a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c22d, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_c230, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c233, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c236, 7);  mov(memd[ds, eax + 12], 0x101b_4668); /* mov dword [eax+0xc], 0x101b4668 */
            ii(0x1009_c23d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c240, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_c243, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_c246, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c248, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c249, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c24a, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c24b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c24c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c24d, 1);  ret();                                /* ret */
        }
    }
}
