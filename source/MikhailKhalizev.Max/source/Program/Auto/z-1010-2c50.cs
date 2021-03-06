using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2c50-6d82c33b")]
        public void Method_1010_2c50()
        {
            ii(0x1010_2c50, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_2c55, 5);  call(Definitions.sys_check_available_stack_size, 0x6_30f8);/* call 0x10165d52 */
            ii(0x1010_2c5a, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_2c5b, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_2c5c, 1);  push(edx);                            /* push edx */
            ii(0x1010_2c5d, 1);  push(esi);                            /* push esi */
            ii(0x1010_2c5e, 1);  push(edi);                            /* push edi */
            ii(0x1010_2c5f, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_2c60, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_2c62, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_2c68, 5);  mov(eax, 0x101b_8ae4);                /* mov eax, 0x101b8ae4 */
            ii(0x1010_2c6d, 5);  call(/* sys */ 0x1016_611f, 0x6_34ad);/* call 0x1016611f */
            ii(0x1010_2c72, 5);  mov(edx, 0x200);                      /* mov edx, 0x200 */
            ii(0x1010_2c77, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1010_2c7c, 5);  call(0x1010_3240, 0x5bf);             /* call 0x10103240 */
            ii(0x1010_2c81, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_2c84, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2c87, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_2c8a, 10);  mov(memd[ds, 0x101b_8aec], 1);       /* mov dword [0x101b8aec], 0x1 */
            ii(0x1010_2c94, 5);  mov(edx, 0x200);                      /* mov edx, 0x200 */
            ii(0x1010_2c99, 5);  mov(eax, 0x101c_39c0);                /* mov eax, 0x101c39c0 */
            ii(0x1010_2c9e, 5);  call(0x1010_3d94, 0x10f1);            /* call 0x10103d94 */
            ii(0x1010_2ca3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_2ca6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_2ca9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_2cac, 10);  mov(memd[ds, 0x101b_8aec], 2);       /* mov dword [0x101b8aec], 0x2 */
            ii(0x1010_2cb6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_2cb8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_2cb9, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_2cba, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_2cbb, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_2cbc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_2cbd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_2cbe, 1);  ret();                                /* ret */
        }
    }
}
