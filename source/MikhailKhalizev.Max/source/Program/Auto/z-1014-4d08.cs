using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4d08-e17edfa")]
        public void Method_1014_4d08()
        {
            ii(0x1014_4d08, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_4d0d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_1040);/* call 0x10165d52 */
            ii(0x1014_4d12, 1);  push(esi);                            /* push esi */
            ii(0x1014_4d13, 1);  push(edi);                            /* push edi */
            ii(0x1014_4d14, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_4d15, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_4d17, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_4d1d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_4d20, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1014_4d23, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_4d26, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_4d29, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1014_4d2d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_4d30, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1014_4d33, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_4d36, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1014_4d3a, 5);  or(eax, 0x1_0000);                    /* or eax, 0x10000 */
            ii(0x1014_4d3f, 1);  push(eax);                            /* push eax */
            ii(0x1014_4d40, 4);  movsx(ecx, memw[ss, ebp + 20]);       /* movsx ecx, word [ebp+0x14] */
            ii(0x1014_4d44, 5);  mov(ebx, 0x280);                      /* mov ebx, 0x280 */
            ii(0x1014_4d49, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_4d4c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_4d4f, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_4d52, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_4d55, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */
            ii(0x1014_4d5b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_4d5d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_4d5e, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_4d5f, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_4d60, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
