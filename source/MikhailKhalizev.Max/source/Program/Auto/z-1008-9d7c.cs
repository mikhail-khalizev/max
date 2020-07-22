using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9d7c-6c5b014d")]
        public void Method_1008_9d7c()
        {
            ii(0x1008_9d7c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_9d81, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bfcc);/* call 0x10165d52 */
            ii(0x1008_9d86, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9d87, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9d88, 1);  push(edx);                            /* push edx */
            ii(0x1008_9d89, 1);  push(esi);                            /* push esi */
            ii(0x1008_9d8a, 1);  push(edi);                            /* push edi */
            ii(0x1008_9d8b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9d8c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9d8e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9d94, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9d97, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9d9a, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1008_9d9d, 2);  if(jz(0x1008_9da8, 9)) goto l_0x1008_9da8;/* jz 0x10089da8 */
            ii(0x1008_9d9f, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_9da6, 2);  jmp(0x1008_9dc1, 0x19); goto l_0x1008_9dc1;/* jmp 0x10089dc1 */
        l_0x1008_9da8:
            ii(0x1008_9da8, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1008_9dad, 5);  mov(ebx, StringDefinitions.SmartptrH17);/* mov ebx, 0x101a00f8 */
            ii(0x1008_9db2, 5);  mov(edx, StringDefinitions.PtrNotEqual019);/* mov edx, 0x101a0103 */
            ii(0x1008_9db7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_9db9, 5);  call(Definitions.sys_assert, 0xd_bfd4);/* call 0x10165d92 */
            ii(0x1008_9dbe, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_9dc1:
            ii(0x1008_9dc1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9dc4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_9dc6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_9dc9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_9dcc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9dce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9dcf, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9dd0, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9dd1, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9dd2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9dd3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9dd4, 1);  ret();                                /* ret */
        }
    }
}
