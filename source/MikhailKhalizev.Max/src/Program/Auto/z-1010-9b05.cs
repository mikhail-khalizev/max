using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_9b05-3e645f43")]
        public void Method_1010_9b05()
        {
            ii(0x1010_9b05, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_9b0a, 5);  call(Definitions.sys_check_available_stack_size, 0x5_c243);/* call 0x10165d52 */
            ii(0x1010_9b0f, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_9b10, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_9b11, 1);  push(edx);                            /* push edx */
            ii(0x1010_9b12, 1);  push(esi);                            /* push esi */
            ii(0x1010_9b13, 1);  push(edi);                            /* push edi */
            ii(0x1010_9b14, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_9b15, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_9b17, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_9b1d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_9b20, 6);  mov(edx, memd[ds, 0x101c_4de8]);      /* mov edx, [0x101c4de8] */
            ii(0x1010_9b26, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_9b29, 5);  mov(eax, memd[ds, 0x101c_4de6]);      /* mov eax, [0x101c4de6] */
            ii(0x1010_9b2e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_9b31, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_9b33, 5);  mov(eax, memd[ds, 0x101c_4dea]);      /* mov eax, [0x101c4dea] */
            ii(0x1010_9b38, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_9b3b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1010_9b3d, 2);  if(jge(0x1010_9b81, 0x42)) goto l_0x1010_9b81;/* jge 0x10109b81 */
            ii(0x1010_9b3f, 6);  mov(ax, memw[ds, 0x101c_4dea]);       /* mov ax, [0x101c4dea] */
            ii(0x1010_9b45, 7);  add(ax, memw[ds, 0x101c_4de8]);       /* add ax, [0x101c4de8] */
            ii(0x1010_9b4c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1010_9b4f:
            ii(0x1010_9b4f, 5);  call(0x1014_82f4, 0x3_e7a0);          /* call 0x101482f4 */
            ii(0x1010_9b54, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_9b57, 7);  inc(memw[ds, 0x101c_4dea]);           /* inc word [0x101c4dea] */
            ii(0x1010_9b5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_9b61, 5);  call(0x1010_96e0, -0x486);            /* call 0x101096e0 */
        l_0x1010_9b66:
            ii(0x1010_9b66, 5);  call(0x1014_82f4, 0x3_e789);          /* call 0x101482f4 */
            ii(0x1010_9b6b, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1010_9b6e, 5);  cmp(eax, 0x308c);                     /* cmp eax, 0x308c */
            ii(0x1010_9b73, 2);  if(jb(0x1010_9b66, -0xf)) goto l_0x1010_9b66;/* jb 0x10109b66 */
            ii(0x1010_9b75, 6);  mov(ax, memw[ds, 0x101c_4dea]);       /* mov ax, [0x101c4dea] */
            ii(0x1010_9b7b, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1010_9b7f, 2);  if(jnz(0x1010_9b4f, -0x32)) goto l_0x1010_9b4f;/* jnz 0x10109b4f */
        l_0x1010_9b81:
            ii(0x1010_9b81, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_9b83, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_9b84, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_9b85, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_9b86, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_9b87, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_9b88, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_9b89, 1);  ret();                                /* ret */
        }
    }
}
