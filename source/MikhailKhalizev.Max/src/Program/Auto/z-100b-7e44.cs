using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7e44-6f05b1fc")]
        public void Method_100b_7e44()
        {
            ii(0x100b_7e44, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_7e49, 5);  call(Definitions.sys_check_available_stack_size, 0xa_df04);/* call 0x10165d52 */
            ii(0x100b_7e4e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7e4f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7e50, 1);  push(edx);                            /* push edx */
            ii(0x100b_7e51, 1);  push(esi);                            /* push esi */
            ii(0x100b_7e52, 1);  push(edi);                            /* push edi */
            ii(0x100b_7e53, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7e54, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7e56, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_7e5c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7e5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7e62, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x100b_7e65, 2);  if(jz(0x100b_7e70, 9)) goto l_0x100b_7e70;/* jz 0x100b7e70 */
            ii(0x100b_7e67, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_7e6e, 2);  jmp(0x100b_7e89, 0x19); goto l_0x100b_7e89;/* jmp 0x100b7e89 */
        l_0x100b_7e70:
            ii(0x100b_7e70, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x100b_7e75, 5);  mov(ebx, StringDefinitions.SmartptrH22);/* mov ebx, 0x101a0d7c */
            ii(0x100b_7e7a, 5);  mov(edx, StringDefinitions.PtrNotEqual024);/* mov edx, 0x101a0d87 */
            ii(0x100b_7e7f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100b_7e81, 5);  call(Definitions.sys_assert, 0xa_df0c);/* call 0x10165d92 */
            ii(0x100b_7e86, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100b_7e89:
            ii(0x100b_7e89, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7e8c, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100b_7e8e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_7e91, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_7e94, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7e96, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7e97, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7e98, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7e99, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_7e9a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7e9b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7e9c, 1);  ret();                                /* ret */
        }
    }
}
