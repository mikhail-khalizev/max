using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0e3e-33ca7a18")]
        public void Method_1013_0e3e()
        {
            ii(0x1013_0e3e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_0e43, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4f0a);/* call 0x10165d52 */
            ii(0x1013_0e48, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_0e49, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_0e4a, 1);  push(esi);                            /* push esi */
            ii(0x1013_0e4b, 1);  push(edi);                            /* push edi */
            ii(0x1013_0e4c, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_0e4d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_0e4f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_0e55, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_0e58, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_0e5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0e5e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_0e61, 7);  mov(memb[ds, 0x101b_b48c], 0);        /* mov byte [0x101bb48c], 0x0 */
            ii(0x1013_0e68, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0e6b, 5);  call(0x1012_f003, -0x1e6d);           /* call 0x1012f003 */
            ii(0x1013_0e70, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0e73, 4);  cmp(memb[ds, eax + 23], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0e77, 2);  if(jz(0x1013_0e82, 9)) goto l_0x1013_0e82;/* jz 0x10130e82 */
            ii(0x1013_0e79, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0e7c, 4);  cmp(memb[ds, eax + 23], 1);           /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0e80, 2);  if(jnz(0x1013_0e8f, 0xd)) goto l_0x1013_0e8f;/* jnz 0x10130e8f */
        l_0x1013_0e82:
            ii(0x1013_0e82, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_0e87, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0e8a, 5);  call(0x1013_0c16, -0x279);            /* call 0x10130c16 */
        l_0x1013_0e8f:
            ii(0x1013_0e8f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_0e91, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_0e92, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_0e93, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_0e94, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_0e95, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_0e96, 1);  ret();                                /* ret */
        }
    }
}
