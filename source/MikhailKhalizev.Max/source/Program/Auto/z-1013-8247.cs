using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_8247-227ad142")]
        public void Method_1013_8247()
        {
            ii(0x1013_8247, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1013_824c, 5);  call(Definitions.sys_check_available_stack_size, 0x2_db01);/* call 0x10165d52 */
            ii(0x1013_8251, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_8252, 1);  push(esi);                            /* push esi */
            ii(0x1013_8253, 1);  push(edi);                            /* push edi */
            ii(0x1013_8254, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_8255, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_8257, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1013_825d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_8260, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_8263, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_8266, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_8269, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1013_826c, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_826f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_8272, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1013_8275, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_8278, 4);  add(memd[ss, ebp - 36], 0x28);        /* add dword [ebp-0x24], 0x28 */
            ii(0x1013_827c, 4);  add(memd[ss, ebp - 32], 0x27);        /* add dword [ebp-0x20], 0x27 */
            ii(0x1013_8280, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_8283, 5);  add(eax, 0x99);                       /* add eax, 0x99 */
            ii(0x1013_8288, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_828b, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_828e, 3);  add(eax, 0x11);                       /* add eax, 0x11 */
            ii(0x1013_8291, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_8294, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_8297, 3);  cmp(eax, memd[ss, ebp - 36]);         /* cmp eax, [ebp-0x24] */
            ii(0x1013_829a, 2);  if(jl(0x1013_82a4, 8)) goto l_0x1013_82a4;/* jl 0x101382a4 */
            ii(0x1013_829c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_829f, 3);  cmp(eax, memd[ss, ebp - 28]);         /* cmp eax, [ebp-0x1c] */
            ii(0x1013_82a2, 2);  if(jle(0x1013_82a6, 2)) goto l_0x1013_82a6;/* jle 0x101382a6 */
        l_0x1013_82a4:
            ii(0x1013_82a4, 2);  jmp(0x1013_82ae, 8); goto l_0x1013_82ae;/* jmp 0x101382ae */
        l_0x1013_82a6:
            ii(0x1013_82a6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_82a9, 3);  cmp(eax, memd[ss, ebp - 32]);         /* cmp eax, [ebp-0x20] */
            ii(0x1013_82ac, 2);  if(jge(0x1013_82b0, 2)) goto l_0x1013_82b0;/* jge 0x101382b0 */
        l_0x1013_82ae:
            ii(0x1013_82ae, 2);  jmp(0x1013_82b8, 8); goto l_0x1013_82b8;/* jmp 0x101382b8 */
        l_0x1013_82b0:
            ii(0x1013_82b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_82b3, 3);  cmp(eax, memd[ss, ebp - 24]);         /* cmp eax, [ebp-0x18] */
            ii(0x1013_82b6, 2);  if(jle(0x1013_82ba, 2)) goto l_0x1013_82ba;/* jle 0x101382ba */
        l_0x1013_82b8:
            ii(0x1013_82b8, 2);  jmp(0x1013_82c3, 9); goto l_0x1013_82c3;/* jmp 0x101382c3 */
        l_0x1013_82ba:
            ii(0x1013_82ba, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1013_82c1, 2);  jmp(0x1013_82ca, 7); goto l_0x1013_82ca;/* jmp 0x101382ca */
        l_0x1013_82c3:
            ii(0x1013_82c3, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1013_82ca:
            ii(0x1013_82ca, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_82cd, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_82d0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_82d3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_82d5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_82d6, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_82d7, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_82d8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_82d9, 1);  ret();                                /* ret */
        }
    }
}
