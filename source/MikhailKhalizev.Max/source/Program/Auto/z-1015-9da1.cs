using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9da1-20f5a587")]
        public void Method_1015_9da1()
        {
            ii(0x1015_9da1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9da6, 5);  call(Definitions.sys_check_available_stack_size, 0xbfa7);/* call 0x10165d52 */
            ii(0x1015_9dab, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9dac, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9dad, 1);  push(esi);                            /* push esi */
            ii(0x1015_9dae, 1);  push(edi);                            /* push edi */
            ii(0x1015_9daf, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9db0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9db2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_9db8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9dbb, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9dbe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9dc1, 4);  cmp(memb[ds, eax + 61], 8);           /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9dc5, 2);  if(jnz(0x1015_9de3, 0x1c)) goto l_0x1015_9de3;/* jnz 0x10159de3 */
            ii(0x1015_9dc7, 5);  mov(eax, 0x1015_9d42);                /* mov eax, 0x10159d42 */
            ii(0x1015_9dcc, 1);  push(eax);                            /* push eax */
            ii(0x1015_9dcd, 5);  mov(ecx, 0x32);                       /* mov ecx, 0x32 */
            ii(0x1015_9dd2, 5);  mov(ebx, StringDefinitions.Start6);   /* mov ebx, 0x101b2684 */
            ii(0x1015_9dd7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9dd9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9ddc, 5);  call(0x1015_7ccf, -0x2112);           /* call 0x10157ccf */
            ii(0x1015_9de1, 2);  jmp(0x1015_9e17, 0x34); goto l_0x1015_9e17;/* jmp 0x10159e17 */
        l_0x1015_9de3:
            ii(0x1015_9de3, 5);  mov(eax, 0x1015_9d42);                /* mov eax, 0x10159d42 */
            ii(0x1015_9de8, 1);  push(eax);                            /* push eax */
            ii(0x1015_9de9, 5);  mov(ecx, 0x31);                       /* mov ecx, 0x31 */
            ii(0x1015_9dee, 5);  mov(ebx, StringDefinitions.Allocate); /* mov ebx, 0x101b268a */
            ii(0x1015_9df3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9df5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9df8, 5);  call(0x1015_7ccf, -0x212e);           /* call 0x10157ccf */
            ii(0x1015_9dfd, 5);  mov(eax, 0x1015_9712);                /* mov eax, 0x10159712 */
            ii(0x1015_9e02, 1);  push(eax);                            /* push eax */
            ii(0x1015_9e03, 5);  mov(ecx, 0x37);                       /* mov ecx, 0x37 */
            ii(0x1015_9e08, 5);  mov(ebx, StringDefinitions.Stop6);    /* mov ebx, 0x101b2693 */
            ii(0x1015_9e0d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9e0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9e12, 5);  call(0x1015_7ccf, -0x2148);           /* call 0x10157ccf */
        l_0x1015_9e17:
            ii(0x1015_9e17, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9e1a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9e1d, 5);  call(0x1015_8bbb, -0x1267);           /* call 0x10158bbb */
            ii(0x1015_9e22, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_9e24, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_9e25, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_9e26, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_9e27, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_9e28, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_9e29, 1);  ret();                                /* ret */
        }
    }
}
