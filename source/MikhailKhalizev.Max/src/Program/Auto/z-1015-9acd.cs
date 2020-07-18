using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9acd-7f29d83")]
        public void Method_1015_9acd()
        {
            ii(0x1015_9acd, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9ad2, 5);  call(Definitions.sys_check_available_stack_size, 0xc27b);/* call 0x10165d52 */
            ii(0x1015_9ad7, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9ad8, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9ad9, 1);  push(esi);                            /* push esi */
            ii(0x1015_9ada, 1);  push(edi);                            /* push edi */
            ii(0x1015_9adb, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9adc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9ade, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_9ae4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9ae7, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9aea, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9aed, 4);  cmp(memb[ds, eax + 61], 8);           /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9af1, 2);  if(jnz(0x1015_9b0d, 0x1a)) goto l_0x1015_9b0d;/* jnz 0x10159b0d */
            ii(0x1015_9af3, 5);  mov(eax, 0x1015_9680);                /* mov eax, 0x10159680 */
            ii(0x1015_9af8, 1);  push(eax);                            /* push eax */
            ii(0x1015_9af9, 5);  mov(ecx, 0x32);                       /* mov ecx, 0x32 */
            ii(0x1015_9afe, 5);  mov(ebx, StringDefinitions.Start4);   /* mov ebx, 0x101b266a */
            ii(0x1015_9b03, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9b05, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9b08, 5);  call(0x1015_7ccf, -0x1e3e);           /* call 0x10157ccf */
        l_0x1015_9b0d:
            ii(0x1015_9b0d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9b10, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9b13, 5);  call(0x1015_8bbb, -0xf5d);            /* call 0x10158bbb */
            ii(0x1015_9b18, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_9b1a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_9b1b, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_9b1c, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_9b1d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_9b1e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_9b1f, 1);  ret();                                /* ret */
        }
    }
}
