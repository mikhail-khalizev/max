using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_a96a-c08f53a9")]
        public void Method_1012_a96a()
        {
            ii(0x1012_a96a, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x1012_a96f, 5);  call(Definitions.sys_check_available_stack_size, 0x3_b3de);/* call 0x10165d52 */
            ii(0x1012_a974, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_a975, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_a976, 1);  push(edx);                            /* push edx */
            ii(0x1012_a977, 1);  push(esi);                            /* push esi */
            ii(0x1012_a978, 1);  push(edi);                            /* push edi */
            ii(0x1012_a979, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_a97a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_a97c, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x1012_a982, 7);  mov(memb[ds, 0x101c_5c1c], 0x2c);     /* mov byte [0x101c5c1c], 0x2c */
            ii(0x1012_a989, 6);  mov(edx, memd[ds, 0x101c_59cc]);      /* mov edx, [0x101c59cc] */
            ii(0x1012_a98f, 4);  mov(ax, memw[ds, edx + 20]);          /* mov ax, [edx+0x14] */
            ii(0x1012_a993, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_a999, 5);  mov(eax, StringDefinitions.V104);     /* mov eax, 0x101a864a */
            ii(0x1012_a99e, 5);  call(Definitions.sys_strlen, 0x4_7524);/* call 0x10171ec7 */
            ii(0x1012_a9a3, 5);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x1012_a9a8, 6);  mov(memw[ds, 0x101c_5c1f], ax);       /* mov [0x101c5c1f], ax */
            ii(0x1012_a9ae, 5);  mov(edx, StringDefinitions.V1042);    /* mov edx, 0x101a8650 */
            ii(0x1012_a9b3, 5);  mov(eax, 0x101c_5c21);                /* mov eax, 0x101c5c21 */
            ii(0x1012_a9b8, 5);  call(Definitions.sys_strcpy, 0x3_b512);/* call 0x10165ecf */
            ii(0x1012_a9bd, 5);  mov(eax, memd[ds, 0x101c_59cc]);      /* mov eax, [0x101c59cc] */
            ii(0x1012_a9c2, 6);  lea(edx, memd[ds, eax + 538]);        /* lea edx, [eax+0x21a] */
            ii(0x1012_a9c8, 5);  mov(eax, 0x101c_5c21);                /* mov eax, 0x101c5c21 */
            ii(0x1012_a9cd, 5);  call(Definitions.sys_strcat, 0x3_b55f);/* call 0x10165f31 */
            ii(0x1012_a9d2, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1012_a9d7, 5);  call(0x1012_5be9, -0x4df3);           /* call 0x10125be9 */
            ii(0x1012_a9dc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_a9dd, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_a9de, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_a9df, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_a9e0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_a9e1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_a9e2, 1);  ret();                                /* ret */
        }
    }
}
