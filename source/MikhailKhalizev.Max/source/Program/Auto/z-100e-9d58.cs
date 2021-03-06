using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9d58-f6c637c")]
        public void Method_100e_9d58()
        {
            ii(0x100e_9d58, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_9d5d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_bff0);/* call 0x10165d52 */
            ii(0x100e_9d62, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_9d63, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_9d64, 1);  push(esi);                            /* push esi */
            ii(0x100e_9d65, 1);  push(edi);                            /* push edi */
            ii(0x100e_9d66, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_9d67, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_9d69, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_9d6f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_9d72, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_9d75, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_9d78, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100e_9d7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_9d7d, 2);  cmp(edx, memd[ds, eax]);              /* cmp edx, [eax] */
            ii(0x100e_9d7f, 2);  if(jg(0x100e_9d8f, 0xe)) goto l_0x100e_9d8f;/* jg 0x100e9d8f */
            ii(0x100e_9d81, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_9d84, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x100e_9d87, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_9d8a, 3);  cmp(edx, memd[ds, eax + 8]);          /* cmp edx, [eax+0x8] */
            ii(0x100e_9d8d, 2);  if(jge(0x100e_9d91, 2)) goto l_0x100e_9d91;/* jge 0x100e9d91 */
        l_0x100e_9d8f:
            ii(0x100e_9d8f, 2);  jmp(0x100e_9d9f, 0xe); goto l_0x100e_9d9f;/* jmp 0x100e9d9f */
        l_0x100e_9d91:
            ii(0x100e_9d91, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_9d94, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100e_9d97, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_9d9a, 3);  cmp(edx, memd[ds, eax + 4]);          /* cmp edx, [eax+0x4] */
            ii(0x100e_9d9d, 2);  if(jle(0x100e_9da1, 2)) goto l_0x100e_9da1;/* jle 0x100e9da1 */
        l_0x100e_9d9f:
            ii(0x100e_9d9f, 2);  jmp(0x100e_9daf, 0xe); goto l_0x100e_9daf;/* jmp 0x100e9daf */
        l_0x100e_9da1:
            ii(0x100e_9da1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_9da4, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x100e_9da7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_9daa, 3);  cmp(edx, memd[ds, eax + 12]);         /* cmp edx, [eax+0xc] */
            ii(0x100e_9dad, 2);  if(jge(0x100e_9db1, 2)) goto l_0x100e_9db1;/* jge 0x100e9db1 */
        l_0x100e_9daf:
            ii(0x100e_9daf, 2);  jmp(0x100e_9db7, 6); goto l_0x100e_9db7;/* jmp 0x100e9db7 */
        l_0x100e_9db1:
            ii(0x100e_9db1, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_9db5, 2);  jmp(0x100e_9dbb, 4); goto l_0x100e_9dbb;/* jmp 0x100e9dbb */
        l_0x100e_9db7:
            ii(0x100e_9db7, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100e_9dbb:
            ii(0x100e_9dbb, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100e_9dbe, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100e_9dc1, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100e_9dc4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_9dc6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_9dc7, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_9dc8, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_9dc9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_9dca, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_9dcb, 1);  ret();                                /* ret */
        }
    }
}
